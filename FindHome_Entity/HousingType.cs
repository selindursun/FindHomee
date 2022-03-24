using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class HousingType
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string HousingTypeName { get; set; }
        public int BuyingTypeId { get; set; }
        [ForeignKey("BuyingTypeId")]
        public virtual BuyingType BuyingType { get; set; } 

        public virtual List<HousingType> HousingTypes { get; set; } // bir type da birden çok ev olabilir.




    }
}
