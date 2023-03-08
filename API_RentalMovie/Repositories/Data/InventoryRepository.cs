using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class InventoryRepository : GeneralRepository<int, Inventory>
{
    public InventoryRepository(MyContext context) : base(context)
    {
    }
}
