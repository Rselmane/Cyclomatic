using BridgePatern;

public class FormAppletImpl : FormulaireImpl
{
    public override void dessineTexte()
    {
        Console.WriteLine("[HTML] Texte dessiné");
    }

    public override bool gereZoneSaisie()
    {
        Console.WriteLine("[HTML] Zone de saisie gérée");
        return true;
    }
}