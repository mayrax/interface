using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Erbivori : Animale
    {
        public Erbivori(string cibo) : base(cibo)
        {
        }

        public override void mangia()
        {
            Console.WriteLine($"sto mangiando {Cibo} perchè sono erbivoro");
        }
    }
}
