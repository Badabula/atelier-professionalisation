int mois, jours, annee;
char reponse;


    Console.WriteLine("saisir le nombre d'un mois (1-12):");
    mois = int.Parse(Console.ReadLine());

    if (12 < mois && mois < 1)
    {
        Console.WriteLine("erreur de saisi");
        Console.WriteLine("rocommencer? (Y/N)");
        reponse = char.Parse(Console.ReadLine());
    }
