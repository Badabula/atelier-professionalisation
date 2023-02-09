namespace ClientDll
{
    public class Client
    {
        private int numero;
        private string nom;
        private double cA;
        private int categorie;

        public int Numero { get => numero; }
        public string Nom { get => nom; }
        public double CA { get => CA; }
        public int Categorie { get => categorie; }

        public Client(int numero, string nom, double cA, int categorie)
        {

            if (categorie != 1 & categorie != 2 & categorie != 3)
            {
                Console.WriteLine("la categorie doit etre entre 1, 2 ou 3");
            }
        }

        public void afficher()
        {
            Console.WriteLine("on realise une chifre d'affaires de " + CA + "euros avec le client " + Nom + " de categorie " + Categorie);   
        }
    }
}