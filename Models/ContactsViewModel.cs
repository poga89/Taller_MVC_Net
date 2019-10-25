using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_taller.Models
{
    public class ContactsViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [Display(Name = "Asunto")]
        public string asunto { get; set; }
    }
}