namespace API.Business.Models.Cadastro.Produto
{
    /// <summary>
    /// Classe abstrata de produto, será implementada pelos produtos concretos.
    /// </summary>
    /// Autor   : Luiz FErnando
    /// Data    : 27/04/2020
    public abstract class Mercadoria : Entity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
                
    }
}
