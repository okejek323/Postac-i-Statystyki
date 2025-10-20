using Postać_i_Statystyki;

Bohater Bohater_A = new Bohater.Wojownik();
Bohater Bohater_B = new Bohater.Czarodziej();

Bohater_B.Atakuj(Bohater_A);
Bohater_A.Atakuj(Bohater_B);

Bohater_A.Osoba("Tomek", "Wojownik");
Bohater_B.Osoba("Michał", "Mag");
