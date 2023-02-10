using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tp1_cs_ex2
{
    internal class Auteur
    {
        private int idA;
        private string nomA;
        private string prenomA;

        public int IdA { get => idA; set => idA = value; }
        public string NomA { get => nomA; set => nomA = value; }
        public string PrenomA { get => prenomA; set => prenomA = value; }

        public Auteur(int idA, string nomA, string prenomA)
        {
            this.IdA = idA;
            this.NomA = nomA;
            this.PrenomA = prenomA;     
        }

        public Auteur()
        {

        }

        public void InfoAuteur()
        {
            Console.WriteLine("Auteur : " + this.NomA + " " + this.PrenomA + " ID : " + this.IdA);
        }
    }
}
