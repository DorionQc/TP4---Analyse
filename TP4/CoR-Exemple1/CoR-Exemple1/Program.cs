using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR_Exemple1
{
    class Program
    {
        static void Main(string[] aliment)
        {
            if (aliment.Length == 0) return;
            // Construction d'une chaîne de responsabilité d'ingrédients 
            Ingredient premier, dernier, curr = null;
            // Début de la chaîne. On garde le premier élément en mémoire
            dernier = premier = new Ingredient(aliment[0]);
            int i = 1;

            // Construction de la chaîne à partir de chacun des arguments reçus
            while (i < aliment.Length) {
                curr = new Ingredient(aliment[i]);  
                dernier.SetNext(curr);// Spécification du prochain chaînon
                dernier = curr;       // Garder en mémoire le dernier élément
                i++;
            }
            // À ce stade, notre chaîne ressemble à {Ing1 -> Ing2 -> ... -> null}
            int max = 2;
            string s = premier.Executer('p', ref max);       // Appel de la fonction
            Console.WriteLine(s);
            Console.Read();
        }
    }

    public class Ingredient
    {
        private string m_Nom;
        private Ingredient m_Next;    // Prochain élément dans le chaîne
        public Ingredient(string Nom) {
            m_Nom = Nom;
            m_Next = null;            // Le prochain est null tant qu'il n'est pas spécifié
        }
        public void SetNext(Ingredient i) {
            m_Next = i;               // Modification du prochain élément
        }

        public string Executer(char c, ref int max) {
            if (m_Nom != null && m_Nom.Length >= 1 && Char.ToLower(m_Nom[0]) == c)
                max--;
            if (m_Next != null && max > 0)       // Appel de la méthode homonyme du prochain élément (s'il y a un prochain élément)
                return m_Next.Executer(c, ref max);
            else
            {
                if (max == 0)
                    return m_Nom;
                else
                    return "";
            }
        }
    }
}
