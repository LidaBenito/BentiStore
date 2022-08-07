using MiMWebsite.Domains.Persons;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Persons
{
	public interface PersonRepository
	{
		//List<Person> People();
		//Person GetById(int id);
		//void Delete(int id);
		Person Add(Person person);
		//Person Update(Person person);

	}
}
