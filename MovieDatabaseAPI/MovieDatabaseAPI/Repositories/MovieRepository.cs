using MovieDatabaseAPI.Db;
using MovieDatabaseAPI.Dtos;
using MovieDatabaseAPI.Models;

namespace MovieDatabaseAPI.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> AddMovie(AddMoviesDto request);
    }
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context) 
        {
            _context = context;
        }

        public async Task<Movie> AddMovie(AddMoviesDto request)
        {
            var NewMovie = new Movie
            {
                Name = request.Name,
                ShortDescription = request.ShortDescription,
                Director = request.Director,
                ReleaseDate = request.ReleaseDate,
                Statuss = Statuss.Active,
                CreateDate = DateTime.Now
            };
            
             _context.Add(NewMovie);
            await _context.SaveChangesAsync();
            return NewMovie;
            
        }
    }
}
