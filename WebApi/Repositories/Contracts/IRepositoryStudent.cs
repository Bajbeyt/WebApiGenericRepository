using System;
using Entities.Models;
using Repositories.EFCore;

namespace Repositories.Contracts
{
    public interface IRepositoryStudent : IRepositoryBase<Student>
	{
		IQueryable<Student> GetStudent(int id, bool trackChanges);

	}
}

