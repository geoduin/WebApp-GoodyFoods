using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface IProductRepo
    {
        Product GetProduct();
        Product GetProductById(int id);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> GetProductByMealId(int mealId);
    }
}
