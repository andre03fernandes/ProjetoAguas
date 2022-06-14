namespace ProjetoAguas
{
    using System;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using UserControls;

    public partial class SendEmail : Form
    {
        #region Variáveis

        // Variáveis que permitem passar do UserControl para a fatura

        public string Date, Name, PaymentType, InvoiceDate, MonthlyConsume, Amount;

        private Bitmap memory; // Bitmap - dados de pixel de uma imagem de elementos gráficos e seus atributos

        #endregion

        #region Data

        // Apresenta o ano em que estamos

        public SendEmail()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("yyyy");
        }

        #endregion

        #region Métodos

        // Método que permite fazer uma print da fatura e guardar em pdf

        private void Print(Panel p)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panelPrint = p;
            getprintArea(p);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.ShowDialog();
        }

        // Define a área a partir do bitmap que irá tirar o print

        private void getprintArea(Panel p)
        {
            memory = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(memory, new Rectangle(0, 0, p.Width, p.Height));
        }

        #endregion

        #region Propriedades do form (Eventos, load, printDocument...)

        // Desenho da fatura

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagarea = e.PageBounds;
            e.Graphics.DrawImage(memory, (pagarea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        // Ao ser clicado abre o form que compõe o email

        private void picMail_Click(object sender, EventArgs e)
        {
            AttachPDF ap = new AttachPDF();
            ap.ShowDialog();
        }

        // Produz a fatura

        private void picPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        // Ao ser clicado fecha o form e volta ao anterior

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            UcInvoices New = new UcInvoices();
            New.Show();
        }

        // Ao passar o rato em cima do botão irá aparecer um PDF como mouseHover

        private void picPrint_MouseHover(object sender, EventArgs e)
        {
            toolTipPrint.SetToolTip(picPrint, "PDF");
        }

        // Passagem de informação de um form para o outro

        private void SendEmail_Load(object sender, EventArgs e)
        {
            lblDate.Text = Date;
            lblName.Text = Name;
            lblPaymentType.Text = PaymentType;
            lblInvoiceDate.Text = InvoiceDate;
            lblMonthConsume.Text = MonthlyConsume + "€";
            lblAmount.Text = Amount + "€";
        }

        #endregion
    }
}