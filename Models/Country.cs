using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSzkolenie.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Nazwa kraju")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Rekord kraju")]
        public float CountryRecord { get; set; }

        public virtual List<Jumper> Jumpers { get; set; }

    }
}
