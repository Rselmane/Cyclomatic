using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CommandeCredit : Commande
    {
        private double montant;

        public CommandeCredit(double montant)
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
