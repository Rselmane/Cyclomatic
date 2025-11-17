namespace BridgePatern
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(FormulaireImpl impl) : base(impl)
        {
        }

        public override void controleSaisie()
        {
            throw new NotImplementedException();
        }
    }
}