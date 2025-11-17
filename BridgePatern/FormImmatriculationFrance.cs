namespace BridgePatern
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(FormulaireImpl impl) : base(impl)
        {
        }

        public override void controleSaisie()
        {
            Console.WriteLine("Contrôle des champs spécifiques " + "à la France");
            implantation.dessineTexte();
        }
    }
}