/**
 * Exercice 24
 * author : Mallory P
 * date : 21/02/2024
 */

using System;

namespace Exercice_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double nbGrand, nbPetit;

            Console.Write("Saisissez les température : ");           
            nbGrand=nbPetit= double.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.Write("Saisissez la température : ");
                double compte = double.Parse(Console.ReadLine());
                if (compte > nbGrand)
                {
                    nbGrand = compte;
                }
                if (compte < nbPetit)
                {
                    nbPetit = compte;
                }
                else
                {
                    nbGrand = compte;
                    nbPetit = compte;
                }
            }
            Console.Write("la température la plus petite est : " + nbPetit + " et la température la plus grande : " + nbGrand);
            Console.ReadLine();
        }
    }
}
