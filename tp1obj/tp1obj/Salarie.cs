using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1obj
{
    internal class Salarie
    {
        private int matricule;
        private string nom;
        private string prenom;
        private double salaire;
        private double tauxCS;

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public double TauxCS { get => tauxCS; set => tauxCS = value; }
        
        public Salarie(int mat, string nom, string prenom, double salaire, double tauxcs)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Salaire = salaire;
            this.TauxCS = tauxcs;
            this.Matricule = mat;
        }

        public double CalculersalaireNet()
        {
            return this.Salaire - this.Salaire * this.TauxCS;
        }
    }

   


}
