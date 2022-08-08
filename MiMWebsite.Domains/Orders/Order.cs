using MiMWebsite.Domains.Categories;
using MiMWebsite.Domains.Persons;
using MiMWebsite.Domains.Products;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Domains.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Person Person { get; set; } 
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
