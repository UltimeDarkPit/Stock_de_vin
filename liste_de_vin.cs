using System.ComponentModel.DataAnnotations;

namespace ProjetStive
{
    public class liste_de_vin
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public string Nom { get; set; }
        [Required]

        public string Region { get; set; }
        [Required]

        public int annee { get; set; }
    }
}
