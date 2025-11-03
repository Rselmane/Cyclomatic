using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class TestVendeur
    {

        public static void Test()
        {

            Vendeur leVendeur = Vendeur.GetInstance();
            leVendeur.nom = "Vendeur Auto";
            leVendeur.adresse = "Paris";
            leVendeur.email = "vendeur@vendeur.com";
            affiche();
        }
  public static void affiche()
        {
            Vendeur leVendeur = Vendeur.GetInstance();
            leVendeur.affiche();
        }
    }

  }

