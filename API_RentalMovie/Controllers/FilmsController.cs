using API_RentalMovie.Base;
using API_RentalMovie.Models;
using API_RentalMovie.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_RentalMovie.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class FilmsController : BaseController<int, Film, FilmRepository>
{
    public FilmsController(FilmRepository repository) : base(repository)
    {

    }
}