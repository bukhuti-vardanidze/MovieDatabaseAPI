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

        [HttpGet("ById")]
        public async Task<IActionResult> GetMovieById([FromQuery]int Id)
        {
            var result =await _movieRepository.GetMovieById(Id);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchMovie([FromQuery] SearchMovieDto SearchRequest)
        {
            var result = await _movieRepository.SearchMovie(SearchRequest);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateMovie([FromQuery]UpdateMovieDto MovieRequest)
        {
            var result = await _movieRepository.UpdateMovie(MovieRequest);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMovie([FromQuery] string Title)
        {
            var result = await _movieRepository.DeleteMovie(Title);
            return Ok(result);
        }
    }
}
