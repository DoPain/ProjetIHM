using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace VivianeProject
{
    /// <summary>
    /// Controler constructed for routing player interaction to the view.
    /// The current view used here is the Console.
    /// </summary>
    public static class GameControler
    {
        #region attributes and private methods for console use
        private static WorldState theWorld;
        private static Dictionary<string, Action<string>> commands = new Dictionary<string, Action<string>>();
        private static string DefaultCommand { get; set; } = "aide";
        private static void MakeCommands()
        {
            commands.Add("aide", DisplayHelp);
            commands.Add("etat", DisplayStatus);
            commands.Add("historique", DisplayHistory);
            commands.Add("liste", DisplayList);
            commands.Add("politique", ApplyPolicyChanges);
            commands.Add("suivant", s => theWorld.NextTurn());
            commands.Add("quitter", s => Environment.Exit(0));
        }
        private static void Interpret(string input)
        {
            string command = input.Split(' ')[0];
            string arguments = input.Contains(" ") ? input.Substring(input.IndexOf(' ') + 1) : "";
            if (input == "")
            {
                commands[DefaultCommand]("");
                switch (DefaultCommand)
                {
                    case "aide": DefaultCommand = "etat"; break;
                    case "etat": DefaultCommand = "liste"; break;
                    case "suivant": DefaultCommand = "etat"; break;
                    default: DefaultCommand = "suivant"; break;
                }

            }
            else if (commands.ContainsKey(command))
            {
                commands[command](arguments);
            }
            else
            {
                Console.WriteLine("Commande inconnue : " + input);
                DisplayHelp("");
            }
        }
        private static void DisplayList(string arg)
        {
            if (arg != null && arg != "")
            {
                switch (arg.ToLower())
                {
                    case "groupes":
                        Console.WriteLine("-Groupes- : ");
                        theWorld.Groups.FindAll(g => g.Active != false).ForEach(g => Console.WriteLine(g));
                        break;
                    case "indicateurs":
                        Console.WriteLine("-Indicateurs- : ");
                        theWorld.Indicators.FindAll(i => i.Active != false).ForEach(i => Console.WriteLine(i));
                        break;
                    case "politiques":
                        Console.WriteLine("-Politiques actives (sauf taxes et quetes)- : ");
                        theWorld.Expenses.FindAll(p => p.Active != false).ForEach(p => Console.WriteLine(p));
                        Console.WriteLine("-Politiques disponibles (sauf taxes et quetes)- : ");
                        theWorld.Expenses.FindAll(p => p.Active == false && p.AvailableAt <= theWorld.Turns).ForEach(p => Console.WriteLine(p));
                        break;
                    case "taxes":
                        Console.WriteLine("-Taxes actives- : ");
                        theWorld.Taxes.FindAll(p => p.Active != false).ForEach(p => Console.WriteLine(p));
                        Console.WriteLine("-Taxes disponibles- :");
                        theWorld.Taxes.FindAll(p => p.Active == false && p.AvailableAt <= theWorld.Turns).ForEach(p => Console.WriteLine(p));
                        break;
                    case "quetes":
                        Console.WriteLine("-Quetes actives- : ");
                        theWorld.Quests.FindAll(p => p.Active != false).ForEach(p => Console.WriteLine(p));
                        Console.WriteLine("-Quetes disponibles- :");
                        theWorld.Quests.FindAll(p => p.Active == false && p.AvailableAt <= theWorld.Turns).ForEach(p => Console.WriteLine(p));
                        break;
                    case "benefices":
                        Console.WriteLine("-Benefices- : ");
                        theWorld.Perks.FindAll(p => p.Active == true).ForEach(p => Console.WriteLine(p));
                        break;
                    case "problemes":
                        Console.WriteLine("-Problemes- : ");
                        theWorld.Crises.FindAll(c => c.Active == true).ForEach(c => Console.WriteLine(c));
                        break;
                    default: break;
                }
            }
            else
            {
                DisplayList("groupes");
                DisplayList("indicateurs");
                DisplayList("politiques");
                DisplayList("taxes");
                DisplayList("quetes");
                DisplayList("benefices");
                DisplayList("problemes");
            }
        }
        private static void DisplayStatus(string arg)
        {
            if (arg != null && arg != "")
            {
                theWorld.Values.FindAll(val => val.Name.ToLower().Equals(arg.ToLower())).ForEach(val => Console.WriteLine(val.CompletePresentation()));
            }
            else
            {
                Console.Write("Etat actuel : Tour " + (theWorld.Turns + 1) + " ");
                if (theWorld.TurnsLeft >= 0)
                {
                    Console.Write("(" + theWorld.TurnsLeft + " restant) ");
                }
                Console.WriteLine("Finances : " + theWorld.Money + " pieces d'or, gloire : " + theWorld.Glory);
            }
        }
        private static void DisplayHelp(string s)
        {
            switch (s)
            {
                case "":
                    Console.Write("Actions possibles : ");
                    foreach (string k in commands.Keys)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine();
                    break;
                case "aide":
                    Console.WriteLine("Affiche l'aide. Sans argument : liste les commandes, avec : explique une commande.");
                    break;
                case "etat":
                    Console.WriteLine("Affiche une valeur. Sans argument : etat du monde, avec : examine une valeur.");
                    break;
                case "historique":
                    Console.WriteLine("Affiche l'historique d'une valeur. Argument : nom de la valeur.");
                    break;
                case "liste":
                    Console.WriteLine("Liste des: valeurs (toutes), groupes, indicateurs, politiques, taxes, quetes, benefices, problemes.");
                    break;
                case "politique":
                    Console.WriteLine("Met en place, modifie ou revoque une politique. Argument 1 : nom de la politique. Argument 2 : degre (0 pour revoquer).");
                    break;
                case "suivant":
                    Console.WriteLine("Passe au tour suivant.");
                    break;
                case "quitter":
                    Console.WriteLine("Met fin a la partie (sans sauvegarde)");
                    break;
                default:
                    Console.WriteLine("Mot-cle inconnu : " + s);
                    break;
            }

        }
        private static void DisplayHistory(string s)
        {
            if (s != null && s != "")
            {
                theWorld.ValuesLog.ForEach(vl => vl.FindAll(v => v.Split(':')[0].ToLower().Equals(s.ToLower())).ForEach(v => Console.Write(v + ", ")));
                theWorld.Values.FindAll(val => val.Name.ToLower().Equals(s.ToLower())).ForEach(val => Console.WriteLine(val.ToString()));
                if (s.ToLower().Equals("gloire"))
                {
                    Console.WriteLine("gloire:" + theWorld.Glory);
                }
                if (s.ToLower().Equals("finances"))
                {
                    Console.WriteLine("finances:" + theWorld.Money);
                }
            }
            else
            {
                Console.WriteLine("Quel historique ?");
            }
        }
        #endregion
        #region main console REP loop
        public static void MainLoop(WorldState world)
        {
            GameControler.theWorld = world;
            MakeCommands();
            while (!theWorld.Finished())
            {
                Console.Write(DefaultCommand + ">");
                string input = Console.In.ReadLine();
                Interpret(input);

            }
            Console.Write("Fin du jeu : entree");
            Console.In.ReadLine();
        }
        #endregion
        #region public anchor methods
        public static void Activate(IndexedValue indexedValue)
        {
            Console.WriteLine("Nouvel effet actif : " + indexedValue.ToString());
        }
        public static void Deactivate(IndexedValue indexedValue)
        {
            Console.WriteLine("Fin de l'action de : " + indexedValue.ToString());
        }
        public static bool ConfirmDialog()
        {
            Console.WriteLine("Confirmer (oui/non) ?");
            return Console.In.ReadLine().ToLower().Equals("oui");
        }
        public static void LoseDialog(IndexedValue indexedValue) {
            if (indexedValue == null) {
                MessageBox.Show("Partie perdue : dette insurmontable.", "Perdu");
            } else {
                MessageBox.Show("Partie perdue :" +
                indexedValue.CompletePresentation());
            }
        }
        public static void WinDialog()
        {
            MessageBox.Show("Partie gagnée.");
        }
        public static void ApplyPolicyChanges(string arg)
        {
            if (!arg.Contains(" "))
            {
                Console.WriteLine("erreur texte application politique : " + arg);
                return;
            }
            string pol = arg.Split(' ')[0];
            int amount = -1;
            int.TryParse(arg.Split(' ')[1], out amount);
            if (amount < 0)
            {
                Console.WriteLine("erreur nombre application politique : " + arg);
                return;
            }
            int mCost = 0, gCost = 0;
            IndexedValue val = null;
            val = theWorld.FindPolicyOrDefault(pol);
            if (val==null)
            {
                Console.WriteLine("erreur nom application politique : " + arg);
                return;
            }
            if (amount == 0)
            {
                theWorld.DeactivatePolicy(val, out mCost, out gCost);
                return;
            }
            val.PreviewPolicyChange(ref amount, out mCost, out gCost);
            Console.WriteLine("Estimation : " + mCost + " pieces (par tour) et " + gCost + " gloire.");
            if (!ConfirmDialog())
            {
                mCost = 0;
                gCost = 0;
                return;
            }
            if (gCost < 0)
            {
                if (theWorld.CostGlory(gCost))
                {
                    Console.WriteLine("Changement effectue pour " + gCost + " gloire.");
                    val.ChangeTo(amount, out mCost, out gCost);
                    return;
                }
                else
                {
                    Console.WriteLine("Gloire insuffisante : " + theWorld.Glory);
                    return;
                }
            }
            Console.WriteLine("Changement effectue.");
            val.ChangeTo(amount, out mCost, out gCost);
        }
        public static void DeactivatePolicyDialog(int mCost, int gCost)
        {
            Console.WriteLine("Desactivation effectuee pour " + gCost + " gloire.");
        }
        #endregion
    }
}