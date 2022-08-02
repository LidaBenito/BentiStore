using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Domains.Categories
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
