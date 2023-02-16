using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3GestionCommerciale
{
    internal class service
    {
        private int i = 0;
        private int num;
        private Commercial[] tabcomm;

        public int Num { get => num; set => num = value; }
        public Commercial[] Tabcomm { get => tabcomm; set => tabcomm = value; }
        public int I { get => i; set => i = value; }

        public service(int p1, Commercial[] p2)
        {
            Num = p1;
            Num = 0;
            Tabcomm = p2;
            Tabcomm = new Commercial [10];

            
        }

        public service()
        {

        }

        public void ajouterCom(Commercial c)
        {
            
            Tabcomm[I] = this.commercial;
            I++;
        }


    }
}
