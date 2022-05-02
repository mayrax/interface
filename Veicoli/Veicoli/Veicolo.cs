using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veicoli
{
    public abstract class Veicolo : Motore
    {

        public readonly string Brand;
        public readonly int Seat;
        public readonly Motore Engine;

        protected Veicolo(string brand, int seat, Motore engine)
        {
            Brand =brand;
            Seat =seat;
            Engine = engine;
        }
    }
}
