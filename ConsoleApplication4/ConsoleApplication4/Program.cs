using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlás
{
    enum Napok { Hétfő = 12, Kedd, Szerda, Csütörtök, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Honap { Január, Február, Március }
        static void Main(string[] args)
        {
            /*feladat1:
             
            int szam = 2;
            bool kiertekel = true;
                while(kiertekel&&szam>=0)
            {
                Console.WriteLine("Kérek egy pozitiv egész számot!");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                if(szam<=0)
                {
                    kiertekel = true;
                    szam = 1;
                }
            }
            Console.WriteLine($"A bekért szám: {szam}");
            

            feladat2:
            bool kiertekela = true;
            bool kiertekel = true;
            int szama = 1;
            int szamb = 1;
            while (kiertekel kiertekela)&&(szama +szamb<= 10))
            {
                Console.WriteLine("Kérek egy egész számot!");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szama);
                Console.WriteLine("Kérek egy másik egész számot!!");
                kiertekela = !Int32.TryParse(Console.ReadLine(), out szamb);
                if(szama+szamb>10)
                {
                    kiertekel = true;
                    kiertekela = true;
                    szamb = 1;
                    szama = 1;
                }
            }
            Console.WriteLine($"A két szám összege: {szama + szamb}");
             
            //feladat3
            int összeg = 0;
            int darabszam = 0;
            int szam = 0;
            while(összeg<=100)
            {
                Console.Write("Kérek egy egész pozitív számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                összeg += szam;
                darabszam++;
            }

            Console.WriteLine($"A számok darabszáma: {--darabszam}, összegük: {összeg-szam}");

            feladat4 

            
            int stringhossz = 0;
            int darabszam = 0;
            string kimenet ="";
            while (osszhossz <= 10)
            {
                Console.Write("Kérek egy szót!");
                kimenet = Console.ReadLine();
                int hosszu = kimenet.Length;
               if( osszhossz+hosszu<=10)
                {
                    szöveg += hosszu;
                }
            }

          
            feladat5
            Console.WriteLine("Kérek egy egész pozitiv számot 20ig");
            int szam = Int32.Parse(Console.ReadLine());
            int faktorialis = 1;
            int index = 1;
            do
            {
                faktorialis *= index++;
               

            } while (index <= szam);
            {
                Console.WriteLine($"{szam}!={faktorialis}");
            }

*/


            /*  for (int k = 1; k < 7; k++)
              {
                  Console.SetCursorPosition(k * 7, 0);
                  Console.Write($"k= {k - 1}");

              }
              for (int n = 1; n < 7; n++)
              {
                  Console.SetCursorPosition(0, n);
                  Console.Write($"n= {n - 1}");
              }
              for (int i = 1; i < 7; i++)
              {
                  for (int j = 1; j < i + 1; j++)
                  {
                      Console.SetCursorPosition(j * 7, i);
                      int fakt = faktorialisSazmitas(i - 1) / (faktorialisSazmitas(j - 1) * faktorialisSazmitas(i - j));
                      Console.Write(fakt);
                  }
              }*/



            //break vagy continue
            for (int i = 1; i < 21; i++)
            {
                if (i%5 !=0)
                {
                    continue;
                }
 Console.WriteLine(i);
            }
           


            Console.ReadKey(true);
        }
        static int faktorialisSazmitas(int szam)
        {
            int faktorialis = 1;
            int index = 1;
            do
            {
                faktorialis *= index++;

            } while (index <= szam);

            return faktorialis;
        }
    }
}