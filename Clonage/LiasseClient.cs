using System;
using System.Collections.Generic;
using Clonage; 

public class LiasseClient : Liasse
{


    public LiasseClient(string informations)
    {
        Documents = new List<Document>();
        LiasseVierge laLiasseVierge = LiasseVierge.Instance();
        IList<Document> documentsVierges = laLiasseVierge.Documents;

        foreach (Document document in documentsVierges)
        {
            Document copieDocument = document.duplique();
            copieDocument.remplit(informations);
            Documents.Add(copieDocument);
        }
    }

    public void affiche()
    {
        foreach (Document document in Documents)
            document.affiche();
    }

    public void imprime()
    {
        foreach (Document document in Documents)
            document.imprime();
    }
}
