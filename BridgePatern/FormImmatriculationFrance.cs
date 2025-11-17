namespace BridgePatern
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(FormulaireImpl impl) : base(impl)
        {
        }

        protected override bool controleSaisie(string plaque)
        {
            Console.WriteLine("Contrôle des champs spécifiques " + "à la France");
          return true;
        }
    }
}