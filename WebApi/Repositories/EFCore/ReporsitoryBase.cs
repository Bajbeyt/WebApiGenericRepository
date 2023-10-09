using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class ReporsitoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext _context;
        public ReporsitoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public void GenericCreate(T entity) =>
            _context.Set<T>().Add(entity);

        public void GenericDelete(T entity) =>
            _context.Remove(entity);

        public IQueryable<T> GenericRead( bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking()
            : _context.Set<T>();

        public IQueryable<T> GenericReadExpression(bool trackChanges, Expression<Func<T, bool>> expression) =>
            !trackChanges ? _context.Set<T>().Where(expression).AsNoTracking()
            : _context.Set<T>().Where(expression);

        public void GenericUpdate(T entity) =>
            _context.Set<T>().Update(entity);
    }
}

