using OnlineTicketSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actors>> GetAllActors();
        Actors GetActorById(int id);
        void AddActor(Actors addActor);
        Actors UpdateActor(int id, Actors newActor);
        Actors DeleteActor(int id);
    }
}
