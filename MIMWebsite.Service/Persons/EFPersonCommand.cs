using AutoMapper;
using MiMWebsite.Contracts.Persons;
using MiMWebsite.Domains.Persons;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Persons
{
    public class EFPersonCommand : PersonCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;
        private readonly IMapper mapper;

        public EFPersonCommand(BentiStoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public Person Add(Person person)
        {
            dbContext.People.Add(person);
            dbContext.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
           var person = dbContext.People.SingleOrDefault(personId=>personId.Id==id);
            dbContext.People.Remove(person);
            dbContext.SaveChanges();

           
        }

        public Person Update(Person person)
        {
           Person currentPerson = dbContext.People.SingleOrDefault(p=>p.Id == person.Id);
            if (!(currentPerson is null))
            {
                mapper.Map(person, currentPerson);
                dbContext.SaveChanges();
                return currentPerson;
            }
            return null;
        }
    }
}
