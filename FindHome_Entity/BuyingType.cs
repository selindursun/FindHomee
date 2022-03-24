using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class BuyingType
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string BuyingName { get; set; }
        public virtual List<HousingType> HousingTypes { get; set; }

    }
}
