using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public abstract class Animale
    {
       public string Cibo;

        public Animale(String cibo) 
        {
            Cibo = cibo;
        }

        public abstract void mangia();
         
           
        
    }
}
