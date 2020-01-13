using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bovitettszamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("kérem az első számot");
                int elso = Int32.Parse(Console.ReadLine());
                szam elsoSzam = new szam(elso);
                Console.WriteLine("kérem a második számot");
                int masodik = Int32.Parse(Console.ReadLine());
                szam masodikSzam = new szam(masodik);
                Console.WriteLine("kérem a harmadik számot");
                int harmadik = Int32.Parse(Console.ReadLine());
                szam harmadikSzam = new szam(harmadik);

                elsoSzam.ElsoKetSzamOsszege(masodikSzam);
                elsoSzam.ElsoKetSzamSzorzas(masodikSzam);
                elsoSzam.ElsoKetSzamKulombseg(masodikSzam);
                elsoSzam.ElsoKetSzamHanyadosa(masodikSzam);
                elsoSzam.ElsoHaromSzamMertanikozep(masodikSzam,harmadikSzam);
                elsoSzam.ElsoHaromSzamSzamtanikozep(masodikSzam,harmadikSzam);

                
            }
            catch (Exception e)
            {

                
            }
            Console.ReadKey(true);
        }
    }
  class szam
    {
        private int BekertErtek;

        //ez itt a property-be "ágyazott" privát mezőérték
        public int bekert {get;set;}

        //egyargumentumos konstruktor 

            public szam(int bekert)
        {
            this.BekertErtek = bekert;
            
        }

        public void ElsoKetSzamOsszege(szam szam)
        {
            Console.WriteLine($"az első két szám összege:{this.BekertErtek + szam.BekertErtek}");
        }


        public void ElsoKetSzamSzorzas(szam szam)
        {
            Console.WriteLine($"az első két szám szorzási összege:{this.BekertErtek * szam.BekertErtek}");
        }

        public void ElsoKetSzamKulombseg(szam szam)
        {
            Console.WriteLine($"az első két szám kivonási összege:{this.BekertErtek - szam.BekertErtek}");
        }

        public void ElsoKetSzamHanyadosa(szam szam)
        {
            if (szam.BekertErtek != 0)
            {
                Console.WriteLine($"az első két szám szorzata:{(double)this.BekertErtek / szam.BekertErtek}F3");
            }
            else
            {
                Console.WriteLine($"az első két szám hányadosa nem véges érték.");
            }
        }
        public void ElsoKetSzamMertaniKozepe(szam szam)
        {
            if (szam.BekertErtek >= 0 && this.BekertErtek >= 0)
            {
                Console.WriteLine($"az első két szám mértani közepe:{Math.Sqrt(this.BekertErtek / szam.BekertErtek)}");
            }
            else
            {
                Console.WriteLine("az első két számól az egyik legalább negatív");
            }
        }
           public void ElsoHaromSzamSzamtanikozep(szam szam, szam masikSzam)
            {
            Console.WriteLine($"a számok számtani közepe:{((double)this.BekertErtek + szam.BekertErtek + masikSzam.BekertErtek) / 3}F3");
            }
        public void ElsoHaromSzamMertanikozep(szam szam, szam masikSzam)
        {
            double ertek = Math.Exp(Math.Log(this.BekertErtek * szam.BekertErtek *masikSzam.BekertErtek)/3);

            Console.WriteLine($"a számok számtani közepe:{((double)this.BekertErtek * szam.BekertErtek * masikSzam.BekertErtek) / 3}");
            Console.WriteLine($"Az első két szám mértani közepe: {Math.Pow((this.BekertErtek * szam.BekertErtek * masikSzam.BekertErtek), (double)1 / 3):F6}.");
        }
    }
       
}
    

