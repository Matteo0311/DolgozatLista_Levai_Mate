using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();

            listaFeltolt(10);

            listaAtlag(szamok);
            Console.ReadKey();
        }

            static List<int> listaFeltolt(int v)
            {
                Random rnd = new Random();
                double vszam = 0;
                for (int i = 0; i < v; i++)
                {
                    vszam = rnd.Next(10, 101);
                    
                }
            Console.Write(vszam + " ");
            return listaFeltolt;
            }

        static void listaAtlag(List<double> szamok)
        {
            double szamAtlag = szamok.Average();
            Console.Write($"Átlag: {szamAtlag}"); ;


        }
    }
}
