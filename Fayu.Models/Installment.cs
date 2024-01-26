using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.Models
{
    public class Installment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tutar")]
        public decimal Balance { get; set; }
        [Display(Name = "Taksit Numarası")]
        public string? InstallmentLoan { get; set; }
        [Required]
        [Display(Name = "Banka")]
        public string InstallmentBank { get; set; }
        [StringLength(255, ErrorMessage = "Taksit Sahibi maksimum 255 karakter olmalıdır.")]
        [Display(Name = "Taksit Sahibi")]
        public string? InstallmentOwner { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime? CreatedAt { get; set; } 
        [Required]
        [Display(Name = "Tarih")]
        public DateTime? EntryDate { get; set; }


    }
}
