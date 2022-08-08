using MiMWebsite.Contracts.Persons;
using MiMWebsite.Domains.Persons;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Persons
{
    public class EFPersonCommand : PersonCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFPersonCommand(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Person Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
