namespace ProjetoAguas.Classes
{
    public class Contrato
    {
        #region Propriedades

        public int IdContrato { get; set; }

        public int IdCliente { get; set; }

        public string DataContrato { get; set; }

        public string TipoContrato { get; set; }

        public string TipoPagamento { get; set; }

        public string Morada { get; set; }

        public string CodigoPostal { get; set; }

        #endregion
    }
}
