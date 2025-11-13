using Postać_i_Statystyki;


//Bohater Bohater_A = new Bohater.Wojownik();
//Bohater Bohater_B = new Bohater.Czarodziej();

//Potwór Potwór_A = new Potwór.Ork();
//Potwór Potwór_B = new Potwór.Goblin();

//Bohater_B.Atakuj(Bohater_A);
//Bohater_A.Atakuj(Bohater_B);

//Bohater_A.Osoba("Tomek", "Wojownik");
//Bohater_B.Osoba("Michał", "Mag");

//List<Potwór> Potwory = new List<Potwór>();

//Potwory.Add(new Potwór.Ork());
//Potwory.Add(new Potwór.Goblin());

//foreach (var potwór in Potwory)
//{
//    potwór.wydajDzwiek();
//}

Kaplan Miguel = new Kaplan();
Miguel.mana = 50;

Miguel.rzucCzar("Kula ognia");
Console.WriteLine("----------------------------");
Miguel.rzucCzar("Błyskawica");
Console.WriteLine("----------------------------");
Miguel.rzucCzar("Rock");
Console.WriteLine("----------------------------");
Miguel.regenerujMana(25);
