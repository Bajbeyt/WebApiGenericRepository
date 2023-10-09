using System;
using Entities.Models;
namespace Services.Contracts
{
	public interface IStudentService
	{
		IEnumerable<Student> GetAllStudents(bool trackChanges);
		IEnumerable<Student> GetStudent(int id, bool trackChanges);
		Student CreatteStudent(Student student);
		void UpdateStudent(Student student);
		void DeleteStudent(int id);
	}
}

