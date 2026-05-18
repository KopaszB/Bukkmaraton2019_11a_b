using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bukkmaraton2019
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static void Main(string[] args)
        {
            AdatBeolvas();
            //Kiir();

            //4.feladat
            int nemBefutok = 691 - versenyzok.Count;
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(double)nemBefutok/691*100}%");

            //5.feladat
            int noiDb = 0;
            foreach (var item in versenyzok)
            {
                if (item.TavNev=="Rövid" && item.Kategoria.Last()=='n')
                {
                    noiDb++;
                }
            }
            Console.WriteLine($"5. feladat: Női versenyzők száma a rövid távú versenyen: {noiDb}fő");

            //6.feladat
            Console.Write("6. feladat: ");
            Console.WriteLine(TobbMintHatOra()?"Volt ilyen versenyzo":"Nem volt ilyen versenyző");

            //7. feladat
            Versenyzo nyertesFFRovid = null;
            nyertesFFRovid.Ido = TimeSpan.MaxValue;

            foreach (var item in versenyzok)
            {
                if (item.TavNev == "Rövid" && item.Kategoria == "ff" && item.Ido<nyertesFFRovid.Ido)
                {
                    nyertesFFRovid.Ido = item.Ido;
                }
            }


            Console.ReadKey();
        }


        private static bool TobbMintHatOra()
        {
            bool eredmeny = false;
            foreach (var item in versenyzok)
            {
                if (item.Ido.TotalHours>6)
                {
                    eredmeny = true;
                    break;
                }
            }
            return eredmeny;
        }
        private static void Kiir()
        {
            foreach (var item in versenyzok)
            {
                Console.WriteLine($"{item.Nev,-25}{item.TavNev}");
            }
        }

        private static void AdatBeolvas()
        {
            try
            {
                using (StreamReader olvas = new StreamReader("bukkm2019.txt"))
                {
                    olvas.ReadLine();
                    while (!olvas.EndOfStream)
                    {
                        string[] sor = olvas.ReadLine().Split(';');
                        Versenyzo egyVersenyzo = new Versenyzo(sor[0], sor[1], sor[2], sor[3], TimeSpan.Parse(sor[4]));
                        versenyzok.Add(egyVersenyzo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}
