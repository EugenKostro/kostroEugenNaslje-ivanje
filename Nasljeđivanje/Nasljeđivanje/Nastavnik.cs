using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    class Nastavnik : Osoba
    {
        string Predmet;

        public string Predmet1 { get => Predmet; set => Predmet = value; }
    }
}
