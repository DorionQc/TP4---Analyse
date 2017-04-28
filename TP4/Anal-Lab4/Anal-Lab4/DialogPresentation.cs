using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Anal_Lab4
{
    public partial class DialogPresentation : Form
    {
        private Image[] _imgs;
        private int _curr;
        public DialogPresentation()
        {
            InitializeComponent();
            _imgs = new Image[]
            {
                Properties.Resources.IMG_0__COBOL_pour_commencer_la_journée_,
                Properties.Resources.IMG_0__Title_,
                Properties.Resources.IMG_1__Mess_1_,
                Properties.Resources.IMG_2__Mess_2_,
                Properties.Resources.IMG_3__Big_mess_,
                Properties.Resources.IMG_4__Mess_meme_,
                Properties.Resources.IMG_5__Mess_chaine_,
                Properties.Resources.IMG_6__Chaine_exposed_,
                Properties.Resources.IMG_7__Interieur_d_un_objet_,
                Properties.Resources.IMG_8__Diag_classe_,
                Properties.Resources.IMG_9__Petite_parenthèse_,
                Properties.Resources.IMG_10__Implementation_p1_,
                Properties.Resources.IMG_11__Implementation_p2_,
                Properties.Resources.IMG_12__Implementation_avec_retour_,
                Properties.Resources.IMG_13__Implementation_chaîne_multiple_,
                Properties.Resources.IMG_14__Représentation_Chaine_normale_,
                Properties.Resources.IMG_15__Représentation_Chaine_arbre_,
                Properties.Resources.IMG_16__But_why_tho_,
                Properties.Resources.IMG_17__For_all_this_,
                Properties.Resources.IMG_18__Selon_le_GoF_,
                Properties.Resources.IMG_19__Selon_le_GoF_translated_,
                Properties.Resources.IMG_20__Avantages_selon_GoF_,
                Properties.Resources.IMG_21__Avantages_selon_moi_,
                Properties.Resources.IMG_22__Inconvénients_
            };
            _curr = 0;
            mainPanel.BackgroundImage = _imgs[_curr];
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_curr < _imgs.Length - 1)
                {
                    _curr++;
                    mainPanel.BackgroundImage = _imgs[_curr];
                }
                else
                {
                    this.Close();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (_curr > 0)
                {
                    _curr--;
                    mainPanel.BackgroundImage = _imgs[_curr];
                }
            }

        }
    }
}
