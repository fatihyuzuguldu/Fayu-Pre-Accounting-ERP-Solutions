using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fayu.Models
{
    public class FinancialEnt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bakiye")]
        public decimal Balance { get; set; }
        [Display(Name = "Tür")]
        public decimal MovementType { get; set; }
        [StringLength(255, ErrorMessage = "Açıklama maksimum 255 karakter olmalıdır.")]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Tarih")]
        public DateTime? EntryDate { get; set; }
        [Display(Name = "Güncelleme Tarihi")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public int? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        [ValidateNever]
        public Supplier Supplier { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; }




    }
}
