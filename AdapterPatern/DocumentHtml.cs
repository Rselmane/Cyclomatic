using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern
{
    public class DocumentHtml : Document
    {
        public DocumentHtml()
        {
        }

        public override void setContenu(string? content)
        {
            this.contenu = content;
        }

        protected string getContenu()
        {
            return this.contenu;
        }

        public override void dessine()
        {
            Console.WriteLine($"[HTML] Dessin du document HTML : {getContenu()}");
        }

        public override void imprime()
        {
            Console.WriteLine($"[HTML] Impression du document HTML : {getContenu()}");
        }
    }
}