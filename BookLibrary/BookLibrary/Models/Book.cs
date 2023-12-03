using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace BookLibrary.Models
{
    public class Book:BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string Author { get; set; }
        public int GenreId { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public DateTime LibraryAddDate { get; set; }
        public int CopiesInLibrary { get; set; }
        public int CopiesOutLibrary { get; set; }
        public int AvailableCopies {  get; set; }
        public bool EVersion {  get; set; }

        [ForeignKey("GenreId")]
        [ValidateNever]

        public Genre? Genre { get; set; }
    }
}
