using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class Onnivori : Animale
    {
        public Onnivori(string cibo) : base(cibo)
        {
        }

        public override void mangia()
        {
            Console.WriteLine($"sto mangianog {Cibo} perchè sono onnivoro");
        }
    }
}
