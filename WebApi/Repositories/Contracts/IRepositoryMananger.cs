using System;
namespace Repositories.Contracts
{
	public interface IRepositoryMananger
	{
		IRepositoryStudent student { get; }
		void Save();
	}
}

