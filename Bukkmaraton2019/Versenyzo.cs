using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton2019
{
    internal class Versenyzo
    {
        public Versenyzo(string rajtszam, string kategoria, string nev, string egyesulet, TimeSpan ido)
        {
            Rajtszam = rajtszam;
            Kategoria = kategoria;
            Nev = nev;
            Egyesulet = egyesulet;
            Ido = ido;
        }

        /*Rajtszám;Kategória;Név;Egyesület;Idő
M107;m3f;Ács Zoltán;;1:21:25*/
        public string Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public TimeSpan Ido { get; set; }
    }
}
