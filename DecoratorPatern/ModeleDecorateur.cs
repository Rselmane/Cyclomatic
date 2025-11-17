using DecoratorPatern;

public class ModeleDecorateur : Decorateur
{
    public ModeleDecorateur(ComposantGraphiqueVehicule composant) : base(composant)
    {
    }

    public override void affiche()
    {
        base.affiche();
        afficheLogo();


    }
    public void afficheLogo()
    {
        Console.WriteLine("Affichage du logo du constructeur");
    }   
}