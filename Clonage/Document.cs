using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonage
{
    public abstract class Document
    {

        public Document duplique()
        {
            return (Document)MemberwiseClone();
        }

        public abstract void imprime();
        public abstract string affiche();
        public void remplit(string information)
        {

        }
}
 
}
