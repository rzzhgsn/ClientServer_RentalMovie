using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class StoreRepository : GeneralRepository<int, Store>
{
    public StoreRepository(MyContext context) : base(context)
    {
    }
}
