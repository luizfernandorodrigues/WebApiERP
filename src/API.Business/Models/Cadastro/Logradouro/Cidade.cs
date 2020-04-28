using System;
using System.Collections.Generic;
using System.Text;

namespace API.Business.Models.Cadastro.Logradouro
{
    public class Cidade : Entity
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public Guid IdEstado { get; set; }
        public Estado Estado { get; set; }
        public ICollection<Cep> Ceps { get; set; }
    }
}
