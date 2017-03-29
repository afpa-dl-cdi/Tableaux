using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {

            //déclaration d'un tableau vide de taille de 10 éléments
            int[] entiers = new int[10];
            string[] journalistes = new string[4] { "maurice", "robert", null, null };
            decimal[] prix = { 12.45m, 45.59m, 14.56m };
            var unTableau = new [] { 1, 3, 4 };

            #region Copie de tableau à tableau
            int[] cloneEntiers = entiers;            //copie par référence
            cloneEntiers[2] = 5;                     // les 2 tableaux auront l'indice 2 modifiés

            // Pour effectuer une vraie copie de tableau à tableau
            // solution 1 
            int[] copieEntiers = new int[entiers.Length];
            for (int i = 0; i < entiers.Length; i++)
            {
                copieEntiers[i] = entiers[i];
            }

            // solution 2 : 
            int[] copie2 = new int[entiers.Length];
            entiers.CopyTo(copie2, 0);

            
            // solution 3 : 
            int[] copie3 = new int[entiers.Length];
            Array.Copy(entiers, copie3, entiers.Length);

            // soltuion 4 : 
            int[] copie4 = (int[])entiers.Clone();
           


            #endregion

            remplirTableau(entiers);


            #region Parcours d'un tableau
            for (int i = 0; i < entiers.Length ; i++)
            {
                Console.WriteLine(entiers[i]);

            }

            foreach (var item in entiers)
            {
                Console.WriteLine(item);
            }

            #endregion

        }

        /// <summary>
        /// Remplissage du tableau
        /// </summary>
        /// <param name="monTableau"></param>
        static void remplirTableau(int [] monTableau)
        {
            for (int i = 0; i < monTableau.Length; i++)
            {
                monTableau[i] = i;
            }
        }

    }
}
