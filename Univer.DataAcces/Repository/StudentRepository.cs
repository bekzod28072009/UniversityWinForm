using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.DataAcces.IRepository;
using Univer.DataAcces.UniverDbContexts;
using Univer.Domein.Entity;

namespace Univer.DataAcces.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniverDbContext dbContext;

        public StudentRepository()
        {
            dbContext = new UniverDbContext();
        }
        public async Task Add(Student student)
        {
            dbContext.students.Add(student);

            dbContext.SaveChanges();
        }

        public async Task Delete(long Id)
        {
            var student = dbContext.students.FirstOrDefault(u => u.Id == Id);
            dbContext.students.Remove(student);

            dbContext.SaveChanges();
        }

        public List<Student> GetAllAsync()
             => dbContext.students.ToList();

        public async Task Update(long Id, Student students)
        {
            var student = dbContext.students.FirstOrDefault(u => u.Id == Id);

            student.Name = students.Name;
            student.Faculty = students.Faculty;
            student.Course = students.Course;
            student.Teacher = students.Teacher;
            dbContext.SaveChanges();
        }
    }
}
