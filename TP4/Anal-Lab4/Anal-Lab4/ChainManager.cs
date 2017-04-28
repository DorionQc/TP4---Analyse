using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace Anal_Lab4
{
    public class ChainManager
    {

        private List<IChainon> m_lChainon;
        private IChainon m_Dernier;
        private IChainon m_Premier;

        [Description("Le premier élément de la chaîne"), DefaultValue(null)]
        public IChainon Premier
        {
            get { return m_Premier; }
            set { m_Premier = value; }
        }

        [Description("Le dernier élément de la chaîne"), DefaultValue(null)]
        public IChainon Dernier
        {
            get { return m_Dernier; }
            set { m_Dernier = value; }
        }

        [Description("Liste contenant tous les chaînons de la chaîne"), DefaultValue(null)]
        public List<IChainon> Elements
        {
            get { return m_lChainon; }
            set { m_lChainon = value; }
        }

        public ChainManager()
        {
            m_lChainon = new List<IChainon>();
        }

        public void Ajouter(IChainon c)
        {
            if (m_Premier == null)
            {
                m_Premier = c;
                Console.Write("Ajout du chainon " + c.Nom + " en tant que premier élément.");
            }
            if (m_Dernier != null)
            {
                Console.Write("Ajout du chainon " + c.Nom + " en tant que dernier élément.");
                m_Dernier.Next = c;
            }
            m_Dernier = c;
            m_lChainon.Add(c);
        }

        public bool Ajouter(IChainon c, int Position)
        {
            if (m_lChainon.Count == 0 && Position != 0)
            {
                Console.Write("Impossible d'ajouter un élement à une position supérieure à 0 lorsque la chaîne est vide");
                return false;
            }
            if (m_lChainon.Count < Position)
            {
                Console.Write("La position fournie est hors des limites de la chaîne.");
                return false;
            }
            if (m_Premier == null)
            {
                Console.Write("Ajout du chainon " + c.Nom + " en tant que premier élément.");
                m_Premier = c;
                m_lChainon.Add(c);
                return true;
            }
            IChainon before = this[Position - 1];
            if (before == null)
            {
                Console.Write("Impossible d'assigner la propriété Next à un chaînon inexistant");
                return false;
            }
            IChainon after = before.Next;
            before.Next = c;
            c.Next = after;
            m_lChainon.Add(c);
            if (m_Dernier == before)
            {
                Console.Write("Ajout du chainon " + c.Nom + " en tant que dernier élément, à la position " + Position.ToString());
                m_Dernier = c;
            }
            else
            {
                Console.Write("Ajout du chainon " + c.Nom + " à la position " + Position.ToString());
            }
            
            Console.Write("Chainon précédent : " + before.ToString());
            if (after != null)
                Console.Write("Chainon suivant : " + after.ToString());
            return true;
        }

        public IChainon this[int index]
        {
            get
            {
                if (m_lChainon.Count < index - 1 || m_Premier == null)
                {
                    Console.Write("Index out of range exception : La valeur " + index.ToString() + " dépasse la quantité d'élements dans la chaîne [" + m_lChainon.Count.ToString() + "]");
                    return null;
                }

                int i = index;
                IChainon curr = m_Premier;
                while (i > 0)
                {
                    curr = curr.Next;
                    i--;
                }
                return curr;
            }
        }

        public void Executer()
        {
            if (m_Premier != null)
                m_Premier.Executer();
            return;
        }

        public void Executer(int Priority, int ModeIndex, Regex r)
        {
            PriorityMode Mode = (PriorityMode)ModeIndex;
            if (m_Premier != null)
                m_Premier.Executer(Priority, Mode, r);
            return;
        }

        public string Executer(int Priority, int ModeIndex, Regex r, int Position)
        {
            PriorityMode Mode = (PriorityMode)ModeIndex;
            int pos = Position;
            if (m_Premier != null)
                return m_Premier.Executer(Priority, Mode, r, ref pos);
            return "";
        }

        public void Draw(Graphics g, Size s)
        {
            int MaxHeight = 0;
            m_Premier?.Draw(g, new Point(10, 10), s, ref MaxHeight);

            /*
            int x = 10, y = 10;
            IChainon c = m_Premier;
            Rectangle r;
            int MaxHeight = 0;

            while (c != null)
            {
                Point pt = new Point(x, y);
                r = c.getRectangle(g, pt);
                if (r.Height > MaxHeight)
                    MaxHeight = r.Height;
                if (x + r.Width > s.Width)
                {
                    x = pt.X = 10;
                    y += MaxHeight + 10;
                    pt.Y = y;
                }
                c.Draw(g, pt);
                c = c.Next;
                if (c != null)
                {
                    Pen p = new Pen(Color.Black, 3);
                    int ty = y + r.Height / 2;
                    x += r.Width;
                    g.DrawLine(p, x, ty, x + 23, ty);
                    x += 21;
                    g.DrawLine(p, x, ty, x - 5, ty + 5);
                    g.DrawLine(p, x, ty, x - 5, ty - 5);
                    x += 3;
                }
            }

            */

        }


    }
}
