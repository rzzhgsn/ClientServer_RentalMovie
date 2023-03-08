using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class RentalRepository : GeneralRepository<int, Rental>
{
    public RentalRepository(MyContext context) : base(context)
    {
    }
}
