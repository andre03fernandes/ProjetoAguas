namespace ProjetoAguas.UserControls
{
    using System.Windows.Forms;
    using System;
    using System.Linq;

    public partial class UcClients : UserControl
    {
        public UcClients() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region DataGridView

        public void AtualizaDataGriewClients() // Preenchimento da datagridview dos clientes
        {
            int linha = 0;

            DataGriewClients.Rows.Clear();

            var listaClientes = from cliente in dc.Clientes select cliente;

            foreach (Clientes cliente in listaClientes)
            {
                DataGridViewRow registo = new DataGridViewRow();
                DataGriewClients.Rows.Add(registo);

                DataGriewClients.Rows[linha].Cells[0].Value = cliente.IdCliente;
                DataGriewClients.Rows[linha].Cells[1].Value = cliente.Nome;
                DataGriewClients.Rows[linha].Cells[2].Value = cliente.Telefone;
                DataGriewClients.Rows[linha].Cells[3].Value = cliente.NIF;
                DataGriewClients.Rows[linha].Cells[4].Value = cliente.Email;
                DataGriewClients.Rows[linha].Cells[5].Value = cliente.Morada;
                DataGriewClients.Rows[linha].Cells[6].Value = cliente.CodigoPostal;

                linha++;
            }
        }

        private void UcClients_Load(object sender, EventArgs e)
        {
            DataGriewClients.Columns.Add("colID", "ID");
            DataGriewClients.Columns.Add("colName", "Name");
            DataGriewClients.Columns.Add("colTelephone", "Telephone");
            DataGriewClients.Columns.Add("colNIF", "NIF");
            DataGriewClients.Columns.Add("colEmail", "Email");
            DataGriewClients.Columns.Add("colAddress", "Address");
            DataGriewClients.Columns.Add("colPostalCode", "Postal Code");

            AtualizaDataGriewClients();
        }

        private void DataGriewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewClients.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                txtName.Text = row.Cells["colName"].Value.ToString();
                mtxtbTelephone.Text = row.Cells["colTelephone"].Value.ToString();
                txtNIF.Text = row.Cells["colNIF"].Value.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value.ToString();
                txtAddress.Text = row.Cells["colAddress"].Value.ToString();
                mtxtbPostalCode.Text = row.Cells["colPostalCode"].Value.ToString();
                txtNIF.Enabled = false;
            }
        }

        #endregion

        #region LimpaCampos

        private void LimpaCampos()
        {
            txtID.ResetText();
            txtName.ResetText();
            mtxtbTelephone.ResetText();
            txtNIF.ResetText();
            txtNIF.Enabled = true;
            txtEmail.ResetText();
            txtAddress.ResetText();
            mtxtbPostalCode.ResetText();
        }


        #endregion

        #region Buttons

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string NomeCliente = txtName.Text;
            string Ntelefone = mtxtbTelephone.Text;
            string NIF = txtNIF.Text;
            string Email = txtEmail.Text;
            string Morada = txtAddress.Text;
            string Cpostal = mtxtbPostalCode.Text;

            Clientes c = new Clientes
            {
                Nome = NomeCliente,
                Telefone = Ntelefone,
                NIF = NIF,
                Email = Email,
                Morada = Morada,
                CodigoPostal = Cpostal
            };

            dc.Clientes.InsertOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewClients();
            LimpaCampos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            string NomeCliente = txtName.Text;
            string Ntelefone = mtxtbTelephone.Text;
            string NIF = txtNIF.Text;
            string Email = txtEmail.Text;
            string Morada = txtAddress.Text;
            string Cpostal = mtxtbPostalCode.Text;

            Clientes c = (from Clientes in dc.Clientes
                          where Clientes.IdCliente == Id
                          select Clientes).First();

            c.Nome = NomeCliente;
            c.Telefone = Ntelefone;
            c.NIF = NIF;
            c.Email = Email;
            c.Morada = Morada;
            c.CodigoPostal = Cpostal;


            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewClients();
            LimpaCampos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clientes c = (from Clientes
                          in dc.Clientes
                          where Clientes.IdCliente == int.Parse(txtID.Text)
                          select Clientes).First();

            dc.Clientes.DeleteOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewClients();
            LimpaCampos();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

#endregion
    }
}