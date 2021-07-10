using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IServiceProduct
    {
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
    }
}
