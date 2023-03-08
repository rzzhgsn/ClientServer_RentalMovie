using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class FilmActorRepository : GeneralRepository<int, FilmActor>
{
    public FilmActorRepository(MyContext context) : base(context)
    {
    }
}
