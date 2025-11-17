namespace DecoratorPatern
{
    public class MarqueDecorateur : Decorateur
    {
        public MarqueDecorateur(ComposantGraphiqueVehicule composant) : base(composant)
        {
        }

        public override void affiche()
        {
            base.affiche();
            afficheInfosTechnique("Marque : Renault");
        }

        public void afficheInfosTechnique(string infos)
        {
            return;
        }
    }
}