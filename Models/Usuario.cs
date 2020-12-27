using System;

namespace CrudUsuario.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNasc { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}