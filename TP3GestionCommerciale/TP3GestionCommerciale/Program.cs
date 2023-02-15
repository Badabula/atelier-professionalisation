using System.Runtime.CompilerServices;
using TP3GestionCommerciale;

Commercial c = new Commercial("Abdi", "null" ,158);   
Commercial c1 = new Commercial("Turra","Alex", 2002);
Commercial c2 = new Commercial("Abdi", "Sarah", 1992);
Commercial c3 = new Commercial("christopher", "Parenti", 1999);

categorie ca1 = new categorie("1515", "shap");
categorie ca2 = new categorie("1582", "shapee");


Console.WriteLine(c1.ToString());
Console.WriteLine(c1.compare(c));

Console.WriteLine(c2.ToString());
Console.WriteLine(c2.compare(c));

Console.WriteLine(c3.ToString());
Console.WriteLine(c3.compare(c));


Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");

Console.WriteLine(ca1.ToString());
Console.WriteLine(ca2.ToString());   
