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
    public class TeacherRepository //: ITeacherRepository
    {
        private readonly UniverDbContext dbContext;

        public TeacherRepository()
        {
            dbContext = new UniverDbContext();
        }
        public async Task Add(Teacher teacher)
        {
            dbContext.teachers.Add(teacher);

            dbContext.SaveChanges();
        }

        public async Task Delete(long Id)
        {
            var teacher = dbContext.teachers.FirstOrDefault(u => u.Id == Id);
            dbContext.teachers.Remove(teacher);

            dbContext.SaveChanges();
        }

        public List<Teacher> GetAllAsync()
             => dbContext.teachers.ToList();

        public async Task Update(long Id, Teacher teachers)
        {
            var teacher = dbContext.teachers.FirstOrDefault(u => u.Id == Id);

            teacher.Name = teachers.Name;
            teacher.Salary = teachers.Salary;
            teacher.Experience = teachers.Experience;
            dbContext.SaveChanges();
        }
    }
}
