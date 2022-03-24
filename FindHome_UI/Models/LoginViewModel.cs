using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindHome_UI.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string Surname { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakter olmalıdır!")]     
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
