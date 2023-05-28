using System.ComponentModel.DataAnnotations;

namespace MovieDatabaseAPI.Dtos
{
    public class AddMoviesDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(200, ErrorMessage = "Name must not exceed 200 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ShortDescription is required.")]
        [StringLength(200, ErrorMessage = "ShortDescription must not exceed 200 characters.")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "Year of release is required.")]
        
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Director is required.")]

        public string Director { get; set; }
        
    }
}
