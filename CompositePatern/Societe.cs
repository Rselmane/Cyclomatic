using System;
using System.Collections.Generic;

public abstract class Societe
{
    protected List<object> vehicules = new List<object>();

    public void ajouteVehicule()
    {
        vehicules.Add(new object());
    }

    public abstract string calculeCoutEntretiens();

    public abstract void ajouteFiliale(Societe societe);


}