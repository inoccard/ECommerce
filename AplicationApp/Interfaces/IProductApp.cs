using AplicationApp.Interfaces;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Products
{
    public interface IProductApp : IGenericApp<Product>
    {
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
    }
}
