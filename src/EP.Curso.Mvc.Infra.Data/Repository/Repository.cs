using EP.Curso.Mvc.Infra.Data.Context;
using EP.CursoMvc.Domain.Interface;
using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EP.Curso.Mvc.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepositoryRead<TEntity>, IRepositoryWrite<TEntity> where TEntity : Entity, new()
    {
        protected CursoMvcContext Db;
        protected DbSet<TEntity> DbSet;
        public Repository() 
        {
            Db = new CursoMvcContext(); 
            DbSet = Db.Set<TEntity>(); 
        }
        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            SaveChanges();
        }

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            
            SaveChanges();
        }
        public virtual void Remover(Guid id)
        {
           var entity = new TEntity { Id = id };
           DbSet.Remove(entity);
           
           SaveChanges();
        }
        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicato)
        {
            return DbSet.Where(predicato);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterTodosPaginados(int s, int t)
        {
            return DbSet.Take(t).Skip(s);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
