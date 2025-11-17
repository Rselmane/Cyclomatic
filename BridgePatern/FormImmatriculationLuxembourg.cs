using BridgePatern;

internal class FormImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormImmatriculationLuxembourg(FormulaireImpl impl) : base(impl)
    {
    }

   protected override bool controleSaisie(string v)
    {
        Console.WriteLine("Contrôle des champs spécifiques " + "au luxembourg");
        return true;
    }
}