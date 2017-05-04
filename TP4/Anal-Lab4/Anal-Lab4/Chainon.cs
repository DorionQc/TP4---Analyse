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
    public class Chainon : IChainon
    {
        private IChainon m_Next;
        private string m_Nom;
        private int m_Priorite;
        private static Font __FONT = new Font("courier new", 12);
        public static float FontSize
        {
            set { __FONT = new Font("courier new", value); }
            get { return __FONT.Size; }
        }

        public Chainon(string Nom, int Priorite)
        {
            m_Nom = Nom;
            m_Priorite = Priorite;
        }

        public IChainon Next
        {
            get { return m_Next; }
            set { m_Next = value; }
        }

        public string Nom
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }

        public int Priority
        {
            get { return m_Priorite; }
            set { m_Priorite = value; }
        }

        public void Executer()
        {
            Console.Write(this.ToString());
            m_Next?.Executer();
        }

        public void Executer(int Priority, PriorityMode Mode, Regex r)
        {
            if (r.IsMatch(m_Nom))
            {
                switch (Mode)
                {
                    case PriorityMode.Lesser:
                        if (m_Priorite < Priority)
                            Console.Write(this.ToString());
                        break;
                    case PriorityMode.Equal:
                        if (m_Priorite == Priority)
                            Console.Write(this.ToString());
                        break;
                    case PriorityMode.Greater:
                        if (m_Priorite > Priority)
                            Console.Write(this.ToString());
                        break;
                }
            }
            m_Next?.Executer(Priority, Mode, r);
        }

        public string Executer(int Priority, PriorityMode Mode, Regex r, ref int Decompte)
        {
            if (r.IsMatch(m_Nom))
            {
                switch (Mode)
                {
                    case PriorityMode.Lesser:
                        if (m_Priorite < Priority)
                        {
                            Decompte--;
                            Console.Write(this.ToString());
                        }
                        break;
                    case PriorityMode.Equal:
                        if (m_Priorite == Priority)
                        {
                            Decompte--;
                            Console.Write(this.ToString());
                        }
                        break;
                    case PriorityMode.Greater:
                        if (m_Priorite > Priority)
                        {
                            Decompte--;
                            Console.Write(this.ToString());
                        }
                        break;
                }
            }
            if (Decompte == 0)
                return this.ToString();
            else
                return m_Next?.Executer(Priority, Mode, r, ref Decompte);
        }

        public override string ToString()
        {
            return m_Nom + " || Priorité : " + m_Priorite.ToString();
        }

        public Rectangle getRectangle(Graphics g, Point pt)
        {
            int x = pt.X, y = pt.Y;
            string[] strs =
            {
                "Nom : " + m_Nom,
                "Priorité : " + m_Priorite,
                "Next : " + (m_Next == null ? "null" : m_Next.Nom)
            };

            SizeF[] sizeStrings =
            {
                g.MeasureString(strs[0], __FONT),
                g.MeasureString(strs[1], __FONT),
                g.MeasureString(strs[2], __FONT)
            };

            return new Rectangle(x, y,
                (int)Math.Max(sizeStrings[0].Width, Math.Max(sizeStrings[1].Width, sizeStrings[2].Width)) + 10,
                (int)(sizeStrings[0].Height + sizeStrings[1].Height + sizeStrings[2].Height) + 6
                );
        }

        public void Draw(Graphics g, Point pt, Size diaSize, ref int maxHeight)
        {
            int x = pt.X, y = pt.Y;
            string[] strs =
            {
                "Nom : " + m_Nom,
                "Priorité : " + m_Priorite,
                "Next : " + (m_Next == null ? "null" : m_Next.Nom)
            };

            SizeF[] sizeStrings =
            {
                g.MeasureString(strs[0], __FONT),
                g.MeasureString(strs[1], __FONT),
                g.MeasureString(strs[2], __FONT)
            };

            Rectangle r = new Rectangle(x, y,
                (int)Math.Max(sizeStrings[0].Width, Math.Max(sizeStrings[1].Width, sizeStrings[2].Width)) + 10,
                (int)(sizeStrings[0].Height + sizeStrings[1].Height + sizeStrings[2].Height) + 6
                );

            if (r.Height > maxHeight)
            {
                maxHeight = r.Height;
            }

            if (x + r.Width > diaSize.Width)
            {
                x = 10;
                y += maxHeight + 10;
                maxHeight = 0;
            }
            pt.X = x;
            pt.Y = y;

            g.FillRectangle(new SolidBrush(Color.LightGray), x, y, r.Width, r.Height);
            x += 3; y += 3;
            Pen p = new Pen(Color.Black, 2);
            Brush b = new SolidBrush(Color.Black);
            g.DrawRectangle(p, x, y, r.Width - 6, r.Height - 6);
            g.DrawString(strs[0], __FONT, b, x, y);
            y += (int)sizeStrings[0].Height;
            g.DrawString(strs[1], __FONT, b, x, y);
            y += (int)sizeStrings[1].Height;
            g.DrawLine(p, x, y, x + r.Width - 6, y);
            g.DrawString(strs[2], __FONT, b, x, y);
            y += (int)sizeStrings[2].Height;

            if (m_Next != null)
            {
                y = pt.Y;
                x = pt.X + r.Width;
                p.Width = 3;
                int ty = y + r.Height / 2;
                g.DrawLine(p, x, ty, x + 23, ty);
                x += 21;
                g.DrawLine(p, x, ty, x - 5, ty + 5);
                g.DrawLine(p, x, ty, x - 5, ty - 5);
                x += 3;
                pt.X = x;
                pt.Y = y;
                m_Next.Draw(g, pt, diaSize, ref maxHeight);
            }
        }
    }
}
