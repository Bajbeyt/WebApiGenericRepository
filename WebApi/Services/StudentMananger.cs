using System;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class StudentMananger : IStudentService
    {
        private readonly IRepositoryMananger _repositoryMananger;
        public StudentMananger(IRepositoryMananger repositoryMananger)
        {
            _repositoryMananger = repositoryMananger;
        }
        public Student CreatteStudent(Student student)
        {
            _repositoryMananger.student.GenericCreate(student);
            _repositoryMananger.Save();
            return student;
        }

        public void DeleteStudent(int id)
        {
            var student = _repositoryMananger.student.GetStudent(id, false);
            _repositoryMananger.student.GenericDelete((Student)student);
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges)
        {
            return _repositoryMananger.student.GenericRead(trackChanges);
        }

        public IEnumerable<Student> GetStudent(int id, bool trackChanges)
        {
            var student=_repositoryMananger.student.GetStudent(id, trackChanges);
            return student;
        }

        public void UpdateStudent(Student student)
        {
            var findStudent = _repositoryMananger.student.GetStudent(student.Id, false);
            if (findStudent != null) { _repositoryMananger.student.GenericUpdate(student); }
        }
    }
}
