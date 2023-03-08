using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class RoleRepository : GeneralRepository<int, Role>
{
    public RoleRepository(MyContext context) : base(context)
    {
    }
}
