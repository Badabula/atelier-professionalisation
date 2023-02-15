using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3GestionCommerciale
{
    internal class categorie
    {
        private string codecategorie;
        private string libcategorie;

        public string Codecategorie { get => codecategorie; set => codecategorie = value; }
        public string Libcategorie { get => libcategorie; set => libcategorie = value; }

        public categorie(string codecategorie, string libcategorie)
        {
            Codecategorie = codecategorie;
            Libcategorie = libcategorie;
        }

        public categorie()
        {

        }

        public override string ToString()
        {
            return "code :" + this.Codecategorie + "\n" + "libellé " + this.Libcategorie;
        }
    }
}
