using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meno_constructor
{
    // nombre de la clase
    internal class Menoclass
    {
        //campo propiedades, como es
        private int n1;
        private int n2;

        //constructor
        public Menoclass (int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //metodo, accion, lo que hace
        public int menos()
        {
            return (n1 - n2);

        }
    }
}
