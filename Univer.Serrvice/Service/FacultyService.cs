using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;
using Univer.Service.IService;

namespace Univer.Service.Service
{
    public class FacultyService : IFacultyService
    {
        public readonly IFacultyService repository;

        public FacultyService()
        {
            repository = new FacultyService();
        }

        public Task Add(Faculity faculity)
            => repository.Add(faculity);

        public Task Delete(long Id)
            => repository.Delete(Id);

        public List<Faculity> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(long Id, Faculity faculity)
            => repository.Update(Id, faculity);
    }
}
