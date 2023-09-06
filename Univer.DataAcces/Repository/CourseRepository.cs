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
    public class CourseRepository : ICourseRepository
    {
        private readonly UniverDbContext dbContext;

        public CourseRepository()
        {
            dbContext = new UniverDbContext();
        }
        public async Task Add(Course course)
        {
            dbContext.courses.Add(course);

            dbContext.SaveChanges();
        }

        public async Task Delete(long Id)
        {
            var course = dbContext.courses.FirstOrDefault(u => u.Id == Id);
            dbContext.courses.Remove(course);

            dbContext.SaveChanges();
        }

        public List<Course> GetAllAsync()
             => dbContext.courses.ToList();

        public async Task Update(long Id, Course courses)
        {
            var course = dbContext.courses.FirstOrDefault(u => u.Id == Id);

            course.Name = courses.Name;
            course.Students = courses.Students;
            dbContext.SaveChanges();
        }
    }
}
