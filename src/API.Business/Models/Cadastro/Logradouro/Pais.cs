using System.Collections.Generic;

namespace API.Business.Models.Cadastro.Logradouro
{
    /// <summary>
    /// Classe modelo que representa um pais
    /// </summary>
    /// Autor   : Luiz Fernando
    /// Data    : 27/04/2020
    public class Pais : Entity
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Observacao { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}
