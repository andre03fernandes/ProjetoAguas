namespace ProjetoAguas.UserControls
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UcConsumptions : UserControl
    {
        public UcConsumptions() { InitializeComponent(); } DcAguasDataContext dc = new DcAguasDataContext();

        #region Consumos

        // Método que calcula o consumo total, dependendo do escalão que se introduz (valor unitário é fixo para cada escalão)

        public void ModuloConsumos()
        {
            decimal escalao = decimal.Parse(txtEchelons.Text);
            decimal primeiroesc = 0.30M;
            decimal segundoesc = 0.80M;
            decimal terceiroesc = 1.20M;
            decimal quartoesc = 1.60M;
            decimal consumototal = 0;

            if (escalao >= 5)
            {
                escalao -= 5;
                consumototal = 5 * primeiroesc;

                if (escalao >= 10)
                {
                    escalao -= 10;
                    consumototal += 10 * segundoesc;

                    if (escalao >= 10)
                    {
                        escalao -= 10;
                        consumototal += 10 * terceiroesc;
                        consumototal += escalao * quartoesc;
                    }
                    else consumototal += escalao * terceiroesc;
                }
                else consumototal += escalao * segundoesc;
            }
            else consumototal = (escalao * primeiroesc);

            txtTotalConsume.Text = consumototal.ToString();
        }

        #endregion

        #region DataGridView

        // Atualiza a datagridview com os dados que correspondem a cada coluna 

        public void AtualizaDataGriewConsumptions()
        {
            int linha = 0;

            DataGriewConsumptions.Rows.Clear();

            var listaConsumos = from consumo in dc.Consumos select consumo;

            foreach (Consumos consumo in listaConsumos)
            {
                DataGridViewRow registo = new DataGridViewRow();
                DataGriewConsumptions.Rows.Add(registo);

                DataGriewConsumptions.Rows[linha].Cells[0].Value = consumo.IdConsumo;
                DataGriewConsumptions.Rows[linha].Cells[1].Value = consumo.IdContrato;
                DataGriewConsumptions.Rows[linha].Cells[2].Value = consumo.NomeCliente;
                DataGriewConsumptions.Rows[linha].Cells[3].Value = consumo.TipoContrato;
                DataGriewConsumptions.Rows[linha].Cells[4].Value = consumo.Escaloes;
                DataGriewConsumptions.Rows[linha].Cells[5].Value = consumo.ValorUnitario;
                DataGriewConsumptions.Rows[linha].Cells[6].Value = consumo.DataConsumo;
                DataGriewConsumptions.Rows[linha].Cells[7].Value = consumo.ConsumoTotal;

                linha++;
            }
        }

        // Cria as colunas da datagridview, na mesma ordem do método "AtualizaDataGriewConsumptions"

        private void UcConsumptions_Load(object sender, EventArgs e)
        {
            DataGriewConsumptions.Columns.Add("colID", "IdConsumption");
            DataGriewConsumptions.Columns.Add("colIDcontract", "IdContract");
            DataGriewConsumptions.Columns.Add("colClient", "Client");
            DataGriewConsumptions.Columns.Add("colContractType", "Contract Type");
            DataGriewConsumptions.Columns.Add("colEscaloes", "Echelons");
            DataGriewConsumptions.Columns.Add("colValorUnitario", "Unitary Value");
            DataGriewConsumptions.Columns.Add("colDataConsumo", "Consume Date");
            DataGriewConsumptions.Columns.Add("colConsumoTotal", "Total Consume");

            ComboBoxs();
            AtualizaDataGriewConsumptions();
            LimpaCampos();
        }

        // Ao clicar numa linha da datagridview, os dados retornam aos seus campos

        private void DataGriewConsumptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGriewConsumptions.Rows[e.RowIndex];

                txtID.Text = row.Cells["colID"].Value.ToString();
                cbIDcontract.Text = row.Cells["colIDcontract"].Value.ToString();
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

        // Preenche a combobox do IdContract com os seus Id's existentes

        private void ComboBoxs()
        {
            var _IDcontract = from Contratos in dc.Contratos select Contratos;

            cbIDcontract.DataSource = _IDcontract;
            cbIDcontract.DisplayMember = "IdContrato";
        }

        // Ao selecionar um Idcontract na combobox, tanto a textbox do client como do Contract Type, são preenchidas de acordo 
        // com o Id do cliente associado ao contrato

        private void cbIDcontract_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var _pesquisaContratos = from Contratos in dc.Contratos where Contratos.IdContrato == int.Parse(cbIDcontract.Text) select Contratos;

                foreach (Contratos contratos in _pesquisaContratos)
                {
                    txtClients.Text = contratos.Clientes.Nome;
                    txtContractType.Text = contratos.TipoContrato;
                }
            }
            catch (Exception ex) { /* MessageBox.Show(ex.Message); */ }
        }

        #endregion

        #region Buttons

        // Insere os dados na datagridview

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Contratos Id = (Contratos)cbIDcontract.SelectedItem;
            string Client = txtClients.Text;
            string ContractType = txtContractType.Text;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string Dconsumo = dtpConsumeDate.Text;
            string cTotal = txtTotalConsume.Text;

            Consumos c = new Consumos
            {
                IdContrato = Id.IdContrato,
                NomeCliente = Client.ToString(),
                TipoContrato = ContractType,
                Escaloes = (decimal.Parse(Escaloes)),
                ValorUnitario = (decimal.Parse(Vunitario)),
                DataConsumo = Dconsumo,
                ConsumoTotal = cTotal
            };

            dc.Consumos.InsertOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewConsumptions();
            LimpaCampos();
        }

        // Atualiza os dados selecionados da datagridview

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            Contratos IdContract = (Contratos)cbIDcontract.SelectedItem;
            string Client = txtClients.Text;
            string ContractType = txtContractType.Text;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = (from Consumos in dc.Consumos where Consumos.IdConsumo == Id select Consumos).First();

            c.IdContrato = IdContract.IdContrato;
            c.NomeCliente = Client;
            c.TipoContrato = ContractType;
            c.Escaloes = (decimal.Parse(Escaloes));
            c.ValorUnitario = (decimal.Parse(Vunitario));
            c.DataConsumo = DataConsumo;
            c.ConsumoTotal = ConsumoTotal;

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewConsumptions();
            LimpaCampos();
        }

        // Elimina um contrato selecionado

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Consumos c = (from Consumos in dc.Consumos where Consumos.IdConsumo == int.Parse(txtID.Text) select Consumos).First();

            dc.Consumos.DeleteOnSubmit(c);

            try { dc.SubmitChanges(); } catch (Exception ex) { MessageBox.Show(ex.Message); }

            AtualizaDataGriewConsumptions();
            LimpaCampos();
        }

        // Ao clicar no botão reset, todos os campos serão limpos

        private void btnReset_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        // Ao ser clicado gera o consumo total deste contrato

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            ModuloConsumos();
        }

        // Consumo total por estimativa

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            decimal valorTotal = 0;
            int cont = 0;

            var estimativa = from Consumos in dc.Consumos select Consumos;

            foreach (Consumos consumos in estimativa)
            {
                cont++;
                valorTotal += decimal.Parse(consumos.ConsumoTotal);
            }

            decimal est = valorTotal / cont;
            txtTotalConsume.Text = est.ToString("#,0.00"); // "#,0.00" - arredondamento das casas decimais
            txtUnitaryValue.Text = "0";
            txtEchelons.Text = "0";

        }

        #endregion

        #region LimpaCampos

        // Método que limpa todos os campos 

        private void LimpaCampos()
        {
            txtID.ResetText();
            cbIDcontract.ResetText();
            txtClients.ResetText();
            txtContractType.ResetText();
            txtEchelons.ResetText();
            txtUnitaryValue.ResetText();
            txtTotalConsume.ResetText();
        }

        #endregion

        #region Validações

        // Validações necessárias para o preenchimento dos campos 

        private void txtEchelons_TextChanged(object sender, EventArgs e)
        {
            foreach (char Escalao in txtEchelons.Text)
            {
                if (!(char.IsDigit(Escalao) || Escalao == '.'))
                {
                    MessageBox.Show("Heads up! Enter digits only!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEchelons.Clear();
                    break;
                }
            }
        }

        private void txtEchelons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtEchelons.Text == "")
                {
                    MessageBox.Show("Required field! Fill with a echelon.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtEchelons.Text != "")
                {
                    Escaloes();
                }
                e.Handled = true;
            }
        }

        // Método para preencher a textbox do valor unitário dependendo do escalão introduzido (se não for por estimativa)

        private void Escaloes()
        {
            decimal escalao = Convert.ToDecimal(txtEchelons.Text);

            if (escalao <= 5 && escalao > 0)
            {
                lblEchelons.Text = "1st Echelon";
                txtUnitaryValue.Text = "0.30";
            }
            else if (escalao > 5 && escalao <= 15)
            {
                lblEchelons.Text = "2nd Echelon";
                txtUnitaryValue.Text = "0.80";
            }
            else if (escalao > 15 && escalao <= 25)
            {
                lblEchelons.Text = "3rd Echelon";
                txtUnitaryValue.Text = "1.20";
            }
            else
            {
                lblEchelons.Text = "4th Echelon";
                txtUnitaryValue.Text = "1.60";
            }
        }
    }
    #endregion
}