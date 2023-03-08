using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class CategoryRepository : GeneralRepository<int, Category>
{
    public CategoryRepository(MyContext context) : base(context)
    {
    }
}
