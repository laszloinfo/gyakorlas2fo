using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3.feladat
            /* Console.Write("Kérek egy pozitív egész számot: ");
             int szam = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"{szam}kettes osztóinak száma: {kettoOszto(szam)} ");*/





            //4.feladat

            /*Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] ermek = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] tomb = OsztokSzama(szam);
            
                Console.WriteLine($"A(z) {szam} tartalmaz: ");
                Console.WriteLine($"{tomb[0]} 200-as érmét");
                Console.WriteLine($"{tomb[1]} 100-as érmét");
                Console.WriteLine($"{tomb[2]} 50-es érmét");
                Console.WriteLine($"{tomb[3]} 20-as érmét");
                Console.WriteLine($"{tomb[4]} 10-es érmét");
                Console.WriteLine($"{tomb[5]} 5-ös érmét");
                Console.WriteLine($"{tomb[6]} 2-es érmét");
                Console.WriteLine($"{tomb[7]} 1-es érmét");
            string kiir = $"{szam} = ";
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                {
                    kiir += $"tomb[i] * {ermek[i]} + " ;
                }
            }
           kiir= kiir.Substring(0)
            Console.WriteLine(kiir);
            Console.Write('\b');*/

            //6.feladat
            Console.WriteLine("kérek egy számot");
            int szam = Int32.Parse(Console.ReadLine());
            int[] tomb = kettesszamrendszer(szam);
            string kiir = $"{szam} = (";
            for (int i = 0; i < tomb.Length; i++)
            {
                kiir += 
            }

            

            Console.ReadKey(true);
        }
        static int kettoOszto(int szam)
        {
            int osztokSzama = 0;
           
            

            return osztokSzama;
        }
        static int[] kettesszamrendszer(int szam)
        {
            int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2));
            int[] kettesosztokSzama = new int[10];
            int[] kettesosztok = new int[] {meddig};

            for (int i = kettesosztokSzama; i++)
            {
                kettesosztok[i] = (int)Math.Pow(2, i);
            }

            for (int i = 0; i < kettesosztok.Length; i++)
            {


                while (szam >= kettesosztok[i])
                {
                    kettesosztokSzama[i]++;
                    szam -= kettesosztok[i];//szam = szam - osztok[i];

                }
            }

            return kettesosztokSzama;
        }
       
    }
}
