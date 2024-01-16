using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ServerSide.Reports
{
    public partial class ReceiptReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReceiptReport()
        {
            InitializeComponent();
        }

        private void ReceiptReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
