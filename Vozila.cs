using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kategorije
{
    internal class Vozila
    {
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int BrojKotaca { get; set; }
        public string Kategorija { get; set; }

        public Vozila(string model, int godinaProizvodnje, int brojKotaca)
        {
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            BrojKotaca = brojKotaca;
            Kategorija = GetKategorija(brojKotaca);
        }

        private string GetKategorija(int brojKotaca)
        {
            if (brojKotaca == 2)
                return "Motocikl";
            else if (brojKotaca == 4)
                return "Automobil";
            else if (brojKotaca == 6)
                return "Kamion";
            else
                return "nista";
        }
    }

}

