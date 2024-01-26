using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.Models
{
    public class DailyFinancials
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bakiye")]
        public decimal Balance { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Açıklama maksimum 255 karakter olmalıdır.")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedAt { get; set; } 
        [Display(Name = "Tarih")]
        public DateTime? EntryDate { get; set; }
        [Display(Name = "Güncelleme Tarihi")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;


    }
}
