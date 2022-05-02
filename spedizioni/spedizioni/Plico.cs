using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    internal class Plico : Spedizione
    {
        protected double Altezza;
        protected double Larghezza;

        public Plico(string mittente, string destinatario, int valore , double altezza, double larghezza) : base(mittente, destinatario, valore)
        {
            Altezza = altezza;
            Larghezza = larghezza;
        }

        public override double printIngombro()
        {
            var ingombro = Altezza * Larghezza;
            return ingombro;
        }
    }
}
