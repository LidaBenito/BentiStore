using Microsoft.EntityFrameworkCore;
using MiMWebsite.Contracts.Persons;
using MiMWebsite.Domains.Persons;
using MiMWebsite.Service.Common;
using System;

namespace MiMWebsite.Service.Persons
{
    public class EFPersonRepository : PersonRepository
    
    {
        private readonly BenDbcontext dbContext;

        public EFPersonRepository(BenDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Person Add(Person person)
        {
            dbContext.People.Add(person);
            dbContext.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            var result = dbContext.People.SingleOrDefault(personId => personId.Id == id);
            dbContext.People.Remove(result);
            dbContext.SaveChanges();
        }

        public Person GetById(int id)
        {
            var result = dbContext.People.SingleOrDefault(personId => personId.Id == id);
            return result;
        }

        public List<Person> People()
        {
            var result = dbContext.People.AsNoTracking().ToList();
            return result;

        }

        public Person Update(Person person)
        {
            var currentPerson = dbContext.People.SingleOrDefault(personId => personId.Id ==person.Id);
            if (!(currentPerson is null))
            {
                currentPerson.Address=person.Address;
                currentPerson.Mobile = person.Mobile;
                currentPerson.FatherName = person.FatherName;
                currentPerson.FirstName = person.FirstName;
                currentPerson.LastName = person.LastName;
                dbContext.Update(currentPerson);
                dbContext.SaveChanges();
                return currentPerson;
            }

                return null;
        }
    }
}
