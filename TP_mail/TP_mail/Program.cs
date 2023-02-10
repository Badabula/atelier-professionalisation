string email;
int Narob = 0;

Console.WriteLine("saisir adresse mail:");
email = Console.ReadLine();

email = email.Trim();
email = email.ToLower();

foreach (char charactere in email)
{

}

if (email.Length < 26)
{
    Console.WriteLine("26 characters min necessaires");
}

string[] emailTab = email.Split("@");

if (emailTab.Length != 2) ;
{
    Console.WriteLine("erreur @");
}

for

