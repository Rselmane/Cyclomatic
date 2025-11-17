public class SocieteSansFiliale : Societe
{
    public override void ajouteFiliale(Societe societe)
    {
        return;
    }

    public override string calculeCoutEntretiens()
    {
       return "Calcul du coût des entretiens pour une société sans filiale.";
    }
}