using MiMWebsite.Domains.Persons;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Persons
{
	public interface PersonQueryRepository
	{
		List<Person> People();
		Person GetById(int id);


	}
}
