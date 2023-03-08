using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class AccountRoleRepository : GeneralRepository<int, AccountRole>
{
    public AccountRoleRepository(MyContext context) : base(context)
    {
    }
}
