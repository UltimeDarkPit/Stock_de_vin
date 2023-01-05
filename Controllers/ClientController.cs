using Microsoft.AspNetCore.Mvc;
using ProjetStive.Helpers;

namespace ProjetStive.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClientController
    {
        [HttpGet(Name = "GetClient")]
        public List<client> GetClient()
        {
            using ProjetStiveContext context = new();

            List<client> client = context.client.ToList();
            
            return client;
        }
    }
}