using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    public abstract class FormulaireImmatriculation
    {
        protected FormulaireImpl implantation;

        protected FormulaireImmatriculation(FormulaireImpl impl)
        {
            this.implantation = impl;
        }

        public void affiche()
        {
            Console.WriteLine("Affichage du formulaire");
        }

        public void genereDocument()
        {
            Console.WriteLine("Génération du document");
        }

        public bool gereSaisie()
        {
            return implantation.gereZoneSaisie();
        }

        public abstract void controleSaisie();
    }
}