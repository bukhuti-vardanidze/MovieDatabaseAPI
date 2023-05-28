using Microsoft.EntityFrameworkCore;
using MovieDatabaseAPI.Db;
using MovieDatabaseAPI.Dtos;
using MovieDatabaseAPI.Models;

namespace MovieDatabaseAPI.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> AddMovie(AddMoviesDto request);
        Task<List<Movie>> GetMovieById(int id);
        Task<List<Movie>> SearchMovie(SearchMovieDto request);
        Task<Movie> UpdateMovie(UpdateMovieDto UpdateRequest);
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
            
             _context.Movies.Add(NewMovie);
            await _context.SaveChangesAsync();
            return NewMovie;
            
        }

        public async Task<List<Movie>> GetMovieById(int id)
        {
            var result = await _context.Movies.Where(x=>x.Id == id).ToListAsync();
            return result;
        }

        public async Task<List<Movie>> SearchMovie(SearchMovieDto request)
        {
            var searchResult = await _context.Movies.Where(x => 
                                  x.Name.Contains(request.Name) ||
                                  x.ShortDescription.Contains(request.ShortDescription) ||
                                  x.Director.Contains(request.Director) ||
                                  x.ReleaseDate.Year.Equals(request.DateTime.Year)
                                  ).ToListAsync();
            return searchResult;
            
        }

        public async Task<Movie> UpdateMovie(UpdateMovieDto UpdateRequest)
        {
            var searchMovie = await _context.Movies.Where(x =>
                                     x.Name.Contains(UpdateRequest.Name)).FirstOrDefaultAsync();

            


            searchMovie.Name = UpdateRequest.Name;
            searchMovie.ShortDescription = UpdateRequest.ShortDescription;
            searchMovie.Director = UpdateRequest.Director;
            searchMovie.Statuss = Statuss.Active;
            searchMovie.CreateDate = DateTime.Now;
               
           _context.Movies.Update(searchMovie);
            await _context.SaveChangesAsync();
            return searchMovie;

        }
    }
}
