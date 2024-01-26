using System.ComponentModel.DataAnnotations;

namespace Fayu.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tedarikçi")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Tedarikçi adı 2 ile 150 karakter arasında olmalıdır.")]
        public string SupplierName { get; set; }
        [Required]
        [Display(Name = "Isim")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Isim 2 ile 150 karakter arasında olmalıdır.")]
        public string SupplierFullName { get; set; }
        [Required]
        [Display(Name = "Kısa Ad")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Kısa ad 2 ile 50 karakter arasında olmalıdır.")]
        public string ShortName { get; set; }
        [StringLength(20, ErrorMessage = "Telefon numarası maksimum 20 karakter olmalıdır.")]
        [Display(Name = "Telefon")]
        public string? SupplierPhone { get; set; }
        [StringLength(20, ErrorMessage = "Vergi numarası maksimum 20 karakter olmalıdır.")]
        [Display(Name = "Vergi NO")]
        public string? SupplierTaxNumber { get; set; }
        [StringLength(255, ErrorMessage = "Adres maksimum 255 karakter olmalıdır.")]
        [Display(Name = "Adres")]
        public string? SupplierAddress { get; set; }
        [StringLength(150, ErrorMessage = "Email adresi maksimum 150 karakter olmalıdır.")]
        [Display(Name = "Email")]
        public string? SupplierEmail { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Son Hareket Tarihi")]
        public DateTime? LastTime { get; set; } = DateTime.Now;


    }
}
