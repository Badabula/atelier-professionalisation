int[] tabPos = new int[10];
int[] tabNeg = new int[10];
int nbr;
int iPos = 0;
int iNeg = 0;

do
{
    Console.WriteLine("saisir un nombre entier soi negatif ou positif:");
    nbr = int.Parse(Console.ReadLine());

    if (nbr > 0)
    {
        tabPos[iPos] = nbr;
        iPos++;
    }
    else
    {
        if (nbr < 0)
        {
            tabNeg[iNeg] = nbr;
            iNeg++;
        }
    }
} while (nbr != 0 ^ iPos < 10 ^ iNeg < 10);
Console.WriteLine("///////////////////////////// nombres positifs /////////////////////////////");
foreach (int i in tabPos)
{
    Console.WriteLine("  " + i);
}
Console.WriteLine("///////////////////////////// nombres negatifs /////////////////////////////");
foreach (int i in tabNeg)
{
    Console.WriteLine("  " + i);
}


