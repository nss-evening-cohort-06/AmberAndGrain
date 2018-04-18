using System.Collections.Generic;
using System.Web.Mvc;

namespace AmberAndGrain.Models
{
    public class AddBatchDto
    {
        public IEnumerable<SelectListItem> Recipes { get; set; }

        public int RecipeId { get; set; }
        public string Cooker { get; set; }
    }
}