using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyokKetto
{
    class Program
    {
        static void Main(string[] args)
        {
            Megye [] megyek = new Megye[4];
            for (int i = 0; i < megyek.Length; i++)
            {


Console.Write("kérem a megye nevét:");
            string nev = Console.ReadLine();
            Console.Write("kérem a megye területét:");
            int terulet = Int32.Parse(Console.ReadLine());
            Console.Write("kérem a megye székhelyét:");
            string MegyeSzekhely = Console.ReadLine();
            Console.WriteLine("Nyugat-Magyarországi-e:");
            bool KeletiE = Boolean.Parse(Console.ReadLine());
                megyek[i] = new Megye(nev, terulet, MegyeSzekhely,KeletiE);
            }

            for (int i = 0; i < megyek.Length; i++)
            {
                megyek[i].KiirAdatok();
            }
            
           // NyugatMagyarországiMegye nyMegye = new NyugatMagyarországiMegye(nev, terulet, MegyeSzekhely, nyugatiE);
          //  nyMegye.KiirAdatok(); 
             //Megye megye = new Megye(nev,terulet,MegyeSzekhely);


            Console.ReadKey(true);
              
        }
    }
    class Megye
        {
        public string Nev  {get;set;}
        public int Terulet { get; set; }
        public string MegyeSzekhely { get; set; }
        public bool KeletMagyarországiE { get; set; }

       

        public Megye(string nev, int terulet, string megyeSzekhely)
        {
            this.Nev = nev;
            this.Terulet = terulet;
            this.MegyeSzekhely = megyeSzekhely;
         
        }

        public Megye(string nev, int terulet, string megyeSzekhely, bool KeletiE)
        {
            this.Nev = nev;
            this.Terulet = terulet;
            this.MegyeSzekhely = megyeSzekhely;
            this.KeletMagyarországiE = KeletiE;
        }

        public void KiirAdatok()
        {
          if(this.KeletMagyarországiE)
            {
               Console.WriteLine($"A megye Neve:{this.Nev},területe:{this.Terulet},megye székhelye:{this.MegyeSzekhely}.");
            }
               
            
        }

    }

    class NyugatMagyarországiMegye : Megye
    {
        public bool NyugatMagyarországiE { get; set; }
         public NyugatMagyarországiMegye(string nev,int terulet,string megyeSzekhely, bool nyugatiE) : base(nev,terulet,megyeSzekhely)
        {
            this.NyugatMagyarországiE = nyugatiE;
        }
       
        new public void KiirAdatok()
        {
            if(this.NyugatMagyarországiE)
            {
                Console.WriteLine($"A megye Neve:{this.Nev},területe:{this.Terulet},megye székhelye:{this.MegyeSzekhely}.");
            }
        }

    }
}
