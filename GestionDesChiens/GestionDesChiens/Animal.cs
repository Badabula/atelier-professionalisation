using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesChiens
{
    internal class Animal
    {
        private int numero;
        private string nom;
        private string race;
        private double poids;
        private int age;
        private int type;

        public int Numero { get => numero; set => numero = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Race { get => race; set => race = value; }
        public double Poids { get => poids; set => poids = value; }
        public int Age { get => age; set => age = value; }
        public int Type { get => type; set => type = value; }

        public Animal(int Numero, string Nom, string Race, double Poids, int Age, int Type)
        {
            this.numero = Numero;
            this.nom = Nom;
            this.race = Race;
            this.Poids = Poids;
            this.Age = Age;
            this.Type = Type;
        }

        public Animal()
        {

        }

        public double CalculerRation()
        {
            double taux;
            double ration;
                if (this.Type == 1)
            {
                taux = 2.2;
            }
                else if (this.Type == 2)
            {
                taux = 2.3;
            }
                else
            {
                taux = 3.5;
            }

            return this.Age * this.Poids * taux;

        }

        public void Affiche()
        {
            Console.WriteLine("l'animal " + this.Nom + " (numero " + this.Numero + ") " + " est un " + this.Race + " (" + this.type + ") " + "qui pese " + this.Poids + " et a " + this.Age + " ans. sa ration journaliere est de " + this.CalculerRation());   
        }
    }

}
