using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Ultrabalaton_bm
{
    public class Adatok
    {
        public string nev;
        public int rajtSzam;
        public string kategoria;
        public string idoEredmeny;
        public int szazalek;
        public Adatok(string adat)
        {
            
                string[] row = adat.Split(';');
                nev = row[0];
                rajtSzam = int.Parse(row[1]);
                kategoria = row[2];
                idoEredmeny = row[3];
                szazalek = int.Parse(row[4]);
            
        }

        public double IdőÓrában()
        {
            string[] sor = idoEredmeny.Split(':');
            double ora = 0;
            ora += double.Parse(sor[0]);
            ora += double.Parse(sor[1]) / (double)60;
            ora += double.Parse(sor[2]) / (double)3600;

            return ora;
        }
        
    }
}
