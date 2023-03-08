using API_RentalMovie.Models;
using ClientServer_RentalMovie.Context;

namespace API_RentalMovie.Repositories.Data;

public class PaymentRepository : GeneralRepository<int, Payment>
{
    public PaymentRepository(MyContext context) : base(context)
    {
    }
}
