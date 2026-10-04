using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public string? Summary { get; set; }

        public string? Slug { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsPublished { get; set; } = true;
    }
}