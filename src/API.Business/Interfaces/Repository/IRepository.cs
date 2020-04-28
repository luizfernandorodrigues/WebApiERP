using API.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Business.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Remover(Guid id);
        Task Alterar(TEntity entity);
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
