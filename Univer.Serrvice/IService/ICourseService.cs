using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.Service.IService
{
    public interface ICourseService
    {
        List<Course> GetAllAsync();

        Task Add(Course course);

        Task Update(long Id, Course course);

        Task Delete(long Id);
    }
}
