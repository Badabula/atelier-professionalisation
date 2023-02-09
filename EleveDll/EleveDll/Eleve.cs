namespace EleveDll
{
    public class Eleve
    {
        

        private string nom;
        private float note_oral;
        private float note_ecrit;

        public string Nom { get => nom; set => nom = value; }
        public float Note_oral { get => note_oral; set => note_oral = value; }
        public float Note_ecrit { get => note_ecrit; set => note_ecrit = value; }

        public Eleve(string Nom, float Note_oral, float Note_ecrit)
        {
            this.Nom = Nom;
            this.Note_oral = Note_oral; 
            this.Note_ecrit = Note_ecrit;  
           
        }

        public Eleve()
        {

        }



        public float Moyenne()
        {
            return (2 * this.Note_oral + this.Note_ecrit) / 3;
        }

        public void Afficher()
        {
            Console.WriteLine("nom eleve: " + this.Nom + "\nsa moyenne est de: " + this.Moyenne());
        }

        public override string ToString()
        {
            return this.Nom + "." + this.Note_ecrit.ToString() + "." + this.Note_oral.ToString();
        }

        
        
    }

    
}