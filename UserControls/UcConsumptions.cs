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

        public UcConsumptions() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region Consumos

        public decimal ModuloConsumos()
        {
            decimal esc = decimal.Parse(txtEchelons.Text);
            decimal TotalConsumo = Convert.ToDecimal(txtTotalConsume.Text);
            decimal Vunitario = Convert.ToDecimal(txtUnitaryValue.Text);

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
            return TotalConsumo;
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

                var listaContratos = (from Contratos in dc.Contratos
                                      where Contratos.IdContrato == consumo.IdContrato
                                      select Contratos).Single();

                DataGriewConsumptions.Rows[linha].Cells[2].Value = listaContratos.TipoContrato;

                var listaFaturas = (from Faturas in dc.Faturas
                                    where Faturas.IdFatura == consumo.IdFatura
                                    select Faturas).Single();

                DataGriewConsumptions.Rows[linha].Cells[3].Value = listaFaturas.Cliente;
                DataGriewConsumptions.Rows[linha].Cells[4].Value = consumo.Escaloes;
                DataGriewConsumptions.Rows[linha].Cells[5].Value = consumo.ValorUnitario;
                DataGriewConsumptions.Rows[linha].Cells[6].Value = consumo.DataConsumo;
                DataGriewConsumptions.Rows[linha].Cells[7].Value = consumo.ConsumoTotal;

                linha++;
            }
        }

        private void UcConsumptions_Load(object sender, EventArgs e)
        {
            DataGriewConsumptions.Columns.Add("colID", "IdConsumption");
            DataGriewConsumptions.Columns.Add("colContractType", "Contract Type");
            DataGriewConsumptions.Columns.Add("colCliente", "Client");
            DataGriewConsumptions.Columns.Add("colEscaloes", "Echelons");
            DataGriewConsumptions.Columns.Add("colValorUnitario", "Unitary Value");
            DataGriewConsumptions.Columns.Add("colDataConsumo", "Consume Date");
            DataGriewConsumptions.Columns.Add("colConsumoTotal", "Total Consume");

            ComboBoxs();
            AtualizaDataGriewConsumptions();
            //ModuloConsumos();
        }

        private void DataGriewConsumptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewConsumptions.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                cbContractType.Text = row.Cells["colContractType"].Value.ToString();
                cbClients.Text = row.Cells["colCliente"].Value.ToString();
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
            var listaClientes = from Clientes in dc.Clientes select Clientes;

            cbClients.DataSource = listaClientes;
            cbClients.DisplayMember = "Nome";

            cbContractType.Items.Add("Doméstico");
            cbContractType.Items.Add("Agrícola");
            cbContractType.Items.Add("Comércio");
            cbContractType.Items.Add("Industrial");
        }

        #endregion

        #region Buttons

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Clientes NomeCliente = (Clientes)cbClients.SelectedItem;
            Contratos ContractType = (Contratos)cbContractType.SelectedItem;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = new Consumos
            {
                IdContrato = ContractType.IdContrato,
                IdFatura = NomeCliente.IdCliente,
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
            string ContractType = Convert.ToString(cbContractType.SelectedItem);
            Clientes NomeCliente = (Clientes)cbClients.SelectedItem;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = (from Consumos in dc.Consumos
                          where Consumos.IdConsumo == Id
                          select Consumos).First();

            //c.IdContrato = ContractType;
            c.IdFatura = NomeCliente.IdCliente;
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
            txtUnitaryValue.ResetText();
            txtEchelons.ResetText();
            txtTotalConsume.ResetText();
            dtpConsumeDate.ResetText();
        }

        #endregion
    }
}