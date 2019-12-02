using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("kérem a tabu karaktert");
            //char tabu = Char.Parse(Console.ReadLine());
            //50. feladat
            /* for(int i = 0; i< szo.Length; i++)
             {
                 Console.Write(szo[i]+ " ");
             }
             Console.Write("\b");*/
            //51.feladat
            /*for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] != tabu)
                {
                    Console.Write(szo[i]);
                }*/
            //52.feladat
            /*for (int i = 0; i < szo.Length; i++)


            {
            if(i % 2 == 1)
                {
                    Console.WriteLine(szo[i]);

                }
            }*/
            /*Console.WriteLine("hozz létre egy szót");
            string szo = Console.ReadLine();
            Console.Write("Kérem az indexet");
            int index = Int32.Parse(Console.ReadLine());
            if (index < szo.Length)
            {
                Console.WriteLine($"a keresett karakter:{szo[index]}");
            }
            else
            {
                Console.WriteLine("bocsi, de ilyen indexű karakter nincs");

            }*/

            //53.feladat

            /*Console.WriteLine("hozz létre egy szót");
            string szo = Console.ReadLine();
            int i = 0;
            while (i< szo.Length)
            {
                Console.WriteLine($"{szo[i]} - {(int)szo[i]}");
                i++;
            }*/


            //54.feldat
            /*Console.WriteLine("hozz létre egy szót");
            string szo = Console.ReadLine();
            for (int i = szo.Length -1; i >= 0; i--)
            {
                Console.Write(szo[i]);
            }*/
            //55.feladat
            /*Console.WriteLine("kérek egy mondatot: ");
            string mondat = Console.ReadLine();
            */
            /* for (int i = 0; i < mondat.Length; i++)
             {
                 if ((int)mondat[i] != 32)
                 {
                     Console.Write(mondat[i]);
                 }

                 else
                 {
                     Console.WriteLine();
                 }
             }*/

            /*string [] tomb = mondat.Split('e');
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }*/

            //56.feladat

            /* Console.Write("kérek egy szót:");
             string szo = Console.ReadLine();
             string forditottSzo = "";
             for (int i = szo.Length - 1; i >= 0 ; i--)
             {
                 forditottSzo  += szo[i];
             }
             Console.WriteLine(forditottSzo.ToUpper());*/



            Console.Write("Kérek egy mondatot!");

            /*  string mondat = Console.ReadLine();
              string[] tomb = mondat.Split(' ');
              for (int i = 0; i < tomb.Length; i++)
              {
                  string elsobetu = tomb[i].Substring(0, 1).ToUpper();
                  string maradek = tomb[i].Substring(1);
                  Console.WriteLine(elsobetu + maradek);


              }*/
            //+feladat adott szóban minden második betű nagybetű
            Console.Write("kérek egy szót:");
            string szo = Console.ReadLine();
            string kiir = "";
            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Char ch = (char)((int)szo[i] - 32);
                    kiir += ch;

                }
                else
                {

                    kiir += szo[i];
                }
            }
            Console.WriteLine(kiir);


            Console.ReadKey();
        }
    }
}
