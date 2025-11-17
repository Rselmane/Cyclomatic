using BridgePatern;

internal class FormImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormImmatriculationLuxembourg(FormulaireImpl impl) : base(impl)
    {
    }

    public override void controleSaisie()
    {
        Console.WriteLine("Contrôle des champs spécifiques " + "au luxembourg");

        implantation.dessineTexte();
    }
}