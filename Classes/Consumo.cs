namespace ProjetoAguas.Classes
{
    public class Consumo
    {
        #region Propriedades

        public int IdConsumo { get; set; }

        public int IdContrato { get; set; }

        public int IdFatura { get; set; }

        public decimal Escaloes { get; set; }

        public string DataConsumo { get; set; }

        public string ConsumoTotal { get; set; }

        public decimal ValorUnitario { get; set; }

        #endregion
    }
}
