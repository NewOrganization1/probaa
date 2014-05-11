using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aranzmani
{
    public class Aranzman
    {
        public string mesto { get; set; }
        public string drzava { get; set; }
        public int denovi { get; set; }
        public int cena { get; set; }
        public Aranzman(){}

        public Aranzman(string m, string d, int den, int c)
        {
            mesto = m;
            drzava = d;
            denovi = den;
            cena = c;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2} dena", mesto, drzava, denovi);
            }
    }
}
