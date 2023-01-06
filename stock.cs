using System.ComponentModel.DataAnnotations;

namespace ProjetStive
{
    public class stock
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Marque { get; set; }
        [Required]
        public int Nombre { get; set; }
    }
}

