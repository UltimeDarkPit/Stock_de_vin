using System.ComponentModel.DataAnnotations;

namespace ProjetStive
{
    public class client
    {
        [Key]
        public int ID_Client { get; set; }

        [Required]
        public string nom { get; set; }
        [Required]
        public string prenom { get; set; }
        [Required]
        public string mail { get; set; }
        [Required]
        public DateTime DDN { get; set; }
        [Required]
        public string genre { get; set; }
        [Required]
        public string adresse { get; set; }
        [Required]
        public string pays { get; set; }
        [Required]
        public string tel { get; set; }
    }
}
