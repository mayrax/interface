using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class Corriere 
    {
        public string Nome;
        public List<Spedizione> Consegne;
        
        public Corriere(string nome)
        {
            Nome = nome;
            Consegne = new List<Spedizione>();
        }


        public void addSpedizione(Spedizione spedizione)
        {
            Consegne.Add(spedizione);                                                                                                                         
        }


        public string listaSpedizioni()
        {
            var output = string.Empty;
            foreach (var spedizione in Consegne)
            {
               output = string.Concat(output,
                   $"Mittente: {spedizione.Mittente}\n + Destinatario: {spedizione.Destinatario}\n + Ingombro: {spedizione.ingombro()}",Environment.NewLine);

            }

            return output;
        }

        public double TotaleIngombro()
        {
            double totale = 0;
            foreach (var volume in Consegne)
            {
                totale= totale + volume.ingombro();
            }

            return totale;
        }


    }
}
