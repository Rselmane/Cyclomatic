using AdapterPatern;

public class DocumentPdf : Document
{
    public ComposantPdf outilPdf;

    public DocumentPdf()
    {
        this.outilPdf = new ComposantPdf();
    }

    public override void setContenu(string content)
    {
        outilPdf.pdfFixeContenu(content);
    }

    public override void dessine()
    {
        outilPdf.pdfPrepareAffichage();
        outilPdf.pdfRafraichit();
        outilPdf.pdfTermineAffichage();
    }

    public override void imprime()
    {
        outilPdf.pdfEnvoieImprimante();
    }
}