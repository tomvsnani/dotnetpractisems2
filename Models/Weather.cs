using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Weather
    {
        [Key]
        public int Id { get; set; }

       
        public string? Name { get; set; }= string.Empty;
        [MinLength(5)]
        public string? Description { get; set; }
        public int WeatherId { get; set;}
    }
}
