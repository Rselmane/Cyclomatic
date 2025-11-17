using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern
{
    public  abstract class Document
    {
        public string? contenu;


        protected Document()
        {
        }

        public abstract void setContenu(string content);
        public abstract void dessine();
        public abstract void imprime();
    }
}
