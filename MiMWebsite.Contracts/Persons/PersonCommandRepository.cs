using MiMWebsite.Domains.Persons;

namespace MiMWebsite.Contracts.Persons
{
	public interface PersonCommandRepository
	{
		void Delete(int id);
		Person Add(Person person);
		Person Update(Person person);

	}
}
