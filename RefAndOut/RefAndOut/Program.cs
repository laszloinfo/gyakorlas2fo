using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("Kérem az első számot!");
            int elso = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot!");
            int masodik = Int32.Parse(Console.ReadLine());
           Console.WriteLine("Kérek egy nevet!");
            string nev =Console.ReadLine();

            Console.WriteLine($"A két szám összege{osszead(out  elso,out masodik,out nev)}");

            Console.WriteLine($"a két szám {elso},{masodik}");
            Console.WriteLine($"A név: {nev}");


            Console.ReadKey(true);
        }
       /*static int osszead( int a,int b)
        {
            //létrehozom a visszatérendő értéket és inicializálom 
            int osszeg = a+b;


            a = -128;
            b = -49;
            //kiszámolom a visszatérő értéket
            return osszeg;
            //visszaadom a visszatérő értéket
            

            létrehozom a visszatérő értéket,inicializálom és kiszámolom
             //int osszeg = a + b;
            //visszaadom a visszatérő értéket
           // return osszeg;
        }*/

       static int osszead(out int a,out int b,out string nev)
        {
              a = 0;
           b = 0;
            int osszeg = a + b;
            nev = "gabor";
         

            return osszeg;
        


        }
    }
}
