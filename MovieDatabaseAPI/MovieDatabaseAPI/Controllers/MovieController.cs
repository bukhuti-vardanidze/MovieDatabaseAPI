using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDatabaseAPI.Dtos;
using MovieDatabaseAPI.Repositories;

namespace MovieDatabaseAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository) 
        {
            _movieRepository = movieRepository;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddMovies([FromQuery]AddMoviesDto MovieRequest)
        {
            var result = await _movieRepository.AddMovie(MovieRequest);
            return Ok(result);
        }
    }
}
