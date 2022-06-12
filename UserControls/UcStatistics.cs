namespace ProjetoAguas.UserControls
{
    using System.Windows.Forms;
    using System.Linq;

    public partial class UcStatistics : UserControl
    {
        public UcStatistics()
        {
            InitializeComponent();
            /*Earnings();*/
            NumberContracts();
            NumberClients();
            NumberInvoices();
        }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region Métodos

        // Número de ganhos da empresa

        private void Earnings()
        {
            //var earn = from Consumos in dc.Consumos select Consumos;
            //lblEarnings.Text = earn.Sum(e => e.ConsumoTotal);
        }

        // Número de contratos da empresa

        private void NumberContracts()
        {
            var cont = from Contratos in dc.Contratos select Contratos;
            lblNumContracts.Text = cont.Count().ToString();
        }

        // Número de clientes da empresa

        private void NumberClients()
        {
            var cli = from Clientes in dc.Clientes select Clientes;
            lblNumClients.Text = cli.Count().ToString();
        }

        // Número de faturas da empresa

        private void NumberInvoices()
        {
            var invoice = from Faturas in dc.Faturas select Faturas;
            lblNumInvoices.Text = invoice.Count().ToString();
        }

        #endregion
    }
}