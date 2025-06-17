using System.ComponentModel.DataAnnotations;

namespace RealEstateApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="Image Url cant be null")]
        public string ImageUrl { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
