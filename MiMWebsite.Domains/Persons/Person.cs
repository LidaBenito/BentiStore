using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Domains.Persons
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public List<Product>  Products{ get; set; }
    }
}
