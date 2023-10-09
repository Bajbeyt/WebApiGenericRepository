using System;
using Entities.Models;
using Repositories.Contracts;
namespace Repositories.EFCore
{
    public class RepositoryStudent : ReporsitoryBase<Student>, IRepositoryStudent
    {
        public RepositoryStudent(RepositoryContext context):base (context)
        {

        }
        public IQueryable<Student> GetStudent(int id, bool trackChanges)
            => GenericReadExpression(trackChanges,x => x.Id == id);
    }
}

