namespace ProjetoAguas.UserControls
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UcInvoices : UserControl
    {
        public UcInvoices() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region ConsumoMensal

        public void MonthConsume()
        {
           decimal mes = 0;

           var consumoMes = (from Faturas
                             in dc.Faturas
                              where Faturas.IdContrato == int.Parse(cbIDcontracts.Text)
                              select Faturas);

            if (consumoMes.Count() > 0)
            {
                foreach (Faturas faturas in consumoMes)
                    mes += faturas.ConsumoMensal;
                txtMonthlyConsumption.Text = (mes / consumoMes.Count()).ToString();
            }
            else
                txtMonthlyConsumption.Text = "0";

        }

        #endregion

        #region DataGridView

        // Atualiza a datagridview com os dados que correspondem a cada coluna 

        public void AtualizaDataGriewInvoices()
        {
            int linha = 0;

            DataGriewInvoices.Rows.Clear();

            var listaFaturas = from fatura in dc.Faturas select fatura;

            foreach(Faturas faturas in listaFaturas)
            {
                DataGridViewRow registo = new DataGridViewRow();
                DataGriewInvoices.Rows.Add(registo);

                DataGriewInvoices.Rows[linha].Cells[0].Value = faturas.IdFatura;
                DataGriewInvoices.Rows[linha].Cells[1].Value = faturas.IdContrato;
                DataGriewInvoices.Rows[linha].Cells[2].Value = faturas.TipoPagamento;
                DataGriewInvoices.Rows[linha].Cells[3].Value = faturas.DataFatura;
                DataGriewInvoices.Rows[linha].Cells[4].Value = faturas.Cliente;
                DataGriewInvoices.Rows[linha].Cells[5].Value = faturas.ConsumoMensal;
                DataGriewInvoices.Rows[linha].Cells[6].Value = faturas.ValorPagar;

                linha++;
            }
        }

        // Cria as colunas da datagridview, na mesma ordem do método "AtualizaDataGriewInvoices"

        private void UcInvoices_Load(object sender, EventArgs e)
        {
            DataGriewInvoices.Columns.Add("colID", "IdInvoice");
            DataGriewInvoices.Columns.Add("colIDcontract", "IdContract");
            DataGriewInvoices.Columns.Add("colPaymentType", "Payment Type");
            DataGriewInvoices.Columns.Add("colInvoiceDate", "Invoice Date");
            DataGriewInvoices.Columns.Add("colClient", "Client");
            DataGriewInvoices.Columns.Add("colMonthConsume", "Monthly Consume");
            DataGriewInvoices.Columns.Add("colAmountPay", "Amount to Pay");

            ComboBoxs();
            AtualizaDataGriewInvoices();
            LimpaCampos();
        }

        // Ao clicar numa linha da datagridview, os dados retornam aos seus campos

        private void DataGriewInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewInvoices.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                cbIDcontracts.Text = row.Cells["colIDcontract"].Value.ToString();
                txtPaymentType.Text = row.Cells["colPaymentType"].Value.ToString();
                dtpInvoiceDate.Text = row.Cells["colInvoiceDate"].Value.ToString();
                txtClients.Text = row.Cells["colClient"].Value.ToString();
                txtMonthlyConsumption.Text = row.Cells["colMonthConsume"].Value.ToString();
                txtAmountToPay.Text = row.Cells["colAmountPay"].Value.ToString();
            }
        }

        #endregion

        #region ComboBoxs

        private void ComboBoxs()
        {
            var IDcontract = from Contratos in dc.Contratos select Contratos;

            cbIDcontracts.DataSource = IDcontract;
            cbIDcontracts.DisplayMember = "IdContrato";
        }

        private void cbIDcontracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cont = from Contratos
                                    in dc.Contratos
                                   where Contratos.IdContrato == int.Parse(cbIDcontracts.Text)
                                   select Contratos;

                foreach (Contratos contratos in cont)
                {
                    txtClients.Text = contratos.Clientes.Nome;
                    txtPaymentType.Text = contratos.TipoPagamento;
                }

                var value = from Consumos
                            in dc.Consumos
                            where Consumos.IdFatura == int.Parse(cbIDcontracts.Text)
                            select Consumos;

                foreach(Consumos consumos in value)
                {
                    txtAmountToPay.Text = consumos.ConsumoTotal;
                }
            }
            catch (Exception ex) { /* MessageBox.Show(ex.Message); */ }
        }

        #endregion

        #region Buttons

        // Insere os dados na datagridview

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Contratos Id = (Contratos)cbIDcontracts.SelectedItem;
            string Client = txtClients.Text;
            string Pay = txtPaymentType.Text;
            string date = dtpInvoiceDate.Text;
            string month = txtMonthlyConsumption.Text;
            string amount = txtAmountToPay.Text;

            Faturas f = new Faturas
            {
                IdContrato = Id.IdContrato,
                Cliente = Client,
                TipoPagamento = Pay,
                DataFatura = date,
                ConsumoMensal = decimal.Parse(month),
                ValorPagar = decimal.Parse(amount)
            };

            dc.Faturas.InsertOnSubmit(f);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewInvoices();
            LimpaCampos();
        }

        // Atualiza os dados selecionados da datagridview

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            Contratos IdContract = (Contratos)cbIDcontracts.SelectedItem;
            string Client = txtClients.Text;
            string Pay = txtPaymentType.Text;
            string date = dtpInvoiceDate.Text;
            string month = txtMonthlyConsumption.Text;
            string amount = txtAmountToPay.Text;

            Faturas f = (from Faturas in dc.Faturas
                         where Faturas.IdFatura == Id
                         select Faturas).First();

            f.IdContrato = IdContract.IdContrato;
            f.Cliente = Client;
            f.TipoPagamento = Pay;
            f.DataFatura = date;
            f.ConsumoMensal = decimal.Parse(month);
            f.ValorPagar = decimal.Parse(amount);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewInvoices();
            LimpaCampos();

        }

        // Elimina um contrato selecionado

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Faturas f = (from Faturas 
                        in dc.Faturas
                        where Faturas.IdFatura == int.Parse(txtID.Text)
                        select Faturas).First();

            dc.Faturas.DeleteOnSubmit(f);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewInvoices();
            LimpaCampos();
        }

        // Ao clicar no botão reset, todos os campos serão limpos

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        // Ao ser clicado gera o consumo mensal de um cliente

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MonthConsume();
        }

        #endregion

        #region LimpaCampos

        private void LimpaCampos()
        {
            txtID.ResetText();
            cbIDcontracts.ResetText();
            txtClients.ResetText();
            txtPaymentType.ResetText();
            txtMonthlyConsumption.ResetText();
            dtpInvoiceDate.ResetText();
            txtAmountToPay.ResetText();
        }

        #endregion
    }
}