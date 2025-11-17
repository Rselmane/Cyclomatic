using DecoratorPatern;
using System;

public class VueCatalogue
{
  public static void Main()
  {
    VueVehicule vueVehicule = new VueVehicule();
        vueVehicule.affiche();
        ModeleDecorateur modeleDecorateur = new
      ModeleDecorateur(vueVehicule);
    MarqueDecorateur marqueDecorateur = new
      MarqueDecorateur(modeleDecorateur);
    marqueDecorateur.affiche();
  }
}
