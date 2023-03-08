using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class FilmCategoryRepository : GeneralRepository<int, FilmCategory>
{
    public FilmCategoryRepository(MyContext context) : base(context)
    {
    }
}
