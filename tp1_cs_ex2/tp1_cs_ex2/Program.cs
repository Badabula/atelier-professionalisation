using tp1_cs_ex2;

Fournisseur f1 = new Fournisseur(1485, "on vends des livres", "25 rue de la fontaine");
Auteur a1 = new Auteur(1843,"mr","Auteur");
Livre l1 = new Livre("apprenez c#","1999",95,30);

l1.InfoLivre();
Console.WriteLine("");
a1.InfoAuteur();
Console.WriteLine("");
f1.Infofournisseur();
Console.WriteLine("");
Console.ReadLine();
