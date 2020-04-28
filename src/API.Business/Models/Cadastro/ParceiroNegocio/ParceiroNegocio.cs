using System;

namespace API.Business.Models.Cadastro.ParceiroNegocio
{
    /// <summary>
    /// Classe abstrata de parceiro de negocio, deverá ser implementada pelos parceiros de negocio derivados, fornecedor, cliente, transportadora, funcionario e etc...
    /// </summary>
    public abstract class ParceiroNegocio : Entity
    {
        protected ParceiroNegocio(string nomeFantasia, string razaoSocial, string cpfCnpj, string endereco, string numeroEndereco, string bairro, Guid idCep)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CpfCnpj = cpfCnpj;
            Endereco = endereco;
            NumeroEndereco = numeroEndereco;
            Bairro = bairro;
            IdCep = idCep;
        }

        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public Guid IdCep { get; set; }
    }
}
