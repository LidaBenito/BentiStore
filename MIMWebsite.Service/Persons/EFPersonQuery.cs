using Microsoft.EntityFrameworkCore;
using MiMWebsite.Contracts.Persons;
using MiMWebsite.Domains.Persons;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Persons
{
    public class EFPersonQuery : PersonQueryRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFPersonQuery(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Person GetById(int id)=>dbContext.People.AsNoTracking().SingleOrDefault(personId => personId.Id == id);
     
        public List<Person> People()=> dbContext.People.AsNoTracking().ToList();
     
    }
}
