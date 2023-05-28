using System.ComponentModel.DataAnnotations;

namespace MovieDatabaseAPI.Models
{
    public enum Statuss
    {
        Deleted = 0,
        Active = 1
    }
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(200, ErrorMessage = "Name must not exceed 200 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ShortDescription is required.")]
        [StringLength(200, ErrorMessage = "ShortDescription must not exceed 200 characters.")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "ReleaseDate is required.")]

        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Director is required.")]

        public string Director { get; set; }
        [Required(ErrorMessage = "Statuss is required.")]
        public Statuss Statuss { get; set; }
        [Required(ErrorMessage = "CreateDate is required.")]
        public DateTime CreateDate { get; set; }
        
    }
}
