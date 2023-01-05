using Microsoft.AspNetCore.Mvc;
using ProjetStive.Helpers;
    
namespace ProjetStive.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Liste_de_vinController
    {
        [HttpGet(Name = "liste_de_vin")]
        public List<liste_de_vin> Getliste_de_vin()
        {
            using ProjetStiveContext context = new();

            List<liste_de_vin> liste_de_vin = context.liste_de_vin.ToList();

            //liste_de_vin.AddRange();

            return liste_de_vin;
        }
    
       
    }




}