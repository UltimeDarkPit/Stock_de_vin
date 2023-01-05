using Microsoft.AspNetCore.Mvc;
using ProjetStive.Helpers;

namespace ProjetStive.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StockController
    {
        [HttpGet(Name = "stock")]
        public List<stock> Getstock()
        {
            using ProjetStiveContext context = new();

            List<stock> stock = context.stock.ToList();
            
            return stock;
        }
    }
}