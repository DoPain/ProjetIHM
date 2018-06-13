using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenouKaiss_Morax_IHM
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Menu m = new Menu();
            Application.Run(m);

            if (m.DialogResult == DialogResult.OK) {
                if (m.ToursLimités) Application.Run(new MainWindow(m.Difficulté, m.ToursMaximum));
                else Application.Run(new MainWindow(m.Difficulté));
            }
        }
    }
}
