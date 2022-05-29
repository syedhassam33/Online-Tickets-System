using Microsoft.EntityFrameworkCore;
using OnlineTicketSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Data.Services
{
    public class ActorsServices : IActorsServices
    {
        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }

        public void AddActor(Actors addActor)
        {
            _context.Actors.Add(addActor);
            _context.SaveChanges();
        }

        public Actors DeleteActor(int id)
        {
            throw new System.NotImplementedException();
        }

        public  Actors GetActorById(int id)
        {
            var ActById =  _context.Actors.FirstOrDefault(m => m.ActId == id);
            return ActById;
        }

        public async Task<IEnumerable<Actors>> GetAllActors()
        {
            var actorsList = await _context.Actors.ToListAsync();
            return actorsList;
        }

        public Actors UpdateActor(int id, Actors newActor)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
