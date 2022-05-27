using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineTicketSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Data
{
    public class AppDbInitializer
    {
        public static void AddingData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinemas>()
                    {
                        new Cinemas()
                        {
                            Name = "Cinema 1",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            DescriptionCin = "This is the description of the first cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Cinema 2",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            DescriptionCin = "This is the description of the second cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Cinema 3",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            DescriptionCin = "This is the description of the third cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Cinema 4",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            DescriptionCin = "This is the description of the fourth cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Cinema 5",
                            LogoURL = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            DescriptionCin = "This is the description of the fifth cinema"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                    
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImgURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
            context.SaveChanges();
        }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actors>()
                    {
                        new Actors()
                        {
                            FullName = "Actor 1",
                            AboutAct = "This is the Personal Details of the first actor",
                            ActPictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actors()
                        {
                            FullName = "Actor 2",
                            AboutAct = "This is the Personal Details of the second actor",
                            ActPictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor 3",
                            AboutAct = "This is the Personal Details of the second actor",
                            ActPictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor 4",
                            AboutAct = "This is the details of the second actor",
                            ActPictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor 5",
                            AboutAct = "This is the Personal Details of the second actor",
                            ActPictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producers>()
                    {
                        new Producers()
                        {
                            ProdFullName = "Producer 1",
                            ProdDetails = "This is the bio of the first actor",
                            ProdPictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producers()
                        {
                            ProdFullName = "Producer 2",
                            ProdDetails = "This is the bio of the second actor",
                            ProdPictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producers()
                        {
                            ProdFullName = "Producer 3",
                            ProdDetails = "This is the bio of the third actor",
                            ProdPictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producers()
                        {
                            ProdFullName = "Producer 4",
                            ProdDetails = "This is the bio of the fourth actor",
                            ProdPictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producers()
                        {
                            ProdFullName = "Producer 5",
                            ProdDetails = "This is the bio of the fifth actor",
                            ProdPictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actors_Movies>()
                    {
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actors_Movies()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actors_Movies()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actors_Movies()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actors_Movies()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
