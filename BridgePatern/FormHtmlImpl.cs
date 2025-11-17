using System;
using BridgePatern;

public class FormHtmlImpl : FormulaireImpl
{
    public override void dessineTexte()
    {
        Console.WriteLine("[HTML] Dessin du texte en HTML");
    }

    public override bool gereZoneSaisie()
    {
        Console.WriteLine("[HTML] Gestion de la zone de saisie HTML");
        return true;
    }
}