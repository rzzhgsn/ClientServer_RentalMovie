using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class LanguageRepository : GeneralRepository<int, Language>
{
    public LanguageRepository(MyContext context) : base(context)
    {
    }
}
