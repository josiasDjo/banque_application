using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using banque_application.disign;

namespace banque_application
{   
    public partial class etatDeSorti
    {
        //depot dp = new depot();
        public string nomEtat;
        public string prenomEtat;
        public string dateToDayEtat;
        public decimal montantEtat;
        public string idTransactionEtat;
        public string dateToDayAnne;
        public int idFacture;
        private string filePath;
        public string adresseEtat;
        public string phoneEtat;
        public string typeTransEtat;
        public void Main()
        {
            idFacture++;
            // Variables
            DateTime currentDate = DateTime.Now;
            dateToDayAnne = currentDate.ToString("yyyy");
            string numFacture = dateToDayAnne + idFacture;
            decimal amount = montantEtat;
            string invoiceDate = dateToDayEtat;

            NomOut.Text = nomEtat;
            PrenomOut.Text = prenomEtat;
            adresseOut.Text = adresseEtat;
            phoneOut.Text = phoneEtat;
            factureN.Text = numFacture;
            transactionId.Text = idTransactionEtat;
            typeTrans.Text = typeTransEtat;
            montantTot.Text = montantEtat.ToString();

            dateOut.Text = dateToDayEtat;
        }

        static void PrintPdf(string filePath)
        {

        }
    }
}


