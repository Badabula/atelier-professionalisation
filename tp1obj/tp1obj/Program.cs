using System;
using tp1obj;

Salarie s1 = new Salarie(15, "toto", "toto", 2000, 0.22);
Salarie s2 = new Salarie(16, "titi", "tutu", 2500, 0.22);

Console.WriteLine("le salaire brut de "+ s1.Prenom + " est de " + s1.Salaire + " ce qui donne un sailaire net de " + s1.CalculersalaireNet() + " euro");
Console.WriteLine("le salaire brut de " + s2.Prenom + " est de " + s2.Salaire + " ce qui donne un sailaire net de " + s2.CalculersalaireNet() + " euro");
Console.ReadLine();
