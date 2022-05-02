using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace veicoli
{
    public abstract class Motore 
    {   
        public readonly string Tipo;
        public readonly string Carburante;

        protected Motore() { }
        protected Motore(string tipo, string carburante)
        {
            Tipo = tipo;    
            Carburante = carburante;

        }
            
    }
}
