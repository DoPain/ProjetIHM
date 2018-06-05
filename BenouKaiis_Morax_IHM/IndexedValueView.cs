using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivianeProject;

namespace BenouKaiis_Morax_IHM {
    public class IndexedValueView {

        private Point coordonnées;
        private Size taille;
        private Color couleur;
        private IndexedValue indexedValue;

        public IndexedValueView(IndexedValue iv, int x, int y, int w, int h, Color couleur) {
            indexedValue = iv;
        }

        public void dessine(Graphics g) {

        }

    }
}
