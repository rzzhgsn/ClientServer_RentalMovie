using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class CountryRepository : GeneralRepository<int, Country>
{
    public CountryRepository(MyContext context) : base(context)
    {
    }
}
