using System.ComponentModel.DataAnnotations;

namespace AmberAndGrain.Models
{
    public class RecipeDto
    {

        public int Id { get; set; }
        
        [Display(Name="Name")]
        [MaxLength(200,ErrorMessage="Name cannot be more than 200 characters")]
        [Required]
        public string name { get; set; }
        
        [Display(Name = "Percentage Wheat")]
        [Required]
        [Range(0,100)]
        public decimal percentWheat { get; set; }
        
        [Display(Name = "Percentage Corn")]
        [Required]
        [Range(0,100)]
        public decimal percentCorn { get; set; }
        
        [Display(Name = "Barrel Age (in months)")]
        [Required]
        public int barrelAge { get; set; }
        
        [Display(Name = "Barrel Material")]
        [Required]
        public string barrelMaterial { get; set; }
        
        [Display(Name = "Recipe Creator")]
        [Required]
        public string creator { get; set; }
    }
}