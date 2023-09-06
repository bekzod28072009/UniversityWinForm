using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.DataAcces.IRepository
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllAsync();

        Task Add(Teacher teacher);

        Task Update(long Id, Teacher teacher);

        Task Delete(long Id);
    }
}
