namespace ProjetoAguas.UserControls
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UcContracts : UserControl
    {
        public UcContracts() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region DataGridView

        // Atualiza a datagridview com os dados que correspondem a cada coluna 

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

        // Cria as colunas da datagridview, na mesma ordem do método "AtualizaDataGriewContracts"

        private void UcContracts_Load(object sender, EventArgs e)
        {
            DataGriewContracts.Columns.Add("colID", "IdContract");
            DataGriewContracts.Columns.Add("colClient", "Client");
            DataGriewContracts.Columns.Add("colContractType", "Contract Type");
            DataGriewContracts.Columns.Add("colPaymentType", "Payment Type");
            DataGriewContracts.Columns.Add("colContractDate", "Contract Date");
            DataGriewContracts.Columns.Add("colAddress", "Address");
            DataGriewContracts.Columns.Add("colPostalCode", "Postal Code");

            ComboBoxs();
            AtualizaDataGriewContracts();
            LimpaCampos();
        }

        // Ao clicar numa linha da datagridview, os dados retornam aos seus campos

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

        // Preenche a combobox do nome dos clientes com uma pesquisa à base de dados
        // Preenche tanto a combobox do tipo de contrato quanto do tipo de pagamento de forma manual

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

        // Ao selecionar um cliente na combobox do nome dos clientes, de forma automática, a textbox
        // da morada e do código postal são preenchidas de acordo com o Id associado ao cliente

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dadosCliente = from Clientes
                                   in dc.Clientes
                                   where Clientes.Nome == cbClients.Text
                                   select Clientes;

                foreach(Clientes c in dadosCliente)
                {
                    txtAddress.Text = c.Morada;
                    mtxtbPostalCode.Text = c.CodigoPostal;
                }
            }
            catch(Exception ex) {  MessageBox.Show(ex.Message); }
        }

        #endregion

        #region Buttons

        // Insere os dados na datagridview

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

        // Atualiza os dados selecionados da datagridview

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

        // Elimina um contrato selecionado

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

        // Ao clicar no botão reset, todos os campos serão limpos

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        #endregion

        #region LimpaCampos

        // Método que limpa todos os campos 

        private void LimpaCampos()
        {
            txtID.ResetText();
            cbClients.ResetText();
            cbContractType.ResetText();
            txtAddress.ResetText();
            cbPaymentType.ResetText();
            mtxtbPostalCode.ResetText();
            dtpContractDate.ResetText();
        }



        #endregion

        #region Validações

        private void cbClients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (cbClients.Text.Length == 0)
                {
                    MessageBox.Show("Required field! Choose an option from the comboBox.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    cbContractType.Focus();
            }
        }

        private void cbContractType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbContractType.Text.Length == 0)
                {
                    MessageBox.Show("Required field! Choose an option from the comboBox.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    cbPaymentType.Focus();
            }
        }

        private void cbPaymentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbContractType.Text.Length == 0)
                {
                    MessageBox.Show("Required field! Choose an option from the comboBox.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    cbPaymentType.Focus();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            foreach (char Morada in txtAddress.Text)
            {
                if (!(char.IsLetter(Morada) || char.IsDigit(Morada) || Morada == ' '))
                {
                    MessageBox.Show("Heads up! Only enter letters, digits and spaces.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddress.Clear();
                    break;
                }
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtAddress.Text.Length == 0)
                {
                    MessageBox.Show("Required field! Fill in your address.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtAddress.Text.Length > 100)
                {
                    MessageBox.Show("The number of characters cannot exceed 100!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddress.Clear();
                }
                else
                    dtpContractDate.Focus();
                e.Handled = true; // Assinala que o evento já foi executado e não emite som
            }
        }

        private void mtxtbPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (mtxtbPostalCode.Text.Length != 8)
                {
                    MessageBox.Show("Heads up! Enter the 8 numbers of your Postal code.",
                         "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtbPostalCode.Clear();
                }
            }
        }

        #endregion
    }
}