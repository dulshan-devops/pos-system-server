using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using pos_system.Models.Entities;
using Newtonsoft.Json;

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
        public async Task<IActionResult> AddToCache([FromBody] Product product)
        {
            var cachedProducts = await GetCachedProducts();
            cachedProducts.Add(product);

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

        private async Task<List<Product>> GetCachedProducts()
        {
            var cachedData = await _cache.GetStringAsync("cart.products");
            if (!string.IsNullOrEmpty(cachedData))
            {
                return JsonConvert.DeserializeObject<List<Product>>(cachedData);
            }

            return new List<Product>();
        }

    }
}
