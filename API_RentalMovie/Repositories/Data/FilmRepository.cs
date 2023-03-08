using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class FilmRepository : GeneralRepository<int, Film>
{
    public FilmRepository(MyContext context) : base(context)
    {
    }
}
