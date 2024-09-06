using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using pos_system.Models.Entities;
using Newtonsoft.Json;
using pos_desktop_app.models.Custom_Models;
using System.Diagnostics;

namespace pos_system.Controllers
{
    public class CacheController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public CacheController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpPost("cache/product/add")]
        public async Task<IActionResult> AddToCache([FromBody] ProductInCart product)
        {
            var cachedProducts = await GetCachedProducts();
            var existingProduct = cachedProducts.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
                existingProduct.Total = existingProduct.Price * existingProduct.Quantity;
            }
            else
            {
                cachedProducts.Add(product);
            }

            var serializedProducts = JsonConvert.SerializeObject(cachedProducts);

            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1) // Set your expiration time
            };
            await _cache.SetStringAsync("cart.products", serializedProducts, options);

            return Ok(cachedProducts);
        }

        [HttpGet("cache/product/retrieve")]
        public async Task<IActionResult> RetrieveFromCache()
        {
            var cachedProducts = await GetCachedProducts();
            return Ok(cachedProducts);
        }

        [HttpPost("cache/product/clear")]
        public async Task<IActionResult> ClearCache()
        {
            var cachedProducts = await GetCachedProducts();
            await _cache.RemoveAsync("cart.products");
            return Ok(cachedProducts);
        }

        [HttpGet("cache/cart/total")]
        public async Task<IActionResult> RetrieveCachedProductsTotal()
        {
            var cachedProducts = await GetCachedProducts();
            double total = cachedProducts.Sum(product => product.Price * product.Quantity);

            return Ok(total);
        }

        private async Task<List<ProductInCart>> GetCachedProducts()
        {
            var cachedData = await _cache.GetStringAsync("cart.products");
            if (!string.IsNullOrEmpty(cachedData))
            {
                return JsonConvert.DeserializeObject<List<ProductInCart>>(cachedData);
            }

            return new List<ProductInCart>();
        }

    }
}
