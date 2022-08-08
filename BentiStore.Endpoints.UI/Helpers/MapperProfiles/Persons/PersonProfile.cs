using AutoMapper;
using MiMWebsite.Domains.Persons;

namespace BentiStore.Endpoints.UI.Helpers.MapperProfiles.Persons

{
    public class PersonProfile:Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, Person>();

        }
    }
}
