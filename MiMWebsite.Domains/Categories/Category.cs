using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Domains.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
