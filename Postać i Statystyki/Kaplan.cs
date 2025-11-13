using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postać_i_Statystyki
{

    public interface Zaklinacz
    {
        void rzucCzar(string nazwaCzaru);
        void regenerujMana(int wartosc);
    }
    public class Kaplan : Zaklinacz
    {
        public int mana;

        public void rzucCzar(string nazwaCzaru)
        {
            if (mana >= 25)
            {
                Console.WriteLine($"Kapłan rzuca czar o nazwie: {nazwaCzaru}");
                mana -= 25;
                if (mana < 0) { mana = 0; }
                Console.WriteLine($"Pozostało {mana} many");
            }
            else
            {
                Console.WriteLine($"Kapłan ma za mało many. Nie jest w stanie używać czarów.");
            }
        }

        public void regenerujMana(int wartosc)
        {
            mana += wartosc;
            Console.WriteLine($"Kapłan regeneruje mane i ma aktualnie {mana} many");
        }
    }
}
