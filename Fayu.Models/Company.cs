using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fayu.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Firma")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Firma adı 2 ile 100 karakter arasında olmalıdır.")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Isim")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Isim 2 ile 100 karakter arasında olmalıdır.")]
        public string CompanyFullName { get; set; }
        [Required]
        [Display(Name = "Kısa Ad")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Kısa ad 2 ile 50 karakter arasında olmalıdır.")]
        public string ShortName { get; set; }
        [StringLength(20, ErrorMessage = "Telefon numarası maksimum 20 karakter olmalıdır.")]
        [Display(Name = "Telefon")]
        public string? CompanyPhone { get; set; }
        [StringLength(20, ErrorMessage = "Vergi numarası maksimum 20 karakter olmalıdır.")]
        [Display(Name = "Vergi NO")]
        public string? CompanyTaxNumber { get; set; }
        [StringLength(255, ErrorMessage = "Adres maksimum 255 karakter olmalıdır.")]
        [Display(Name = "Adres")]
        public string? CompanyAddress { get; set; }
        [StringLength(150, ErrorMessage = "Email adresi maksimum 150 karakter olmalıdır.")]
        [Display(Name = "Email")]
        public string? CompanyEmail { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Son Hareket Tarihi")]
        public DateTime? LastTime { get; set; } = DateTime.Now;

    }
}
