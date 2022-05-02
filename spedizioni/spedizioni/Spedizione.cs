using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public abstract class Spedizione
    {
        public string Mittente { get; set; }
        public string Destinatario { get; set; }
        public int Valore { get; set; }

        protected Spedizione(string mittente, string destinatario, int valore)
        {
            Mittente=mittente;
            Destinatario=destinatario;
            Valore=valore;
        }

        public abstract double printIngombro();

        public double ingombro()
        {
            return printIngombro();        
        }

        public bool uguaglianza(Spedizione tipo)
        {
            return 
                tipo.Mittente.Equals(Mittente);
                tipo.Destinatario.Equals(Destinatario);
                tipo.Valore.Equals(Valore);
        }

    }
}
