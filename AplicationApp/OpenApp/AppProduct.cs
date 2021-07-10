using Domain.Interfaces.Products;
using Domain.Interfaces.Services;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AplicationApp.OpenApp
{
    public class AppProduct : IProductApp
    {
        private readonly IProduct iProduct;
        private readonly IServiceProduct serviceProduct;

        public AppProduct(IProduct iProduct, IServiceProduct serviceProduct)
        {
            this.iProduct = iProduct;
            this.serviceProduct = serviceProduct;
        }

        public async Task AddProductAsync(Product product) => await serviceProduct.AddProductAsync(product);

        public async Task UpdateProductAsync(Product product) => await serviceProduct.UpdateProductAsync(product);

        public async Task Add(Product product) => await iProduct.Add(product);
        
        public async Task Update(Product product) => await iProduct.Update(product);

        public async Task Delete(Product product) => await iProduct.Delete(product);

        public async Task<Product> Get(int id) => await iProduct.Get(id);

        public async Task<List<Product>> GetAll() => await iProduct.GetAll();

    }
}
