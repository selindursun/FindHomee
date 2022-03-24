using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class Owner
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Lütfen ad alanını doldurunuz")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Lütfen soyad alanını doldurunuz")]
        public string Surname { get; set; }
        public String PhoneNumber { get; set; }       
        public virtual List<Housing> Housings { get; set; } //bire çok ilişkiden yaptım.her ev sahibinin birden çok evi olanilir.

    }
}
