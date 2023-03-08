using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class ActorRepository : GeneralRepository<int, Actor>
{
    public ActorRepository(MyContext context) : base(context)
    {
    }
}
