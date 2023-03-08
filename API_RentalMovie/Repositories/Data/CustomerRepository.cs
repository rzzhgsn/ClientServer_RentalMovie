using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class CustomerRepository : GeneralRepository<int, Customer>
{
    public CustomerRepository(MyContext context) : base(context)
    {
    }
}
