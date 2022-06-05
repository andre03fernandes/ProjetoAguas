using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAguas.UserControls
{
    public partial class UcConsumptions : UserControl
    {
        List<Consumos> limiteEscaloes;
        decimal escalao = 30;
        decimal maxPagar = 0;
        decimal aux = 0;

        public UcConsumptions() { InitializeComponent(); }

        public decimal ModuloConsumos()
        {
            decimal esc = Convert.ToDecimal(txtEchelons.Text);
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
    }
}