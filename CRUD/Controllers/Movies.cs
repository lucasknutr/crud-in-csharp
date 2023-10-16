using CRUD.Contracts.Breakfast.AddMovieRequest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRUD.Controllers

[ApiController]
public class MoviesController : ControllerBase
{
    [HttpPost("/movies")]
    public IActionResult CreateMovie(CreateMovietRequest request)
    {
        return Ok(request);
    }
}