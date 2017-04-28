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
    public enum PriorityMode
    {
        Lesser,
        Equal,
        Greater
    };

    [Description("Un élément de la chaîne de responsabilité"), TypeConverter(typeof(ChainonConverter))]
    public interface IChainon
    {
        [DefaultValue(null)]
        IChainon Next { get; set; }
        
        [DefaultValue("")]
        string Nom { get; set; }

        [DefaultValue(0)]
        int Priority { get; set; }

        void Executer();
        void Executer(int Priority, PriorityMode Mode, Regex r);
        string Executer(int Priority, PriorityMode Mode, Regex r, ref int Decompte);
        Rectangle getRectangle(Graphics g, Point p);
        void Draw(Graphics g, Point p, Size diaSize, ref int maxHeight);


        string ToString();
    }
}
