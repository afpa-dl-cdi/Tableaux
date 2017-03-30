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

            #region tableau à une dimension
            int[] entiers = new int[10];
            string[] journalistes = new string[4] { "maurice", "robert", null, null };
            decimal[] prix = { 12.45m, 45.59m, 14.56m };
            var unTableau = new [] { 1, 3, 4 };
            #endregion

            #region tableau à plusieurs dimensions

            int[,] matrice = new int[10, 9];
            //matrice[3, 3] = 5;
            //int valeur = matrice[5, 5];

            remplirTableauA2Dimension(matrice);
            affichageTableau2Dimension(matrice);

            int[,,] cube = new int[3, 3, 3];
            #endregion

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
            Console.WriteLine("Tableau à une dimension");
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

        /// <summary>
        /// Remplit un tableau à 2 dimensions 
        /// </summary>
        /// <param name="deuxD"></param>
        static void remplirTableauA2Dimension( int [,] deuxD)
        {
            for (int i = 0; i < deuxD.GetLength(0); i++)
            {
                for (int j = 0; j < deuxD.GetLength(1); j++)
                {
                    deuxD[i, j] = j+i;
                }
            }
        }


        /// <summary>
        /// Affiche un tableau à deux dimensions 
        /// </summary>
        /// <param name="deuxD"></param>
        static void affichageTableau2Dimension( int [,] deuxD)
        {
            Console.WriteLine("Tableau à 2 dimensions");
            for (int i = 0; i < deuxD.GetLength(1); i++)
            {
                for (int j = 0; j < deuxD.GetLength(0); j++)
                {
                    Console.Write("{0} ", deuxD[j, i]);
                }

                Console.WriteLine();
            }
        }

    }
}
