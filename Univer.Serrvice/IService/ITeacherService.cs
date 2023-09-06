using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.Service.IService
{
    public interface ITeacherService
    {
        List<Teacher> GetAllAsync();

        Task Add(Teacher teacher);

        Task Update(long Id, Teacher teacher);

        Task Delete(long Id);
    }
}
