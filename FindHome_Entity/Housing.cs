using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class Housing
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Age { get; set; }
        public bool Balcony { get; set; }
        public bool Paved { get; set; }             
        public string Address { get; set; }
        public int Price { get; set; }
        
        public int HousingTypeId { get; set; }
        [ForeignKey("HousingTypeId")]
        public virtual HousingType HousingType { get; set; } 


        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; } //ilişki. her evin bir tane sahibi olabilir.
       

    }
}
