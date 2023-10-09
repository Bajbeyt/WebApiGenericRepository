using System;
namespace Services.Contracts
{
	public interface IServiceMananger
	{
		IStudentService StudentService { get; }
	}
}

