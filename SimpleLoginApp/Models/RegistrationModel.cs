using System.ComponentModel.DataAnnotations;

namespace SimpleLoginApp.Models
{
    public class RegistrationModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Person ID")]
        public string PersonId { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [Range(0, 150)]
        public int Age { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
} 