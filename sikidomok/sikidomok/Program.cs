using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {

            negyzet negyzet = new negyzet(12);
            Console.WriteLine($"a négyzet kerülete:{negyzet.KeruletSzamol()}");
            Console.WriteLine($"a négyzet kerülete:{negyzet.TeruletSzamol()}");


            Teglalap teglalap = new Teglalap(12, 10);
            onsole.WriteLine($"a négyzet kerülete:{teglalap.KeruletSzamol()}");
            Console.WriteLine($"a négyzet kerülete:{teglalap.TeruletSzamol()}");
        }

    }
    class negyzet
    {
        public int AOldal { get; set; }


        public negyzet(int aoldal)
        {
            this.AOldal = aoldal;
        }


        public int TeruletSzamol()
        {
            return this.AOldal * this.AOldal;
        }
        public int KeruletSzamol()
        {
            return 4 * this.AOldal;
        }
        
    }
    class Teglalap : negyzet
    {
        public int Boldal { get; set; }
        public Teglalap(int aOldal, int bOldal) : base(aOldal)
        {
            this.Boldal = bOldal;
        }
        new public int TeruletSzamol()
        {
            return this.AOldal * this.Boldal;

        }
        new public int KeruletSzamol()
        {
            return 2 * (this.AOldal + Boldal);

        }


    }
}