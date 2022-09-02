using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaAnFortniteYippie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skrive Alder");
            int Alder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skrive FullPris");
            int FullPris = Convert.ToInt32(Console.ReadLine());
            double PrisEtterRabatt;


            if (Alder < 3)
            {
                PrisEtterRabatt = FullPris * 0.1;
                Console.WriteLine("90% Rabatt");
                Console.WriteLine("Rabatt Pris blir:" + PrisEtterRabatt);
            } 
            else if (Alder > 2 && Alder < 13)
            {
                PrisEtterRabatt = FullPris * 0.5;
                Console.WriteLine("50% Rabatt");
                Console.WriteLine("Rabatt Pris blir:" + PrisEtterRabatt);
            }
            else if (Alder > 12 && Alder < 19)
            {
                PrisEtterRabatt = FullPris * 0.3;
                Console.WriteLine("30% Rabatt");
                Console.WriteLine("Rabatt Pris blir:" + PrisEtterRabatt);
            }
            else if (Alder > 18 && Alder < 67)
            {
                PrisEtterRabatt = FullPris * 1;
                Console.WriteLine("0% Rabatt");
                Console.WriteLine("Rabatt Pris blir:" + PrisEtterRabatt);
            }
            else
            {
                PrisEtterRabatt = FullPris * 0.4;
                Console.WriteLine("40% Rabatt");
                Console.WriteLine("Rabatt Pris blir:" + PrisEtterRabatt);
            }
 
        }
    }
}
