using Microsoft.AspNetCore.Mvc;
using ProjetStive.Helpers;

namespace ProjetStive.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class QuantiteController
    {
        [HttpGet(Name = "Getquantite")]
        public List<quantite> GetQuantite()
        {
            using ProjetStiveContext context = new();

            List<quantite> quantite = context.quantite.ToList();
            
            return quantite;
        }
    }
}