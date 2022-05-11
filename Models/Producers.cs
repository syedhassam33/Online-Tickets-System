using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Models
{
    public class Producers
    {
        [Key]
        public int ProdId { get; set; }
        [Display(Name ="Picture")]
        public string ProdPictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string ProdFullName { get; set; }
        [Display(Name = "About")]
        public string ProdDetails { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
