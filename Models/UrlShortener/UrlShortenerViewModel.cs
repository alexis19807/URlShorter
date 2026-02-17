using System.ComponentModel.DataAnnotations;

namespace UrlShortener.Models
{
    public class UrlShortenerViewModel
    {
        [Required]
        [Url]
        [Display(Name = "URL Larga")]
        public string LongUrl { get; set; } = string.Empty;

        public string? ShortUrl { get; set; }
    }
}
