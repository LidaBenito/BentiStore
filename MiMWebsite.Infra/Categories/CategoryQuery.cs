using MiMWebsite.Contracts.Categories;
using MiMWebsite.Domains.Categories;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Infra.Categories
{
    internal class CategoryQuery : CategoryQueryRepository
    {
        public List<Category> Categories()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByProductId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
