using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Models
{
    public class Actors
    {
        [Key]
        public int ActId { get; set; }

        [Display(Name = "Picture")]
        public string ActPictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required!")]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "You should meet the required condition of Min 3 or Max 50 Characters.")]
        public string FullName { get; set; }
        [Display(Name = "About")]

        public string AboutAct { get; set; }

        //Relationship
        public List<Actors_Movies> Actor_Movie { get; set; }

    }
}
