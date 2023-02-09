int cle;
double nir;
char theKey = Console.ReadKey().KeyChar;
do
{
    
    Console.WriteLine("sasir votre numero de secu");
    nir = double.Parse(Console.ReadLine());
    Console.WriteLine("sasir la cle de controle");
    cle = int.Parse(Console.ReadLine());

    if (nir == cle - (nir % cle))
    {
        Console.WriteLine("la saisi est correcte");
    }
}
while (theKey != "!");