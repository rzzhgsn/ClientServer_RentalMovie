using API_RentalMovie.Base;
using API_RentalMovie.Models;
using API_RentalMovie.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_RentalMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : BaseController<int, Language, LanguageRepository>
    {
        public LanguagesController(LanguageRepository repository) : base(repository)
        {

        }
    }
}
