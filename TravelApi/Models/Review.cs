// using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Review {
    // ReviewId, Country, City, Rating, Review, Author
    public int ReviewId {get; set;} 
    public string Description {get; set;} 
    public string Country {get; set;} 
    public string City {get; set;} 
    public int Rating {get; set;} 
    // [Required]
    public string Author {get; set;} 
    public int DescriptionCount {get; set;} 
  }
}