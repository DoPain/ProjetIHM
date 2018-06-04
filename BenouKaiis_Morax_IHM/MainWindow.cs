using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VivianeProject;

namespace BenouKaiis_Morax_IHM
{
    public partial class MainWindow : Form
    {

        private WorldState w = new WorldState();

        public MainWindow()
        {
            InitializeComponent();
            GameControler.MainLoop(w);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
