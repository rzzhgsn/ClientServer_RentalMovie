using API_RentalMovie.Base;
using API_RentalMovie.Models;
using API_RentalMovie.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_RentalMovie.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class RolesController : BaseController<int, Role, RoleRepository>
{
    public RolesController(RoleRepository repository) : base(repository)
    {
    }
}
