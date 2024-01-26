using System.ComponentModel.DataAnnotations;

namespace Fayu.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Görev")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Görev adı 2 ile 100 karakter arasında olmalıdır.")]
        public string TaskName { get; set; }
        [Display(Name = "Açıklama")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Açıklama 2 ile 255 karakter arasında olmalıdır.")]
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        [StringLength(150, ErrorMessage = "Email adresi maksimum 150 karakter olmalıdır.")]
        [Display(Name = "Bitirme Tarihi")]
        public DateTime? CompletedDate { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreatedAt { get; set; } 
        [Display(Name = "Son Tarih")]
        public DateTime? DueDate { get; set; }

    }
}
