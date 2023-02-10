//Badr Aboulakjam
int mois, jours, annee;
char reponse;

do
{
    Console.WriteLine("saisir le nombre d'un mois (1-12):");
    mois = int.Parse(Console.ReadLine());

    if (mois > 12 || mois < 1)
    {
        Console.WriteLine("erreur de saisi");
    }
    else
    {
        if (mois == 2)
        {

            Console.WriteLine("saisir une année sur 4 chifres");
            annee = int.Parse(Console.ReadLine());

            if ((annee % 400 == 0) || ((annee % 4 == 0) && (annee % 100! == 0)))
            {
                Console.WriteLine("anné est bisextile");
                jours = 29;
            }
            else
            {
                Console.WriteLine("année n'est pas bisextile");
                jours = 28;
            }


        }
        else
        {
            if ((mois == 4) || (mois == 6) || (mois == 9) || (mois == 11))
            {
                jours = 30;

            }
            else
            {
                jours = 31;
            }
        }

        Console.WriteLine("le mois " + mois + " comporte " + jours + " jours");


    }
    Console.WriteLine("rocommencer? (Y/N)");
    reponse = char.Parse(Console.ReadLine());

} while (reponse == 'Y');


    