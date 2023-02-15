using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3GestionCommerciale
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaisaance;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaisaance { get => anneeNaisaance; set => anneeNaisaance = value; }

        public Commercial(string nom, string prenom, int anneeNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.AnneeNaisaance = anneeNaissance;
        }   

        public Commercial()
        {

        }

        public int CalculAge()
            {
            int resultat = DateTime.Today.Year - anneeNaisaance;
            
            return resultat;
            }

        public override string ToString()
        {
            return "nom: " + this.Nom + "\n" + "prenom: " + this.Prenom + "\n" + " annee de naissance: " + this.AnneeNaisaance + "\n" + "ce commercial a donc :" + this.CalculAge() +" "+ "ans." ;
        }

        public string compare(Commercial c)
        {
           int CompVal =  this.Nom.CompareTo(c.Nom);

            if (CompVal == 0)
            {
                return "les noms des deux commercial sont identiques";
            }
            else
            {
                return "le noms des deux commercial sont differents";
            }
        }

        
    }
}
