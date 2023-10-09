using System;
using Repositories.Contracts;
using Repositories.EFCore;

namespace Repositories
{
    public class RepositoryMananger : IRepositoryMananger
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IRepositoryStudent> _repositoryStudent;
        public RepositoryMananger(RepositoryContext context)
        {
            _context = context;
            _repositoryStudent = new Lazy<IRepositoryStudent>(()=> new RepositoryStudent(_context));
        }
        public IRepositoryStudent student => _repositoryStudent.Value; // LazyLoading kullanırken value değerini alırız

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

