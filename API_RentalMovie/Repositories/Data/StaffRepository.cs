using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class StaffRepository : GeneralRepository<int, Staff>
{
    public StaffRepository(MyContext context) : base(context)
    {
    }
}
