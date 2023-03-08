using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class AddressRepository : GeneralRepository<int, Address>
{
    public AddressRepository(MyContext context) : base(context)
    {
    }
}
