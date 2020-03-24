using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    class Ucenik : Osoba
    {
        int Razred;

        public int Razred1 { get => Razred; set => Razred = value; }
    }
}
