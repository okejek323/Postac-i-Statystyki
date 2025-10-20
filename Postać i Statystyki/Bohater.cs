using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postać_i_Statystyki
{
        internal class Bohater
    {
        public string imie;
        public string klasa;
        private int zdrowie = 100;
        private int mana = 50;
        public int getZdrowie { get; }
        public int setZdrowie(int obrażenia)
        {
            if (zdrowie >= 0)
            {
                zdrowie -= obrażenia;
                if (zdrowie <= 0)
                {
                    zdrowie = 0;
                    Console.WriteLine($"Postać została pokonana");
                }
            }
            return zdrowie;
        }

        public void Osoba(string imie, string klasa)
        {
            Console.WriteLine($"{imie} - {klasa} \n Zdrowie - {zdrowie} \n Mana - {mana} \n");
        }

        public virtual void Atakuj(Bohater cel) 
        {
            cel.setZdrowie(10);
        }

        public class Wojownik : Bohater
        {
            public override void Atakuj(Bohater cel)
            {
                cel.setZdrowie(15);
            }
        }

        public class Czarodziej : Bohater
        {
            public override void Atakuj(Bohater cel)
            {
                cel.setZdrowie(25);
                mana -= 5;
            }
        }
    }
}
