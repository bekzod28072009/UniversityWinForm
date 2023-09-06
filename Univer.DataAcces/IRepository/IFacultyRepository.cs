using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domein.Entity;

namespace Univer.DataAcces.IRepository
{
    public interface IFacultyRepository
    {
        List<Faculity> GetAllAsync();

        Task Add(Faculity faculity);

        Task Update(long Id, Faculity faculity);

        Task Delete(long Id);
    }
}
