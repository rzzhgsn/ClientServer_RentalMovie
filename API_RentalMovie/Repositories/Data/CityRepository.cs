using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class CityRepository : GeneralRepository<int, City>
{
    public CityRepository(MyContext context) : base(context)
    {
    }
}
