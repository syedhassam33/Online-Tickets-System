using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Models
{
    public class Cinema
    {
        [Key]
        public int CinId { get; set; }
        public string LogoURL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
