using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tp1_cs_ex2
{
    internal class Fournisseur
    {
        private int idF;
        private string nomF;
        private string adresseF;

        public int IdF { get => idF; set => idF = value; }
        public string NomF { get => nomF; set => nomF = value; }
        public string AdresseF { get => adresseF; set => adresseF = value; }

        public Fournisseur(int idF, string nomF, string adresseF)
        {
            this.IdF = idF;
            this.NomF = nomF;
            this.AdresseF = adresseF;
        }

        public Fournisseur()
        {

        }

        public void Infofournisseur()
        {
            Console.WriteLine("Fournisseur : ");
            Console.WriteLine("idf : " + this.IdF);
            Console.WriteLine("nom : " + this.NomF);
            Console.WriteLine("Adresse : " + this.AdresseF);
        }
    }

}
