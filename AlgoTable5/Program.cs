using System;

namespace AlgoTable5
{
    class Program
    {
        static void algoTable5 (out string resultat)
        {
            resultat = "0";
            int valeur;
            
            for (int n = 1; n <= 100; n++)
            {
                valeur = n * 5;
                resultat = resultat + "," + valeur;
            }
            
        }
        static void Main(string[] args)
        {
            string resultat;
            algoTable5(out resultat);
            Console.WriteLine("La table de 5 jusqu'a 500 est :");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(resultat);

            Console.ReadLine();


        }
    }
}
