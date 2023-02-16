using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3GestionCommerciale
{
    internal class service
    {
        private int num;
        private string[] tabcomm;

        public int Num { get => num; set => num = value; }
        public string[] Tabcomm { get => tabcomm; set => tabcomm = value; }

        public service(int p1, string[] p2)
        {
            Num = p1;
            Num = 0;
            Tabcomm = p2;
            Tabcomm = new string [10];

            
        }
    }
}
