using EleveDll;

Eleve el1 = new Eleve("lorine", 10, 11);
Eleve el2 = new Eleve("françois", 4, 20);
Eleve el3 = new Eleve("jean", 12, 15);

Eleve[] tabel = new Eleve[3];
tabel[0] = el1;
tabel[1] = el2;
tabel[2] = el3;



foreach (Eleve el in tabel)
{
    el.Afficher();
}

Eleve thebest = Meilleur(tabel);
thebest.Afficher();

static Eleve Meilleur(Eleve[] tab)
{

    Eleve eleveMeilleur = null;
    float bestmoyenne = 0;

    foreach (Eleve el in tab)
    {
        if (el.Moyenne()>bestmoyenne)
        {
            bestmoyenne = el.Moyenne();
            eleveMeilleur = el;
        }
    }

    return eleveMeilleur;

}