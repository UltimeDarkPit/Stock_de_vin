using System.ComponentModel.DataAnnotations;

namespace APIStockVin
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
