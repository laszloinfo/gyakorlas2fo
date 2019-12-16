using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valaami
{
    enum Napok { Hétfő=12,Kedd,Szerda=123,Csütörtök,Péntek,Szombat,Vasárnap}
    class Program
    {
        enum Honap { Január,Február,Március}
        static void Main(string[] args)
        {
            /*  bool kiertekel = true;
              int szam = 2;
              while (kiertekel && szam>=0)
              {

                  Console.Write("Kérek egy pozitív egész számot");
                  kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                  if (szam<=0)
                  {
                      kiertekel = true;
                      szam = -1;
                  }
              }
              Console.WriteLine($"A bekért szám: {szam}");*/

            /* int szam = 1;
             int szam2 = 2;
             bool kiertekel = true;
             bool kiertekel2 = true;

              while (kiertekel || (kiertekel2) && (szam+szam2 <= 10))
             {
                 Console.Write("Kérek egy számot");
                 kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                 Console.Write("Kérek egy másik számot");
                 kiertekel2 = !Int32.TryParse(Console.ReadLine(), out szam2);
                 if(szam+szam2>10)
                 {
                     szam = 1;
                     szam2 = 1;
                 }
             }
             Console.WriteLine($"a két szám összege:");*/

            //addig pozitív egész számok amíg kissebb mint 100

            /*  int osszeg = 0;
              int darabszam = 0;
              while (osszeg <=100)
              {
                  Console.Write("kérek egy pozitív egész számot");
                  int szam = Convert.ToInt32(Console.ReadLine());
                  osszeg += szam;
                  darabszam++; 
              }
              Console.WriteLine($"a számok darabszáma {darabszam--} összegük :{osszeg-szam}");*/


            /*  string kimenet = "";
              int stringhossz = 0;
              int darabszam = 0;
              while (stringhossz<=10)
              {
                  Console.Write("kérek egy stringet");
                  string beker = Console.ReadLine();

                  int hossz = beker.Length;
                  if (stringhossz+hossz<=10)
                  {
                      stringhossz += hossz;
                      kimenet += beker;
                      darabszam++;
                  }
              }

              Console.WriteLine($"a bekért stringek száma{darabszam}");
              Console.WriteLine($"Az eredő string{kimenet}");*/
            /* Console.WriteLine("kérek egy pozitív egész számot");
             int szam = Int32.Parse(Console.ReadLine());

             int faktorialis = 1;
             int index = 1;
             do
             {
                 faktorialis *= index;
                 index++;
             } while (index<=szam);

             Console.WriteLine($"{szam}! ={faktorialis}");*/


            //Binominális együtthatók:n>=k >= 0 esetén 

            for (int k = 1; k < 7; k++)
            {
                Console.SetCursorPosition(k*7, 0);

                Console.Write($"k={k-1}");
            }
            for (int n = 1; n < 7; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n={n-1}");
                for (int öi = 1; i < i + 1; i++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = FaktorialisSzamitas(j) / FaktorialisSzamitas(i) * FaktorialisSzamitas(j - i);
                }
            }




            Console.ReadKey(true);
        }
        static int FaktorialisSzamitas (int szam)
        {
            int faktorialis = 1;
            int index = 1;
            do
            {
                faktorialis *= index;
                
            } while (index <= szam);


            return faktorialis;

        }
    }
}
