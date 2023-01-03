using System.ComponentModel.DataAnnotations;

namespace APIStockVin
{
    public class entreprise
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Marque_de_Vin { get; set; }
        [Required]
        public string Type_de_Vin { get; set; }
        [Required]
        public int Nbre_de_Vin_Commande { get; set; }
        [Required]
        public int Annee_de_la_Bouteille { get; set; }
        [Required]
        public int Date_de_Commande { get; set; }
        
        

    }
}
