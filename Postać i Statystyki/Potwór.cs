using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postać_i_Statystyki
{
    internal abstract class Potwór
    {
        public string nazwa;
        public int zdrowie;

        public abstract void wydajDzwiek();

        public class Ork : Potwór 
        {
            public override void wydajDzwiek() 
            {
                Console.WriteLine($"FOR THE HORDE!");
            }
        }

        public class Goblin : Potwór 
        {
            public override void wydajDzwiek()
            {
                Console.WriteLine($"Squeak!");
            }
        }
    }
}
