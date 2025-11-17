using System;
using System.Collections.Generic;

public abstract class Societe
{
    protected List<object> vehicules = new List<object>();
    protected List<Societe> filiales = new List<Societe>();

    public void ajouteVehicule()
    {
        vehicules.Add(new object());
    }

    public abstract string calculeCoutEntretiens();

    public void ajouteFiliale(Societe societe)
    {
        filiales.Add(societe);
    }

   
}