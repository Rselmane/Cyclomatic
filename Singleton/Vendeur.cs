using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Vendeur
    {
        public string nom { get; set; }
       public string adresse { get; set; }

      public string email { get; set; }
        private static Vendeur _instance;
        private Vendeur()
        {
        }

        public static Vendeur GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Vendeur();
            }
            return _instance;
        }
        public void affiche()
        {
            Console.WriteLine("Nom : " + nom);
        }
    }
}
