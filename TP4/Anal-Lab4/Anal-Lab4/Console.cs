using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Anal_Lab4
{
    public static class Console
    { 
        private static TextBox m_Console;

        public static float FontSize
        {
            set { m_Console.Font = new Font("courier new", value); }
            get { return m_Console.Font.Size; }
        }

        public static void init(TextBox console)
        {
            m_Console = console;
        }

        public static void Write(string message)
        {
            if (m_Console == null)
                return;
            m_Console.AppendText(message + "\r\n");
        }

        public static void Clear()
        {
            if (m_Console == null)
                return;
            m_Console.Text = "";
        }
    }
}
