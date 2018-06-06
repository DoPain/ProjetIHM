using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace VivianeProject
{
    /// <summary>
    /// This class represents an indexed (i. e., normalised between a min and max value) value
    /// for indicators (a population statistic), groups (specific population groups, the value
    /// indicating their happiness on a 0-100 scale), policies (spending, taxes, and quests,
    /// valued between 0-100, the only values set directly by the player), perks (positive situations
    /// giving benefits when active, scale is 0-1000), and crises (negative situations giving 
    /// problems when active, scale is 0-1000). Indexed values are constructed from XML.
    /// </summary>
    public class IndexedValue
    {
        public enum ValueType { Indicator=0, Group=1, Policy=2, Perk=3, Crisis=4 };
        public enum ResultType { None=0, Win=1, Lose=2};
        #region attributes and encapsulated properties
        public ResultType Result { get; private set; } = ResultType.None; 
        public ValueType Type { get; private set; } = ValueType.Indicator;
        public bool? Active { get; private set; } = null;
        private int? activationThreshold = null;
        private int? deactivationThreshold = null;
        public int? AvailableAt { get; private set; } = null;
        private int minValue=0;
        private int maxValue=0;
        private double actualValue;
        private double currentInfluence = 0;
        public int? MoneyAmount { get; private set; } = null;
        public int? GloryAmount { get; private set; } = null;
        private Func<double, double> cost = FunLibrary.Linear;
        private Func<double, double> effect = FunLibrary.Linear;
        public Func<double, double> Cost { get { return cost; } }
        public Func<double, double> Effect { get { return effect; } }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Dictionary<IndexedValue, double> OutputWeights { get; private set; } = new Dictionary<IndexedValue, double>();
        private Dictionary<string, double> tmpOutputs = new Dictionary<string, double>();
        private string tmpDifficulty = null;
        #endregion
        #region computed properties / read-only
        public int Value { get { return (int)Math.Max(minValue, Math.Min(maxValue, actualValue)); } }
        public double Impact { get { return Math.Max(-1.0, Math.Min(1.0, effect((((actualValue - minValue) * 2.0) / (maxValue - minValue)) - 1.0))); } }

        public int MoneyImpacted { get { return (int)Math.Abs(MoneyAmount.GetValueOrDefault(0) * Impact); } }
        public int GloryImpacted { get { return (int)Math.Abs(GloryAmount.GetValueOrDefault(0) * Impact); } }
        public int MinValue { get { return minValue; } }
        public int MaxValue { get { return maxValue; } }
        #endregion
        #region co-modification methods
        public void Update()
        {
            if (currentInfluence != 0)
            {
                actualValue += currentInfluence;
                actualValue = Math.Max(minValue, Math.Min(maxValue, actualValue));
                CheckActivation();
                currentInfluence = 0;
            }
        }
        public void Influence(double modifier)
        {
            double realMod = Math.Max(Math.Min(modifier, 1.0), -1.0);
            currentInfluence += realMod * (maxValue - minValue);
        }
        public void CheckActivation()
        {
            if (!Active.GetValueOrDefault(false) && activationThreshold.HasValue && actualValue >= activationThreshold.Value)
            {
                Active = true;
                GameControler.Activate(this);
            }
            else if (Active.GetValueOrDefault(false) && deactivationThreshold.HasValue && actualValue <= deactivationThreshold.Value)
            {
                Active = false;
                GameControler.Deactivate(this);
            }
        }
        public void Propagate()
        {
            foreach (IndexedValue iv in OutputWeights.Keys)
            {
                iv.Influence(Impact * OutputWeights[iv]);
            }
        }
        #endregion
        #region XML-based constructor
        public IndexedValue(XElement element)
        {
            if (element.Name.ToString() != "iValue") return;
            foreach (XElement e in element.Elements())
            {
                switch (e.Name.ToString())
                {
                    case "name":
                        this.Name = e.Value;
                        break;
                    case "desc":
                        this.Description = e.Value;
                        break;
                    case "type":
                        int a = -1;
                        Int32.TryParse(e.Value.ToString(), out a);
                        this.Type = (ValueType)(a >= 0 && a <= 4 ? a : 0);
                        break;
                    case "result":
                        int z = -1;
                        Int32.TryParse(e.Value.ToString(), out z);
                        this.Result = (ResultType)(z >= 0 && z <= 2 ? z : 0);
                        break;
                    case "cost":
                        if (FunLibrary.Functions.ContainsKey(e.Value.ToString()))
                        {
                            this.cost = FunLibrary.Functions[e.Value.ToString()];
                        }
                        break;
                    case "effect":
                        if (FunLibrary.Functions.ContainsKey(e.Value.ToString()))
                        {
                            this.effect = FunLibrary.Functions[e.Value.ToString()];
                        }
                        break;
                    case "active":
                        bool act;
                        try
                        {
                            act = Boolean.Parse(e.Value.ToString());
                        }
                        catch (Exception ex)
                        {
                            this.Active = null;
                            break;
                        }
                        this.Active = act;
                        break;
                    case "actThres":
                        int b = -1;
                        Int32.TryParse(e.Value.ToString(), out b);
                        this.activationThreshold = b;
                        if (this.activationThreshold == -1)
                        {
                            this.activationThreshold = null;
                        }
                        break;
                    case "deactThres":
                        int c = -1;
                        Int32.TryParse(e.Value.ToString(), out c);
                        this.deactivationThreshold = c;
                        if (this.deactivationThreshold == -1)
                        {
                            this.deactivationThreshold = null;
                        }
                        break;
                    case "availableAt":
                        int d = -1;
                        Int32.TryParse(e.Value.ToString(), out d);
                        this.AvailableAt = d;
                        if (this.AvailableAt == -1)
                        {
                            this.AvailableAt = null;
                        }
                        break;
                    case "min":
                        int f = 0;
                        Int32.TryParse(e.Value.ToString(), out f);
                        this.minValue = f;
                        break;
                    case "max":
                        int g = 0;
                        Int32.TryParse(e.Value.ToString(), out g);
                        this.maxValue = g;
                        break;
                    case "value":
                        double h = 0;
                        Double.TryParse(e.Value.ToString(), out h);
                        this.actualValue = h;
                        break;
                    case "money":
                        int i = -1;
                        Int32.TryParse(e.Value.ToString(), out i);
                        this.MoneyAmount = i;
                        if (this.MoneyAmount == -1)
                        {
                            this.MoneyAmount = null;
                        }
                        break;
                    case "glory":
                        int j = -1;
                        Int32.TryParse(e.Value.ToString(), out j);
                        this.GloryAmount = j;
                        if (this.GloryAmount == -1)
                        {
                            this.GloryAmount = null;
                        }
                        break;
                    case "difficulty":
                        this.tmpDifficulty = e.Value;
                        break;
                    case "outputs":
                        foreach (XElement w in e.Nodes())
                        {
                            if (w.Name.ToString() == "value" && w.HasAttributes)
                            {
                                this.tmpOutputs.Add(w.Attribute("val").Value, double.Parse(w.Attribute("weight").Value.ToString()));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region external modification methods
        public void ChangeTo(int amount, out int mCost, out int gCost)
        {
            PreviewPolicyChange(ref amount, out mCost, out gCost);
            actualValue = amount;
            if (actualValue>=minValue)
            {
                Active = true;
            }
            actualValue = Math.Min(maxValue, Math.Max(minValue, actualValue));
        }

        public void PreviewPolicyChange(ref int amount, out int mCost, out int gCost)
        {
            amount = Math.Min(Math.Max(amount, minValue), maxValue);
            double delta = Math.Abs(actualValue - amount);
            delta /= maxValue - minValue;
            delta = cost(delta);
            mCost = (int)(MoneyAmount.GetValueOrDefault(0) * delta);
            gCost = (int)(GloryAmount.GetValueOrDefault(0) * delta);
        }

        internal void Deactivate(out int mCost, out int gCost)
        {
            mCost = MoneyAmount.GetValueOrDefault(0);
            gCost = GloryAmount.GetValueOrDefault(0);
            actualValue = minValue;
            Active = false;
        }
        #endregion
        #region additional initialisation methods
        internal void LinkTo(List<IndexedValue> values)
        {
            foreach (string s in tmpOutputs.Keys)
            {
                IndexedValue output = values.Exists(v=>v.Name.Equals(s))?values.Find(v => v.Name.Equals(s)):null;
                if (output != null)
                {
                    OutputWeights.Add(output, tmpOutputs[s]);
                }
            }
        }
        internal void ActivateForDiff(WorldState.Difficulty diff)
        {
            if (Active==false && tmpDifficulty!=null)
            {
                switch (tmpDifficulty.ToLower())
                {
                    case "easy":
                        Active = diff == WorldState.Difficulty.Easy;
                        break;
                    case "medium":
                        Active = diff < WorldState.Difficulty.Hard;
                        break;
                    case "hard":
                        Active = true;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region text-display methods
        public override string ToString()
        {
            return (Name + ":" + Value);
        }
        public string CompletePresentation()
        {
            string pres = "==" + Name + "==";
            pres += Environment.NewLine;
            pres += Description + Environment.NewLine;
            pres += "Valeur : <" + minValue + " :" + Value + ": " + maxValue + ">" + Environment.NewLine;
            if (MoneyAmount.HasValue && MoneyAmount.GetValueOrDefault(0)<0)
            {
                pres += "Coute " + MoneyImpacted + " pieces d'or par tour" + Environment.NewLine;
            }
            if (MoneyAmount.HasValue && MoneyAmount.GetValueOrDefault(0) > 0)
            {
                pres += "Rapporte " + MoneyImpacted + " pieces d'or par tour" + Environment.NewLine;
            }
            if (GloryAmount.HasValue && GloryAmount.GetValueOrDefault(0) < 0)
            {
                pres += "Coute " + Math.Abs(GloryAmount.Value) + " gloire" + Environment.NewLine;
            }
            if (GloryAmount.HasValue && GloryAmount.GetValueOrDefault(0) > 0)
            {
                pres += "Rapporte " + GloryImpacted + " gloire par tour" + Environment.NewLine;
            }
            pres += "Actuellement " + ((Active != false) ? "en action" : "hors action");
            return pres;
        }
        #endregion
    }
}