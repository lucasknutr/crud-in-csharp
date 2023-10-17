using CRUD.Contracts.Breakfast.AddMovieRequest;
using CRUD.Contracts.Breakfast.MovieResponse;
using CRUD.Contracts.UpsertMovieRequest;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

namespace CRUD.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet("/movies")]
        public IActionResult GetMovies(MovieResponse request)
        {
            return Ok("ALL MOVIES: " + request);
        }

        [HttpPost("/movies")]
        public IActionResult CreateMovie(CreateMovieRequest request)
        {
            return Ok(request);
        }
        [HttpGet("/movies/{id}")]
        public IActionResult GetMovie(MovieResponse request)
        {
            return Ok(request);
        }
        [HttpPut("/movies/{id}")]
        public IActionResult UpdateMovie(UpsertMovieRequest request)
        {
            return Ok(request);
        }
        [HttpDelete("/movies/{id}")]
        public IActionResult DeleteMovie(MovieResponse request)
        {
            return Ok(request);
        }
    }
}