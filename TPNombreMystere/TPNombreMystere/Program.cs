Random rnd = new Random();
int myst, num, turn;
turn = 0;

myst = rnd.Next(1,100);
Console.WriteLine("devinez le nombre mystere entre 1 et 100");

do
{
	Console.WriteLine("saisir le nombre");
    num = int.Parse(Console.ReadLine());

	if (num < 0 || num > 100)
	{
		Console.WriteLine("erreur de saisi");
	}
	else
	{
		if (num < myst)
		{
			Console.WriteLine("le nombre mystere est plus grand");
		}
		if (num > myst)
		{
				Console.WriteLine("le nombre mystere est plus petit");
		}
		
	}
	turn += 1;
}
while (num != myst);
{
    Console.WriteLine("FELICITATIONS vous avez trouvée le nombre mystere");
	Console.WriteLine("nombre d'essais = " + turn);
}