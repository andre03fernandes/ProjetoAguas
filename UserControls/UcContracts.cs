using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoAguas.UserControls
{
    public partial class UcContracts : UserControl
    {
        public UcContracts() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region DataGridView

        public void AtualizaDataGriewContracts() // Preenchimento da datagridview dos clientes
        {
            int linha = 0;

            DataGriewContracts.Rows.Clear();

            var listaContratos = from contrato in dc.Contratos select contrato;

            foreach (Contratos contrato in listaContratos)
            {
                DataGridViewRow registo = new DataGridViewRow();
                DataGriewContracts.Rows.Add(registo);

                DataGriewContracts.Rows[linha].Cells[0].Value = contrato.IdContrato;

                var listaClientes = (from Clientes in dc.Clientes
                                     where Clientes.IdCliente == contrato.IdCliente
                                     select Clientes).Single();

                DataGriewContracts.Rows[linha].Cells[1].Value = listaClientes.Nome;

                DataGriewContracts.Rows[linha].Cells[2].Value = contrato.TipoContrato;
                DataGriewContracts.Rows[linha].Cells[3].Value = contrato.TipoPagamento;
                DataGriewContracts.Rows[linha].Cells[4].Value = contrato.DataContrato;
                DataGriewContracts.Rows[linha].Cells[5].Value = listaClientes.Morada;
                DataGriewContracts.Rows[linha].Cells[6].Value = listaClientes.CodigoPostal;

                linha++;
            }
        }

        private void UcContracts_Load(object sender, EventArgs e)
        {
            DataGriewContracts.Columns.Add("colID", "IdContrato");
            DataGriewContracts.Columns.Add("colClient", "Client");
            DataGriewContracts.Columns.Add("colContractType", "Contract Type");
            DataGriewContracts.Columns.Add("colPaymentType", "Payment Type");
            DataGriewContracts.Columns.Add("colContractDate", "Contract Date");
            DataGriewContracts.Columns.Add("colAddress", "Address");
            DataGriewContracts.Columns.Add("colPostalCode", "Postal Code");

            ComboBoxs();
            AtualizaDataGriewContracts();
        }

        private void DataGriewContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewContracts.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                cbClients.Text = row.Cells["colClient"].Value.ToString();
                dtpContractDate.Text = row.Cells["colContractDate"].Value.ToString();
                cbContractType.Text = row.Cells["colContractType"].Value.ToString();
                cbPaymentType.Text = row.Cells["colPaymentType"].Value.ToString();
                txtAddress.Text = row.Cells["colAddress"].Value.ToString();
                mtxtbPostalCode.Text = row.Cells["colPostalCode"].Value.ToString();
            }
        }

        #endregion

        #region ComboBoxs

        private void ComboBoxs()
        {
            var listaClientes = from Clientes in dc.Clientes select Clientes;

            cbClients.DataSource = listaClientes;
            cbClients.DisplayMember = "Nome";

            cbContractType.Items.Add("Doméstico");
            cbContractType.Items.Add("Agrícola");
            cbContractType.Items.Add("Comércio");
            cbContractType.Items.Add("Industrial");

            cbPaymentType.Items.Add("Multibanco");
            cbPaymentType.Items.Add("Transferência");
        }

        #endregion

        #region Buttons

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Clientes NomeCliente = (Clientes)cbClients.SelectedItem;
            string ContractType = Convert.ToString(cbContractType.SelectedItem);
            string Morada = txtAddress.Text;
            string PaymentType = Convert.ToString(cbPaymentType.SelectedItem);
            string PostalCode = mtxtbPostalCode.Text;
            string ContractDate = dtpContractDate.Text;

            Contratos c = new Contratos
            {
                IdCliente = NomeCliente.IdCliente,
                TipoContrato = ContractType,
                Morada = Morada,
                TipoPagamento = PaymentType,
                CodigoPostal = PostalCode,
                DataContrato = ContractDate
            };

            dc.Contratos.InsertOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewContracts();
            LimpaCampos();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            Clientes NomeCliente = (Clientes)cbClients.SelectedItem;
            string ContractType = Convert.ToString(cbContractType.SelectedItem);
            string Morada = txtAddress.Text;
            string PaymentType = Convert.ToString(cbPaymentType.SelectedItem);
            string PostalCode = mtxtbPostalCode.Text;
            string ContractDate = dtpContractDate.Text;

            Contratos c = (from Contratos in dc.Contratos
                           where Contratos.IdContrato == Id
                           select Contratos).First();

            c.Clientes = NomeCliente;
            c.TipoContrato = ContractType;
            c.Morada = Morada;
            c.TipoPagamento = PaymentType;
            c.CodigoPostal = PostalCode;
            c.DataContrato = ContractDate;

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewContracts();
            LimpaCampos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contratos c = (from Contratos
                           in dc.Contratos
                           where Contratos.IdContrato == int.Parse(txtID.Text)
                           select Contratos).First();

            dc.Contratos.DeleteOnSubmit(c);


            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewContracts();
            LimpaCampos();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        #endregion

        #region LimpaCampos

        private void LimpaCampos()
        {
            txtAddress.ResetText();
            mtxtbPostalCode.ResetText();
            dtpContractDate.ResetText();
        }

        #endregion

    }
}