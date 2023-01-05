using System.ComponentModel.DataAnnotations;

namespace APIStockVin
{
    public class client
    {
        // identifiant du client
        [Key]
        public int ID_Client { get; set; }

        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        string E_mail { get; set; }
        [Required]
        public DateTime DDN { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string Pays { get; set; }
        [Required]
        public string Tel { get; set; }
        


    }
}
