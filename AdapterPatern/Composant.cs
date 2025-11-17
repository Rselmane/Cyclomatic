using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatern
{
    public class ComposantPdf
    {
        public void pdfFixeContenu(string contenu)
        {
            Console.WriteLine($"[ComposantPdf] Contenu défini : {contenu}");
        }

        public void pdfPrepareAffichage()
        {
            Console.WriteLine("[ComposantPdf] Préparation de l'affichage PDF...");
        }

        public void pdfRafraichit()
        {
            Console.WriteLine("[ComposantPdf] Rafraîchissement de l'affichage PDF...");
        }

        public void pdfTermineAffichage()
        {
            Console.WriteLine("[ComposantPdf] Affichage PDF terminé.");
        }

        public void pdfEnvoieImprimante()
        {
            Console.WriteLine("[ComposantPdf] Envoi du document PDF à l'imprimante...");
        }
    }
}