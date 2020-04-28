using System;
using System.Collections.Generic;
using System.Text;

namespace API.Business.Models.Cadastro.Logradouro
{
    public class Cep : Entity
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public Guid IdCidade { get; set; }
    }
}
