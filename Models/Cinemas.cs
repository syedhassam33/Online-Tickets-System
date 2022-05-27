using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Models
{
    public class Cinemas
    {
        [Key]
        public int CinId { get; set; }

        [Display(Name = "Cinema Logo")]
        public string LogoURL { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string DescriptionCin { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
