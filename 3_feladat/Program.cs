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
            Random rnd = new Random();
            listaFeltolt(10);

            listaAtlag(szamok);
            Console.ReadKey();
        }

            static List<int> listaFeltolt(int v)
        {
            for (int i = 0; i < 10; i++)
            {
                int vszam = rnd.Next(10, 101);
                szamok.Add(vszam);
                Console.Write(vszam + " ");
            }
            return v;
        }

        static void listaAtlag(List<double> szamok)
        {
            double szamAtlag = szamok.Average();
            Console.Write($"Átlag: {szamAtlag}"); ;


        }
    }
}
