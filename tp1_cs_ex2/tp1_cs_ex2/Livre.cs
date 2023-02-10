using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tp1_cs_ex2
{
    internal class Livre
    {
        private string titre;
        private string annee;
        private int nPage;
        private int prix;
        private Auteur monAuteur;
        private Fournisseur monFournisseur;

        public string Titre { get => titre; set => titre = value; }
        public string Annee { get => annee; set => annee = value; }
        public int NPage { get => nPage; set => nPage = value; }
        public int Prix { get => prix; set => prix = value; }
        internal Auteur MonAuteur { get => monAuteur; set => monAuteur = value; }
        internal Fournisseur MonFournisseur { get => monFournisseur; set => monFournisseur = value; }

        public Livre(string titre, string annee, int nPage, int prix)
        {
            this.Titre = titre;
            this.Annee = annee;
            this.NPage = nPage;
            this.Prix = prix;
            this.MonAuteur = monAuteur;
            this.MonFournisseur = monFournisseur;
        }

        public Livre()
        {
            
        }

        public void InfoLivre()
        {
            Console.WriteLine("Livre : ");
            Console.WriteLine("Titre : " + this.Titre);
            Console.WriteLine("Année : " + this.Annee);
            Console.WriteLine("nombre de pages : " + this.NPage);
            Console.WriteLine("prix : " + this.Prix);
        }   



    }
}
