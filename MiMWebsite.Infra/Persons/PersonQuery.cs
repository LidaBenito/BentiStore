using MiMWebsite.Contracts.Persons;
using MiMWebsite.Domains.Persons;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Infra.Persons
{
    internal class PersonQuery : PersonQueryRepository
    {
        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> People()
        {
            throw new NotImplementedException();
        }
    }
}
