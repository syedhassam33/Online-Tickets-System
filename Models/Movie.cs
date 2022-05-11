using OnlineTicketSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Models
{
    public class Movie
    {
        [Key]
        public int MovId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship

        public List<Actors_Movies> Actors_Movies { get; set; }

        //Cienma
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }


        //Producer
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public Producers Producers { get; set; }
    }
}

