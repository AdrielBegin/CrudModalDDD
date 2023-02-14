using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Interface
{
    public interface IRepositoryRead<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity ObterPorId(Guid Id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterTodosPaginados( int s, int t);        
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicato);


    }


}
