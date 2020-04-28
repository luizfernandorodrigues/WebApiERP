using System;

namespace API.Business.Models
{
    /// <summary>
    /// Classe base para todos modelos, toda entidade modelo deverá implementar
    /// </summary>
    /// Autor   : Luiz Fernando
    /// Data    : 27/04/2020
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime TimesTamp { get; set; }
        public bool Ativo { get; set; }
        protected Entity()
        {
            Id = new Guid();
            TimesTamp = DateTime.Now;
            Ativo = true;
        }
    }
}
