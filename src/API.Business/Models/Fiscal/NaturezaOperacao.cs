using API.Business.Enumerators;

namespace API.Business.Models.Fiscal
{
    public class NaturezaOperacao : Entity
    {
        public string Descricao { get; set; }
        public string Cfop { get; set; }
        public EFluxo Fluxo { get; set; }
    }
}
