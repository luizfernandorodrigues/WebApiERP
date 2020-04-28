using System;
using System.Collections.Generic;
using System.Text;

namespace API.Business.Models.Cadastro.Logradouro
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Guid IdPais { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
    }
}
