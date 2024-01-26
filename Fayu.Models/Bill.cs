using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fayu.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fatura Türü")]
        public decimal TransactionType { get; set; }

        [Required]
        [Display(Name = "Stok Adı")]
        public string StockName { get; set; }

        [Required]
        [Display(Name = "Miktar")]
        public decimal StockAmount { get; set; }

        [Display(Name = "Kdv")]
        public decimal? StockTax { get; set; }

        [Display(Name = "İskonto1")]
        public decimal? StockDiscount1 { get; set; }

        [Display(Name = "İskonto2")]
        public decimal? StockDiscount2 { get; set; }

        [Required]
        [Display(Name = "Birim Fiyat")]
        public decimal? StockUnit { get; set; }

        [Required]
        [Display(Name = "Toplam Tutar")]
        public decimal? StockTotalAmount { get; set; }

        [Required]
        [Display(Name = "Toplam İndirim")]
        public decimal? StockTotalDisc { get; set; }

        [Required]
        [Display(Name = "Ara Toplam")]
        public decimal? StockSubTotal { get; set; }

        [Required]
        [Display(Name = "Toplam Kdv")]
        public decimal? StockSubTax { get; set; }

        [Required]
        [Display(Name = "Ara Toplam")]
        public decimal? StockAllTotal { get; set; }

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
