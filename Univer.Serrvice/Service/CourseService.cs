using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;
using Univer.Service.IService;

namespace Univer.Service.Service
{
    public class CourseService : ICourseService
    {
        public readonly ICourseService repository;
        public CourseService()
        {
            repository = new CourseService();
        }

        public Task Add(Course course)
            => repository.Add(course);

        public Task Delete(long Id)
            => repository.Delete(Id);

        public List<Course> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(long Id, Course course)
            => repository.Update(Id, course);
    }
}
