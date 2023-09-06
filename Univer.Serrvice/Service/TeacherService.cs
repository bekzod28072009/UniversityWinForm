using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;
using Univer.Service.IService;

namespace Univer.Service.Service
{
    public class TeacherService : ITeacherService
    {
        public readonly ITeacherService repository;
        public TeacherService()
        {
            repository = new TeacherService();
        }
        
        public Task Add(Teacher teacher)
            => repository.Add(teacher);

        public Task Delete(long Id)
            => repository.Delete(Id);

        public List<Teacher> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(long Id, Teacher teacher)
            => repository.Update(Id, teacher);
    }
}
