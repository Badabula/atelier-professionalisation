using System.Runtime.CompilerServices;
using TP3GestionCommerciale;

categorie ca1 = new categorie("1515", "shap");
categorie ca2 = new categorie("1582", "shapee");

Commercial c = new Commercial("Abdi", "null" ,158, ca1);   
Commercial c1 = new Commercial("Turra","Alex", 2002, ca2);
Commercial c2 = new Commercial("Abdi", "Sarah", 1992, ca2);
Commercial c3 = new Commercial("christopher", "Parenti", 1999, ca1);

service national = new service(548, c1);
service international = new service();


Console.WriteLine(c1.ToString());
Console.WriteLine(c1.compare(c));
Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
Console.WriteLine(c2.ToString());
Console.WriteLine(c2.compare(c));
Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
Console.WriteLine(c3.ToString());
Console.WriteLine(c3.compare(c));




