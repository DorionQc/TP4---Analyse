using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anal_Lab4
{
    public partial class frmCoR : Form
    {

        private ChainManager manager;
        private TimeSpan ts = new TimeSpan();

        #region Fruits
        private static List<string> __FRUITS = new List<string>()
        {
            "Abricot",
            "Airelle",
            "Alkékenge",
            "Amande",
            "Amélanche",
            "Ananas",
            "Arbouse",
            "Asimine",
            "Avocat",
            "Banane",
            "Bergamote",
            "Brugnon",
            "Canneberge",
            "Cassis",
            "Cerise",
            "Châtaigne",
            "Citron",
            "Clémentine",
            "Coing",
            "Cornouiller du Canada",
            "Cynorrhodon",
            "Datte",
            "Épine-vinette",
            "Feijoa",
            "Figue",
            "Figue de barbarie",
            "Fraise",
            "Framboise",
            "Grenade",
            "Griotte",
            "Groseille",
            "Jujube",
            "Kaki",
            "Kiwi",
            "Lime",
            "Mandarine",
            "Marron",
            "Melon",
            "Mirabelle",
            "Mûre",
            "Myrte",
            "Myrtille",
            "Nèfle",
            "Noisette",
            "Noix",
            "Olive",
            "Orange",
            "Pamplemousse",
            "Pastèque",
            "Pêche",
            "Pistache",
            "Poire",
            "Pomme",
            "Pomélos",
            "Prune",
            "Quetsche",
            "Raisin"
        };
        #endregion

        public frmCoR()
        {
            InitializeComponent();
            Console.init(txtConsole);
            manager = new ChainManager();
            this.propGrid.SelectedObject = manager;
            cbPriorityMode.SelectedIndex = 0;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtAddNom.Text;
            if (nom == "")
            {
                Console.Write("Impossible d'ajouter un élément sans nom");
                return;
            }
            if (numAddPos.Value == -1)
            {
                manager.Ajouter(new Chainon(txtAddNom.Text, (int)numAddPriority.Value));
            }
            else
            {
                manager.Ajouter(new Chainon(txtAddNom.Text, (int)numAddPriority.Value), (int)numAddPos.Value);
            }

            this.propGrid.Update();
            this.mainPanel.Invalidate();
            
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            manager.Executer();
        }

        private void btnShowWithConditions_Click(object sender, EventArgs e)
        {
            Regex r = null;
            try
            {
                r = new Regex("^" + txtNom.Text);
            }
            catch (Exception)
            {
                r = new Regex("^");
                Console.Write("Regex incompréhensible");
            }

            if (numQuantity.Value == -1)
            {
                manager.Executer((int)numPriority.Value, cbPriorityMode.SelectedIndex, r);
            }
            else
            {
                manager.Executer((int)numPriority.Value, cbPriorityMode.SelectedIndex, r, (int)numQuantity.Value);
            }
        }

        private void btnReturnValue_Click(object sender, EventArgs e)
        {
            Regex r = null;
            try
            {
                r = new Regex("^" + txtNom.Text);
            }
            catch (Exception)
            {
                r = new Regex("^");
                Console.Write("Regex incompréhensible");
            }

            if (numQuantity.Value > 0)
            {
                string s = manager.Executer((int)numPriority.Value, cbPriorityMode.SelectedIndex, r, (int)numQuantity.Value);
                Console.Write("Valeur de retour = " + s);
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            manager = new ChainManager();
            this.propGrid.SelectedObject = manager;
            this.propGrid.Update();
            this.mainPanel.Invalidate();
        }

        private void numFontSize_ValueChanged(object sender, EventArgs e)
        {
            Chainon.FontSize = (float)numFontSize.Value;
            Console.FontSize = (float)numFontSize.Value;
            this.mainPanel.Invalidate();
        }



        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            manager.Draw(e.Graphics, this.mainPanel.ClientSize);
        }

        private void frmCoR_Paint(object sender, PaintEventArgs e)
        {
            this.mainPanel.Invalidate();
        }

        private void frmCoR_Resize(object sender, EventArgs e)
        {
            this.mainPanel.Invalidate();
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            this.mainPanel.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ts = ts.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = ts.ToString("mm\\:ss");
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(0);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            manager.Ajouter(new Chainon(__FRUITS[r.Next() % __FRUITS.Count], r.Next() % 100));
            this.mainPanel.Invalidate();
        }

        private void btnPresentation_Click(object sender, EventArgs e)
        {
            DialogPresentation f = new DialogPresentation();
            f.ShowDialog();
        }
    }

    public class dbPanel : Panel
    {
        public dbPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
