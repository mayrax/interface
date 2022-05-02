using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class Carnivori : Animale
    {
        public Carnivori(string cibo) : base(cibo)
        {
        }

        public override void mangia()
        {
            Console.WriteLine($"sto mangianodo una {Cibo} perchè sono carnivoro");
        }
    }
}
