using Univer.DataAcces.IRepository;
using Univer.DataAcces.UniverDbContexts;
using Univer.Domein.Entity;

namespace Univer.DataAcces.Repository
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly UniverDbContext dbContext;

        public FacultyRepository()
        {
            dbContext = new UniverDbContext();
        }
        public async Task Add(Faculity faculty)
        {
            dbContext.faculities.Add(faculty);

            dbContext.SaveChanges();
        }

        public async Task Delete(long Id)
        {
            var faculty = dbContext.faculities.FirstOrDefault(u => u.Id == Id);
            dbContext.faculities.Remove(faculty);

            dbContext.SaveChanges();
        }

        public List<Faculity> GetAllAsync()
             => dbContext.faculities.ToList();

        public async Task Update(long Id, Faculity faculities)
        {
            var faculty = dbContext.faculities.FirstOrDefault(u => u.Id == Id);

            faculty.Name = faculities.Name;
            faculty.Students = faculities.Students;
            dbContext.SaveChanges();
        }
    }
}
