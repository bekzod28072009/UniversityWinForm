using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.DataAcces.IRepository
{
    public interface IStudentRepository
    {
        List<Student> GetAllAsync();

        Task Add(Student student);

        Task Update(long Id, Student student);

        Task Delete(long Id);
    }
}
