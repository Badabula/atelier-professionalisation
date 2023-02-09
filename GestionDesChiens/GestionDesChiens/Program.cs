using GestionDesChiens;

Animal A1 = new Animal(23, "lulu", "dobberman", 25, 6, 3);
Animal A2 = new Animal(24, "bobby", "chihuahua", 5, 7, 1);
Animal A3 = new Animal();
A3.Numero = 5;
A3.Nom = "bill";
A3.Race = "terrier";
A3.Poids = 8;
A3.Type = 2;
A3.Age = 5;

A1.CalculerRation();
A2.CalculerRation();
A3.CalculerRation();

A1.Affiche();
A2.Affiche();
A3.Affiche();

Console.ReadLine();
