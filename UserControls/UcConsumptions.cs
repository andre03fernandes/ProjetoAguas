namespace ProjetoAguas.UserControls
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;

    public partial class UcConsumptions : UserControl
    {
        List<Consumos> limiteEscaloes;
        decimal escalao = 30;
        decimal maxPagar = 0;
        decimal aux = 0;

        public UcConsumptions() { InitializeComponent();}

        DcAguasDataContext dc = new DcAguasDataContext();

        #region Consumos

        public void ModuloConsumos()
        {
            try
            {
                decimal esc = decimal.Parse(txtEchelons.Text);
                decimal TotalConsumo = Convert.ToDecimal(txtTotalConsume.Text);
                decimal Vunitario = Convert.ToDecimal(txtContractType.Text);

                foreach (Consumos consumos in limiteEscaloes)
                {
                    esc = consumos.Escaloes;
                    Vunitario = consumos.ValorUnitario;
                    TotalConsumo = Convert.ToDecimal(consumos.ConsumoTotal);

                    if (esc == 0)
                        maxPagar = Vunitario;
                    else
                    {
                        if (TotalConsumo - esc >= 0)
                        {
                            TotalConsumo += Vunitario * (esc - aux);
                            aux = esc;
                        }
                        else
                            TotalConsumo += Vunitario * (esc - TotalConsumo);
                    }
                } 
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region DataGridView

        public void AtualizaDataGriewConsumptions()
        {
            int linha = 0;

            DataGriewConsumptions.Rows.Clear();

            var listaConsumos = from consumo in dc.Consumos select consumo;

            foreach(Consumos consumo in listaConsumos)
            {
                DataGridViewRow registo = new DataGridViewRow();
                DataGriewConsumptions.Rows.Add(registo);

                DataGriewConsumptions.Rows[linha].Cells[0].Value = consumo.IdConsumo;
                DataGriewConsumptions.Rows[linha].Cells[1].Value = consumo.IdContrato;
                DataGriewConsumptions.Rows[linha].Cells[2].Value = consumo.IdFatura;
                DataGriewConsumptions.Rows[linha].Cells[3].Value = consumo.NomeCliente;
                DataGriewConsumptions.Rows[linha].Cells[4].Value = consumo.TipoContrato;
                DataGriewConsumptions.Rows[linha].Cells[5].Value = consumo.Escaloes;
                DataGriewConsumptions.Rows[linha].Cells[6].Value = consumo.ValorUnitario;
                DataGriewConsumptions.Rows[linha].Cells[7].Value = consumo.DataConsumo;
                DataGriewConsumptions.Rows[linha].Cells[8].Value = consumo.ConsumoTotal;

                linha++;
            }
        }

        private void UcConsumptions_Load(object sender, EventArgs e)
        {
            DataGriewConsumptions.Columns.Add("colID", "IdConsumption");
            DataGriewConsumptions.Columns.Add("colIDcontract", "IdContract");
            DataGriewConsumptions.Columns.Add("colIDfatura", "IDinvoice");
            DataGriewConsumptions.Columns.Add("colClient", "Client");
            DataGriewConsumptions.Columns.Add("colContractType", "Contract Type");
            DataGriewConsumptions.Columns.Add("colEscaloes", "Echelons");
            DataGriewConsumptions.Columns.Add("colValorUnitario", "Unitary Value");
            DataGriewConsumptions.Columns.Add("colDataConsumo", "Consume Date");
            DataGriewConsumptions.Columns.Add("colConsumoTotal", "Total Consume");

            ComboBoxs();
            AtualizaDataGriewConsumptions();
            //cbIDcontract.SelectedIndex = 0;
            //ModuloConsumos();
        }

        private void DataGriewConsumptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewConsumptions.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                cbIDcontract.Text = row.Cells["colIDcontract"].Value.ToString();
                cbIDinvoices.Text = row.Cells["colIDfatura"].Value.ToString();
                txtClients.Text = row.Cells["colClient"].Value.ToString();
                txtContractType.Text = row.Cells["colContractType"].Value.ToString();
                txtEchelons.Text = row.Cells["colEscaloes"].Value.ToString();
                txtUnitaryValue.Text = row.Cells["colValorUnitario"].Value.ToString();
                dtpConsumeDate.Text = row.Cells["colDataConsumo"].Value.ToString();
                txtTotalConsume.Text = row.Cells["colConsumoTotal"].Value.ToString();
            }
        }

        #endregion

        #region ComboBoxs

        private void ComboBoxs()
        {
            var IDcontract = from Contratos in dc.Contratos select Contratos;

            cbIDcontract.DataSource = IDcontract;
            cbIDcontract.DisplayMember = "IdContrato";

            //cbIDcontract.Items.Add("Selecione uma opção");

            //foreach(Contratos cont in IDcontract)
            //    cbIDcontract.Items.Add(cont.IdContrato);

            var IDinvoice = from Faturas in dc.Faturas select Faturas;

            cbIDinvoices.DataSource = IDinvoice;
            cbIDinvoices.DisplayMember = "IdFatura";
        }

        private void cbIDcontract_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var TipoContrato = from Contratos
                                    in dc.Contratos
                                    where Contratos.IdContrato == int.Parse(cbIDcontract.Text)
                                    select Contratos;

                foreach (Contratos contratos in TipoContrato)
                {
                    txtClients.Text = contratos.Clientes.Nome;
                    txtContractType.Text = contratos.TipoContrato;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Buttons

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Contratos Id = (Contratos)cbIDcontract.SelectedItem;
            Faturas IdInvoice = (Faturas)cbIDinvoices.SelectedItem;
            string Client = txtClients.Text;
            string ContractType = txtContractType.Text;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = new Consumos
            {
                IdContrato = Id.IdContrato,
                IdFatura = IdInvoice.IdFatura,
                NomeCliente = Client.ToString(),
                TipoContrato = ContractType,
                Escaloes = (decimal.Parse(Escaloes)),
                ValorUnitario = (decimal.Parse(Vunitario)),
                DataConsumo = DataConsumo,
                ConsumoTotal = ConsumoTotal
            };

            dc.Consumos.InsertOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewConsumptions();
            LimpaCampos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            Contratos IdContract = (Contratos)cbIDcontract.SelectedItem;
            Clientes nCli = (Clientes)txtClients.Container;
            string ContractType = txtContractType.Text;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = (from Consumos in dc.Consumos
                          where Consumos.IdConsumo == Id
                          select Consumos).First();

            c.IdContrato = IdContract.IdContrato;
            c.IdFatura = nCli.IdCliente;
            c.TipoContrato = ContractType;
            c.Escaloes = (decimal.Parse(Escaloes));
            c.ValorUnitario = (decimal.Parse(Vunitario));
            c.DataConsumo = DataConsumo;
            c.ConsumoTotal = ConsumoTotal;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Consumos c = (from Consumos
                          in dc.Consumos
                          where Consumos.IdConsumo == int.Parse(txtID.Text)
                          select Consumos).First();

            dc.Consumos.DeleteOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewConsumptions();
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
            cbIDcontract.ResetText();
            cbIDinvoices.ResetText();
            txtClients.ResetText();
            txtContractType.ResetText();
            txtEchelons.ResetText();
            txtUnitaryValue.ResetText();
            txtTotalConsume.ResetText();
        }

        #endregion
    }
}