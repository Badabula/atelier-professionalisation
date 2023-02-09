//badr aboulakjam IMC
decimal poids, taille, imc, poidscible;
char genre;

Console.WriteLine("quel est votre poids(kg)?");
poids = decimal.Parse(Console.ReadLine());

Console.WriteLine("quel est votre taille (cm)?");
taille = decimal.Parse(Console.ReadLine());

taille = taille / 100;
imc = poids / (taille * taille);
Console.WriteLine("votre imc est" + imc);




Console.WriteLine("quel est votre genre (H ou F)?");
genre = char.Parse(Console.ReadLine());

taille = taille * 100;

if (genre == 'H')
{
     poidscible = (taille - 100) * 90 / 100;
}
else
{
     poidscible = (taille - 100) * 85 / 100;
}

Console.WriteLine("poids ciblé=" + poidscible);
Console.WriteLine("kilos a perdre pour atteindre les poids cible=" + (poids - poidscible));
