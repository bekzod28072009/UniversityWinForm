using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;
using Univer.Service.IService;

namespace Univer.Service.Service
{
    public class StudentService : IStudentService
    {
        public readonly IStudentService repository;
        public StudentService()
        {
            repository = new StudentService();
        }

        public Task Add(Student students)
            => repository.Add(students);

        public Task Delete(long Id)
            => repository.Delete(Id);

        public List<Student> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(long Id, Student students)
            => repository.Update(Id, students);
    }
}
