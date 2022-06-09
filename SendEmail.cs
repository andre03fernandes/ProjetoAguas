namespace ProjetoAguas
{
    using UserControls;
    using System;
    using System.Windows.Forms;
    using System.Drawing.Printing;
    using System.Drawing;

    public partial class SendEmail : Form
    {
        public string Date, Name, PaymentType, InvoiceDate, MonthlyConsume, Amount;

        private Bitmap memory;

        public SendEmail()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("yyyy");
        }

        private void Print (Panel p)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panelPrint = p;
            getprintArea(p);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagarea = e.PageBounds;
            e.Graphics.DrawImage(memory, (pagarea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void picMail_Click(object sender, EventArgs e)
        {
            AttachPDF ap = new AttachPDF();
            ap.ShowDialog();
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void getprintArea(Panel p)
        {
            memory = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(memory, new Rectangle(0, 0, p.Width, p.Height));
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            UcInvoices New = new UcInvoices();
            New.Show();
        }

        private void picPrint_MouseHover(object sender, EventArgs e)
        {
            toolTipPrint.SetToolTip(picPrint, "PDF");
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {
            lblDate.Text = Date;
            lblName.Text = Name;
            lblPaymentType.Text = PaymentType;
            lblInvoiceDate.Text = InvoiceDate;
            lblMonthConsume.Text = MonthlyConsume;
            lblAmount.Text = Amount;
        }
    }
}