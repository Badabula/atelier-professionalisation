decimal pu, port, rem, tot, pap;
int Qtcom;

Console.WriteLine("saisir prix");
pu = decimal.Parse(Console.ReadLine());

Console.WriteLine("saisir qunatité");
Qtcom = int.Parse(Console.ReadLine());

tot = pu * Qtcom;

if (tot > 500)
{
    port = 0;
}
else
{
    port = tot * 2 / 100;
}

if (tot > 1000)
{
    rem = tot *10 / 100;
}
else
{
    if (tot > 200)
    {
        rem = tot * 10 / 100;
    }
    else
    {
        rem = 0;
    }
}

pap = tot + port - rem;
Console.WriteLine("le prix a payer est de " + pap + "EUR");
Console.WriteLine("dont frais de port " + port + "EUR");
Console.WriteLine("la remise est de " + rem + "EUR");
