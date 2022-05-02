using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    internal class Pacco : Spedizione
    {
        protected double Altezza;
        protected double Larghezza;
        protected double Profondita;

        public Pacco(string mittente, string destinatario, int valore, double altezza, double larghezza, double profondita) : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Larghezza = larghezza;
            Profondita = profondita;

        }

        public override double printIngombro()
        {
            var ingombro = Altezza * Larghezza * Profondita;
            return ingombro;
        }
    }
}
