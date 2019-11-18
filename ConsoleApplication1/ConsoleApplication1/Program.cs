using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;
            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }
            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());
            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());
            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }



            //15.feladat

            Console.Write("kérem a pozitív egész számot!");
            int BemenoSzam = Int32.Parse(Console.ReadLine());
            /*string kiiratas = "";
            for (int i =1;i < BemenoSzam;i++)
            {
                kiiratas += i + " ";
            }
            Console.WriteLine(kiiratas);

            /*for (int i = 1; i < BemenoSzam; i++)
            {
                Console.Write(i + " ");
            }

             //elöltesztelő ciklus
              int i = 1;
            while(i < BemenoSzam)
            {
                Console.Write(i++ + " ");
                //i = i + 1;
                //i += 1;
                //i++;

            }

            /* hátultesztelő ciklus
              int i=1;
            do
            {
                Console.Write(i++);
            } while (i < BemenoSzam); */

            /*16.feladat

            Console.Write("kérem a pozitív egész számot!");
            int BemenoSzam = Int32.Parse(Console.ReadLine());
            /*string kiiratas = "";
            for (int i =1;i < BemenoSzam;i++)
            {
                kiiratas += i + "\n "; // \n jelöli a sortörést
            }
            Console.WriteLine(kiiratas);
            for  (int i =1,i < BemenoSzam,i++)
            {
                Console.WriteLine(i);
            }*/


            //17.feladat

            /*Console.Write("kérem a pozitív egész számot!");
            int BemenoSzam = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{BemenoSzam} egész osztói:");
            /* for(int i= 1;i<=BemenoSzam;i++)
             {

                 if (BemenoSzam % i == 0) 
                 {
                     Console.WriteLine(i);
                 }
             }*/

            /*int i = 1;
            while(i<=BemenoSzam){

                if (BemenoSzam % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/
            /*Console.Write("kérem a pozitív egész számot!");
            int BemenoSzam = Int32.Parse(Console.ReadLine());
            int szamlalo = 0;
            int osztosszeg = 0;
            for(int i=1;i< BemenoSzam + 1;i++)
            {

                if(BemenoSzam % i == 0)
                {
                    szamlalo++;
                    osztosszeg += i;
                }
            }
             if(szamlalo==2)
            {
                Console.WriteLine($"a bemnő szám {BemenoSzam} prím");
                Console.WriteLine($"a bemnő szám {BemenoSzam}osztóinak összege :{osztosszeg}");
            }
            else
            {
                Console.WriteLine($"a bemenő szám {BemenoSzam}nem prím");
                Console.WriteLine($"a bemnő szám {BemenoSzam}osztóinak összege :{osztosszeg}");
            }*/


            //19.feladat
            /*Console.WriteLine("kérem a pozitív egész számot:");
            int BemenoSzam = Int32.Parse(Console.ReadLine());
            int osztokosszege = 0;

            int i = 1;
            while(i < BemenoSzam)
            {
                if(BemenoSzam % i ==0)
                {
                    osztokosszege += 1;
                }
                i++;
            }
            if(osztokosszege == BemenoSzam)
            {
                Console.WriteLine($"A szám {BemenoSzam} tökéletes szám.");

            }

            else
            {
                Console.WriteLine($"A szám {BemenoSzam} nem tökéletes szám");
            }*/
            /*int alap = -1;
            while(alap < 0 || alap >=10)
            {
                Console.WriteLine("kérem az alapot:");
                int alap = Int32.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("kérem a kitevőt");
            int kitevo = Int32.Parse(Console.ReadLine());
            int hatvany = 1;


            for(int i = 0;i < kitevo;i++)
            {
                hatvany *= alap;

            }
            Console.Write($"a hatvány: {hatvany}");*/


            //plusz feladat
            /*int szam = 3;


            while(primszamE(szam))
            {

                Console.Write("kérek egy nem prím számot");
                szam = Convert.ToInt32(Console.ReadLine());

            }*/
            /* int szam = 0;
             int osszeg = 0;
             while(szam<= 10)
             {

                 Console.WriteLine("kérek egy 10-nél kisebb egész számot: ");
                 szam = Int32.Parse(Console.ReadLine());

                 if(szam<=10)
                 {
                     osszeg += szam;
                     Console.WriteLine($"az eddig beolvasott számok összege: {osszeg}.");

                 }
                 else
                 {
                     Console.WriteLine("nem megfelő szám!");
                     break;
                 }

             }

             Console.WriteLine($"a beolvasott számok összege: {osszeg}");*/

            //a tryparse használata(int32.TryParse)
            /*int szam = -89;
            bool valami = true;
            do
            {
                Console.Write("kérek egy számot!");

                 valami = Int32.TryParse(Console.ReadLine(), out szam);

            } while (!valami);


            
            
            Console.WriteLine($"a bekért szám:{szam}");*/


            //23.feladat

            /*string kimenet = "";

            Console.Write("Kérek egy egész Számot");

            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";

            while(szam % 2 == 0)
            {
                kimenet += 2 + " * ";
                szam = szam / 2;

            }
            
           

            Console.WriteLine(kimenet);*/


            //25.feladat

            /*string kimenet = "";

            Console.Write("Kérek egy egész Számot");
            int szam = Convert.ToInt32(Console.ReadLine());

            kimenet += szam + " = ";
            int egesz = 0;
            int tort = -szam;




            while(szam - 3 >= 0)

            {
                szam = szam - 3;
                egesz++;
                tort = szam ;


            }

            kimenet += egesz + " * 3 + " + tort;

            Console.WriteLine(kimenet);*/
            //24.feladat
            /*string alma = "";


            while(alma != "alma"){
                Console.WriteLine("Kérek egy gyümölcsöt");
                alma = Console.ReadLine();


            }
            Console.WriteLine("az alma gyümölcs");*/



            //28./29. feladat
            /* Console.WriteLine("Kérek egy egész számot!");

             int szam = Convert.ToInt32(Console.ReadLine());
             kimenet += szam + "=";

             int meddig = (int)(Math.Floor(Math.Sqrt(szam))) + 1;


             for (int i = 2; i < meddig; i++)
             {

                 if (szam % i == 0)
                 {

                 }
             }

             Console.WriteLine(kimenet);*/




           /* Console.WriteLine("kérek egy számot");
            int szam = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < szam+1; i++)
            {

                for (int j = 1; j < szam+1; j++)
                {
                    Console.SetCursorPosition(3 * (j - 1) + 1, i);
                    Console.Write($"{i * j}");
                }
            }*/


            //34.feladat
            
            for(int i=1;i < 100;i++)
            {

                for(int j=10;j<100;j++)
                {
                    for(int k=10;k<100;k++){
                        
                    }

                }
            }




            Console.ReadKey(true);
       
        








           /* static bool primszamE(int szam)
             {
                bool teljesul = true;


                int osztokSzama = 0;

                for (int i = 1; i <= szam; i++)
                {
                    if (szam % i == 0)
                    {
                        osztokSzama++;
                    }

                }
                if (osztokSzama == 2)
                {
                    return teljesul;
                }
                else
                {
                    return !teljesul;
                }*/
            }
        }
    }


