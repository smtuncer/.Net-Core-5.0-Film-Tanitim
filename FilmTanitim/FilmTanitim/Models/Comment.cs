using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTanitim.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CommentTitle { get; set; }
        [Required]
        public string CommentDescription { get; set; }
        public double MovieRating { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
