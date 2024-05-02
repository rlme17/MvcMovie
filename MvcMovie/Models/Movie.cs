using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

[Table("TestMovieRichard")]
public class Movie
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Please Input Title")]
    public string Title { get; set; }

    [DataType(DataType.Date)]
    [Column("Release_Date")]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}