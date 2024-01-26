using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.Models
{
    public class Ocek
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Tarih")]
        public DateOnly OcekTarih { get; set; }
        [Required]
        [Display(Name = "Müşteri")]
        public string OcekMusteri { get; set; }
        [Required]
        [Display(Name = "Banka")]
        public string OcekBanka { get; set; }
        [Required]
        [Display(Name = "Tutar")]
        public decimal OcekTutar { get; set; }
        [Display(Name = "Sahibi / SeriNo")]
        public string? OcekSeriNo { get; set; }
    }
}
