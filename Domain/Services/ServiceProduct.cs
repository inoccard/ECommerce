using Domain.Interfaces.Products;
using Domain.Interfaces.Services;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct iProduct;

        public ServiceProduct(IProduct iProduct)
        {
            this.iProduct = iProduct;
        }

        public async Task AddProductAsync(Product product)
        {
            var validateName = product.ValidateStringProperty(product.Name, "Nome");
            var validateValue = product.ValidateDecimalProperty(product.Value, "Valor");

            if (validateName && validateValue)
            {
                product.Status = true;
                await iProduct.Add(product);
            }
        }

        public async Task UpdateProductAsync(Product product)
        {
            var validateName = product.ValidateStringProperty(product.Name, "Nome");
            var validateValue = product.ValidateDecimalProperty(product.Value, "Valor");

            if (validateName && validateValue)
                await iProduct.Update(product);
        }
    }
}
