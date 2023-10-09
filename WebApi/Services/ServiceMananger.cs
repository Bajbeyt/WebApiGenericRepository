using System;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
	public class ServiceMananger:IServiceMananger
	{
		private readonly Lazy<IStudentService> _studentService;
		public ServiceMananger(IRepositoryMananger repositoryMananger)
		{
			_studentService = new Lazy<IStudentService>(() => new StudentMananger(repositoryMananger));
		}
		public IStudentService StudentService => _studentService.Value;
	}
}

