using System.ComponentModel.DataAnnotations;

namespace ProjetStive
{
    public class quantite
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ID_Client { get; set; }
        [Required]
        public string Marque { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Nbcommande { get; set; }
        [Required]
        public int AnneeBtl { get; set; }
        [Required]
        public DateTime DateCommande { get; set; }

    }
}

    

