namespace ProjetoAguas.Classes
{
    public class Fatura
    {
        #region Propriedades

        public int IdFatura { get; set; }

        public int IdContrato { get; set; }

        public int IdLeitura { get; set; }

        public int AtualizacaoFatura { get; set; } // Arquivo de Faturas (0, 1) - Quando surge uma nova fatura

        public string DataFatura { get; set; }

        public string Cliente { get; set; }

        public decimal ConsumoMensal { get; set; }

        public decimal ValorPagar { get; set; }

        #endregion
    }
}
