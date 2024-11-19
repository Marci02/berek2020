using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Ber
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Fizetes { get; set; }

        public Ber(string sor)
        {
            var v = sor.Split(';');
            Nev = v[0];
            Nem = v[1] == "F";
            Reszleg = v[2];
            Belepes = int.Parse(v[3]);
            Fizetes = int.Parse(v[4]);
        }
    }
}
