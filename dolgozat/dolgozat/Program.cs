using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int év;
            double toke, kamat, teljesosszeg;
            Console.Write("Kérek egy alapösszeget!");
            toke = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a futásiidőt : ");
            év = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kérek egy kamat százalékot: ");
            kamat = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            for(int i=0;i<év;i++)
            {
                
                Console.WriteLine($"{i+1}, év végén: ");


            }
            
            Console.ReadLine();

        }
    }
}
