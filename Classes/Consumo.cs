namespace ProjetoAguas.Classes
{
    using System.Collections.Generic;

    public class Consumo
    {
        List<Consumos> _tabelaEscaloes;
        decimal totalConsumo = 0;
        decimal escalao = 30;
        decimal max = 0;
        decimal limite = 0;

        #region Propriedades

        public int IdConsumo { get; set; }

        public int IdContrato { get; set; }

        public int IdFatura { get; set; }

        public decimal Escaloes { get; set; }

        public string DataConsumo { get; set; }

        public string ConsumoTotal { get; set; }

        public decimal ValorUnitario { get; set; }

        #endregion

        public decimal TotalConsumo()
        {
            foreach(Consumos consumo in _tabelaEscaloes)
            {
                if (consumo.Escaloes == 0)
                    max = consumo.ValorUnitario;
                else
                {
                    if(totalConsumo - consumo.Escaloes >= 0)
                    {
                        totalConsumo += consumo.ValorUnitario * (consumo.Escaloes - limite);
                        limite = consumo.Escaloes;
                    }
                    else
                    {
                        totalConsumo += consumo.ValorUnitario * (consumo.Escaloes - totalConsumo);                      
                    }
                }
            }
            return totalConsumo;
        }
    }
}