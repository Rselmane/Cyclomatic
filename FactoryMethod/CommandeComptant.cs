using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommandeComptant : Commande
    {
        private double montant;

        public CommandeComptant(double montant)
        {
            this.montant = montant;
        }

        public override void paye()
        {
            throw new NotImplementedException();
        }

        public override bool valide()
        {
            throw new NotImplementedException();
        }
    }
}
