using Microsoft.AspNetCore.Mvc;

namespace APIStockVin
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class stocks_du_vin
    {
        [HttpGet(Name = "Domaine viticole")]

        public string commande()
        {
            return "";
        }
    }
        
    
    
        

   
}
