using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonage
{
    public class Liasse
    {
        private List<Document> _documents;

        public List<Document> Documents { get => _documents; set => _documents = value; }
    }
}
