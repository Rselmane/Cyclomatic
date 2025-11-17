public class SocieteMere : Societe
{
    protected List<Societe> filiales = new List<Societe>();

    public override string calculeCoutEntretiens()
    {
        string ret= "";
        Console.WriteLine("Calcul des couts d'entretiens de la societe mere");
        foreach (Societe soc in filiales)
        {
           ret+= soc.calculeCoutEntretiens();
        }
        return ret;


    }
    public override void ajouteFiliale(Societe societe)
    {
        filiales.Add(societe);
    }

   
}