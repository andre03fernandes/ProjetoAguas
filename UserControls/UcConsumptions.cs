﻿namespace ProjetoAguas.UserControls
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UcConsumptions : UserControl
    {
        public UcConsumptions() { InitializeComponent(); }

        DcAguasDataContext dc = new DcAguasDataContext();

        #region Consumos

        // Método que calcula o consumo total, dependendo do escalão e do valor unitário que se introduz

        public void ModuloConsumos()
        {
            var listaEsc = from Consumos in dc.Consumos select Consumos;

            foreach (Consumos consumos in listaEsc)
            {
                decimal e = Convert.ToDecimal(txtEchelons.Text);
                decimal uv = Convert.ToDecimal(txtUnitaryValue.Text);

                if (e == 0)
                    txtTotalConsume.Text = "0";
                else if (e != 0)
                    txtTotalConsume.Text = (e * uv).ToString();
            }
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

        // Cria as colunas da datagridview, na mesma ordem do método "AtualizaDataGriewConsumptions"

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
        }

        // Ao clicar numa linha da datagridview, os dados retornam aos seus campos

        private void DataGriewConsumptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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

        // Preenche as combobox's do IdContract e IdInvoice com os seus respetivos Id's

        private void ComboBoxs()
        {
            var IDcontract = from Contratos in dc.Contratos select Contratos;

            cbIDcontract.DataSource = IDcontract;
            cbIDcontract.DisplayMember = "IdContrato";

            var IDinvoice = from Faturas in dc.Faturas select Faturas;

            cbIDinvoices.DataSource = IDinvoice;
            cbIDinvoices.DisplayMember = "IdFatura";
        }

        // Ao selecionar um Idcontract na combobox, tanto a textbox do client como do Contract Type, são preenchidas de acordo 
        // com o Id do cliente associado ao contrato

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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region Buttons

        // Insere os dados na datagridview

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

            //if(txtUnitaryValue.Text == null)
            //{
            //    MessageBox.Show("Do you want to generate a total consume from an estimate?",
            //                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //}
        }

        // Atualiza os dados selecionados da datagridview

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text);
            Contratos IdContract = (Contratos)cbIDcontract.SelectedItem;
            Faturas Idinvoice = (Faturas)cbIDinvoices.SelectedItem;
            string Client = txtClients.Text;
            string ContractType = txtContractType.Text;
            string Escaloes = txtEchelons.Text;
            string Vunitario = txtUnitaryValue.Text;
            string DataConsumo = dtpConsumeDate.Text;
            string ConsumoTotal = txtTotalConsume.Text;

            Consumos c = (from Consumos in dc.Consumos
                          where Consumos.IdConsumo == Id
                          select Consumos).First();

            c.IdContrato = IdContract.IdContrato;
            c.IdFatura = Idinvoice.IdFatura;
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
            Consumos c = (from Consumos
                          in dc.Consumos
                          where Consumos.IdConsumo == int.Parse(txtID.Text)
                          select Consumos).First();

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ModuloConsumos();
        }

        #endregion

        #region LimpaCampos

        // Método que limpa todos os campos 

        private void LimpaCampos()
        {
            txtID.ResetText();
            cbIDcontract.ResetText();
            cbIDinvoices.ResetText();
            txtClients.ResetText();
            txtContractType.ResetText();
            txtEchelons.ResetText();
            txtUnitaryValue.ResetText();
            txtTotalConsume.ResetText();
        }

        #endregion

        #region Validações

        // Só se poderá introduzir dígitos ou pontos (por ser decimal) na txt dos escalões

        private void txtEchelons_TextChanged(object sender, EventArgs e)
        {
            foreach (char Escalao in txtEchelons.Text)
            {
                if (!(char.IsDigit(Escalao) || Escalao == '.'))
                {
                    MessageBox.Show("Atenção! Insera apenas dígitos!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEchelons.Clear();
                    break;
                }
            }
        }

        // Apresenta uma mensagem de erro se o campo não for preenchido e dependendo do valor 
        // introduzido diz que a que escalão aquele valor pretence
         
        private void txtEchelons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal intervalo = Convert.ToDecimal(txtEchelons.Text);

                if (txtEchelons.Text.Length == 0)
                {
                    MessageBox.Show("Campo Obrigatório! Introduza um escalão!",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (intervalo >= 0 && intervalo <= 5)
                {
                    lblEchelons.Text = "1st Echelon";
                    txtUnitaryValue.Focus();
                }
                else if (intervalo >= 5 && intervalo <= 15)
                {
                    lblEchelons.Text = "2nd Echelon";
                    txtUnitaryValue.Focus();
                }
                else if (intervalo > 15 && intervalo <= 25)
                {
                    lblEchelons.Text = "3rd Echelon";
                    txtUnitaryValue.Focus();
                }
                else
                {
                    lblEchelons.Text = "4th Echelon";
                    txtUnitaryValue.Focus();
                }
                e.Handled = true; // Assinala que o evento já foi executado e não emite som
            }
        }

        // Só se poderá introduzir dígitos ou pontos (por ser decimal) na txt do valor unitário

        private void txtUnitaryValue_TextChanged(object sender, EventArgs e)
        {
            foreach (char Value in txtUnitaryValue.Text)
            {
                if (!(char.IsDigit(Value) || Value == '.'))
                {
                    MessageBox.Show("Atenção! Insera apenas dígitos!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitaryValue.Clear();
                    break;
                }
            }
        }

        private void txtUnitaryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtUnitaryValue.Text.Length == 0)
                {
                    MessageBox.Show("Campo Obrigatório! Introduza um valor unitário!",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnGenerate.Focus();
                }
                e.Handled = true; // Assinala que o evento já foi executado e não emite som

            }
        }

        #endregion
    }
}