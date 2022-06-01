namespace ProjetoAguas.Classes
{
    using System.Collections.Generic;

    public class Cliente
    {
        #region Propriedades

        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string NIF { get; set; }

        public string Email { get; set; }

        public string Morada { get; set; }

        public string CodigoPostal { get; set; }

        #endregion

        List<Contrato> Contratos { get; set; }
    }
}