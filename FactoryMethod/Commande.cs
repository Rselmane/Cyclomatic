using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  abstract class Commande
    {
        public  abstract void paye();
        public abstract bool valide();
    }
}
