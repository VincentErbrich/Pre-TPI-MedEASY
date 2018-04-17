using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using Invoicer.Services;
using Invoicer.Models;
using Invoicer.Helpers;

namespace MedEasy
{
    /*
     * Auteur : Vetrivel D
     * Adaptée pour MedEasy par : Vincent Erbrich
     * Classe trouvée sur youtube : https://www.youtube.com/watch?v=7KutIZPKO18
     */
    public partial class Invoice_Generator
    {
        public void GeneratePdf(int idconsultation)
        {
            new InvoicerApi(SizeOption.A4, OrientationOption.Landscape, "CHF")
            .TextColor("#CC0000")
            .BackColor("#FFD6CC")
            .Items(new List<ItemRow> {
                ItemRow.Make("Nexus 6", "Midnight Blue", (decimal)1, 20, (decimal)166.66, (decimal)199.99),
                ItemRow.Make("24 Months (£22.50pm)", "100 minutes, Unlimited texts, 100 MB data 3G plan with 3GB of UK Wi-Fi", (decimal)1, 20, (decimal)360.00, (decimal)432.00),
                ItemRow.Make("Special Offer", "Free case (blue)", (decimal)1, 0, (decimal)0, (decimal)0),
            })
            .Totals(new List<TotalRow> {
                TotalRow.Make("Sub Total", (decimal)526.66),
                TotalRow.Make("VAT @ 20%", (decimal)105.33),
                TotalRow.Make("Total", (decimal)631.99, true),
             })
            .Details(new List<DetailRow> {
                DetailRow.Make("INFORMATIONS De payement", "Make all cheques payable to Vodafone UK Limited.", "", "If you have any questions concerning this invoice, contact our sales department at sales@vodafone.co.uk.", "", "Thank you for your business.")
            })
            .Footer("http://www.vodafone.co.uk")
            .Save();
        }
    }
}
