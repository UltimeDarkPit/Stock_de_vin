using Microsoft.AspNetCore.Mvc;
using ProjetStive.Helpers;

namespace ProjetStive.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Societe_NegosudController
    {
        [HttpGet(Name = "societe_negosud")]
        public List<societe_negosud> GetSociete_Negosud()
        {
            using ProjetStiveContext context = new();

            List<societe_negosud> societe_negosud = context.societe_negosud.ToList();
            
            return societe_negosud;
        }
    }
}