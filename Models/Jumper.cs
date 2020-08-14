using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSzkolenie.Models
{
    public class Jumper
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public float Weight { get; set; }

        public float Height { get; set; }

        public float PersonalBest { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

    }
}
