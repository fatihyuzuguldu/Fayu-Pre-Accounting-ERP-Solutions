using System.ComponentModel.DataAnnotations;

namespace Fayu.Models
{
    public class Acek
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Tarih")]
        public DateOnly AcekTarih { get; set; }
        [Required]
        [Display(Name = "Müşteri")]
        public string AcekMusteri { get; set; }
        [Required]
        [Display(Name = "Çek / Senet")]
        public string AcekSenet { get; set; }
        [Required]
        [Display(Name = "Tutar")]
        public decimal AcekTutar { get; set; }
        [Display(Name = "Sahibi / SeriNo")]
        public string? AcekSeriNo { get; set; }
    }
}
