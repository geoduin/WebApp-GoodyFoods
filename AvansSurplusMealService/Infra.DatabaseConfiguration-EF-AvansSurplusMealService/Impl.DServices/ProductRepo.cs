using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Impl.DServices
{
    public class ProductRepo : IProductRepo
    {
        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByMealId(int mealId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
