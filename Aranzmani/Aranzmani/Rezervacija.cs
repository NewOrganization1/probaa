using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aranzmani
{
    class Rezervacija
    {
        public Aranzman aranzmani { get; set; }
        public int lica { get; set; }
        public int doplata { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} x {2:0.0} + {3:0.0} = {4:0.0}", aranzmani.mesto, lica, aranzmani.cena, doplata, lica * aranzmani.cena + doplata); 
            }
        

    }
}
