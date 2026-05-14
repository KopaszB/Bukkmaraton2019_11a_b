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
        static void Main(string[] args)
        {
            AdatBeolvas();
        }

        private static void AdatBeolvas()
        {
            using (StreamReader olvas = new StreamReader("bukkm2019.txt"))
            {
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    string[] sor = olvas.ReadLine().Split(';');
                    Versenyzo egyVersenyzo = new Versenyzo(sor[0],sor[1],sor[2],sor[3],TimeSpan.Parse(sor[4]));
                }
            }
        }
    }
}
