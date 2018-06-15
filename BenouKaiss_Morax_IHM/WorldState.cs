using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace VivianeProject
{
    /// <summary>
    /// This class contains the status of a single game.
    /// Methods are invoked from, or make use of, the GameController
    /// static methods.
    /// </summary>
    public class WorldState
    {
        public enum Difficulty { Easy, Medium, Hard };
        #region world-status variables for a single game
        private int turnsLeft = -1;
        private int turns = 0;

        private List<IndexedValue> values = new List<IndexedValue>();
        private List<IndexedValue> groups = new List<IndexedValue>();
        private List<IndexedValue> indicators = new List<IndexedValue>();
        private List<IndexedValue> policies = new List<IndexedValue>();
        private List<IndexedValue> perks = new List<IndexedValue>();
        private List<IndexedValue> crises = new List<IndexedValue>();
        private List<List<string>> valuesLog = new List<List<string>>();
        private int glory = 0;
        private int money = 0;
        #endregion
        #region read-only accessor properties
        public int TurnsLeft { get { return turnsLeft; } }
        public int Turns { get { return turns; } }
        public List<IndexedValue> Values { get { return values; } }
        public List<IndexedValue> Groups { get { return groups; } }
        public List<IndexedValue> Indicators { get { return indicators; } }
        public List<IndexedValue> Policies { get { return policies; } }
        public List<IndexedValue> Expenses { get {
                return Policies.FindAll(p=>p.MoneyAmount < 0 && p.GloryAmount < 0);
            }
        }
        public List<IndexedValue> Taxes {  get
            {
                return Policies.FindAll(p => p.MoneyAmount > 0 && p.GloryAmount < 0);
            }
        }
        public List<IndexedValue> Quests {  get
            {
                return Policies.FindAll(p=>p.GloryAmount > 0);
            }
        }
        public List<IndexedValue> Perks { get { return perks; } }
        public List<IndexedValue> Crises { get { return crises; } }
        public List<List<string>> ValuesLog { get { return valuesLog; } }
        public int Glory { get { return glory; } }
        public int Money { get { return money; } }

        #endregion
        #region external game manipulation handlers
        public void NextTurn()
        {
            List<string> valuesThisTurn = new List<string>();
            values.ForEach(v => valuesThisTurn.Add(v.ToString()));
            valuesThisTurn.Add("gloire:" + glory);
            valuesThisTurn.Add("finances:" + money);
            valuesLog.Add(valuesThisTurn);
            values.FindAll(v => v.Active != false).ForEach(p => p.Propagate());
            values.ForEach(v => v.Update());
            indicators.FindAll(i => i.Active != false && i.GloryAmount != null).ForEach(i => { money += i.MoneyImpacted; glory += i.GloryImpacted; });
            policies.FindAll(p => p.Active != false && p.MoneyAmount < 0).ForEach(p => money -= p.MoneyImpacted);
            policies.FindAll(p => p.Active != false && p.MoneyAmount > 0).ForEach(p => money += p.MoneyImpacted);
            policies.FindAll(p => p.Active != false && p.GloryAmount > 0).ForEach(p => glory += p.GloryImpacted);
            perks.FindAll(p => p.Active == true).ForEach(p => { money += p.MoneyImpacted; glory += p.GloryImpacted; });
            perks.FindAll(p => p.Active == false).ForEach(p => p.CheckActivation());
            crises.FindAll(c => c.Active == true).ForEach(c => { money -= c.MoneyImpacted; glory -= c.GloryImpacted; });
            crises.FindAll(c => c.Active == false).ForEach(c => c.CheckActivation());
            turns++;
            if (turnsLeft > 0)
            {
                turnsLeft--;
            }

            if (crises.Exists(c => c.Result == IndexedValue.ResultType.Lose && c.Active == true) || money < 0)
            {
                GameControler.LoseDialog(crises.Find(c => c.Result == IndexedValue.ResultType.Lose && c.Active == true));
                turnsLeft = 0;
            }
            else if (perks.Exists(p => p.Result == IndexedValue.ResultType.Win && p.Active == true)) {
                GameControler.WinDialog();
                turnsLeft = 0;
            }
        }
        public IndexedValue FindPolicyOrDefault(string pol)
        {
            List<IndexedValue> iVs = policies.FindAll(p => p.Name.ToLower().Equals(pol.ToLower()));
            if (iVs.Count==1)
            {
                return iVs[0];
            }
            return null;
        }
        public void DeactivatePolicy(IndexedValue val, out int mCost, out int gCost)
        {
            val.Deactivate(out mCost, out gCost);
            GameControler.DeactivatePolicyDialog(mCost, gCost);
            glory -= Math.Abs(gCost);
        }
        public bool CostGlory(int gCost)
        {
            if (glory+gCost<0)
            {
                return false;
            }
            glory += gCost;
            return true;
        }
        #endregion
        #region constructor and initialisation methods
        public WorldState(Difficulty diff, string file)
        {
            LoadWorldFrom(file, diff);
            switch(diff)
            {
                case Difficulty.Easy:
                    glory = 50;
                    money = 5000000;
                    break;
                case Difficulty.Medium:
                    glory = 30;
                    money = 1000000;
                    break;
                case Difficulty.Hard:
                    glory = 25;
                    money = 500000;
                    break;
            }
        }

        public WorldState()
        {
        }

        public void LoadWorldFrom(string file, Difficulty diff)
        {
            try
            {
                XDocument doc = XDocument.Load(file);
                foreach (XElement el in doc.Root.Nodes())
                {
                    values.Add(new IndexedValue(el));
                }
                values.ForEach(val => val.ActivateForDiff(diff));
                values.ForEach(val=>val.LinkTo(values));
                groups.AddRange(values.FindAll(val => val.Type == IndexedValue.ValueType.Group));
                indicators.AddRange(values.FindAll(val => val.Type == IndexedValue.ValueType.Indicator));
                crises.AddRange(values.FindAll(val => val.Type == IndexedValue.ValueType.Crisis));
                perks.AddRange(values.FindAll(val => val.Type == IndexedValue.ValueType.Perk));
                policies.AddRange(values.FindAll(val => val.Type == IndexedValue.ValueType.Policy));
            }
            catch (IOException e)
            {
                Console.Write("Erreur fichier : " + file + " => " + e);
                Environment.Exit(-1);
            }
        }

        #endregion
        #region control flow methods
        public bool Finished()
        {
            return turnsLeft == 0;
        }
        #endregion
    }
}