using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmberAndGrain.Models;
using AmberAndGrain.Services;

namespace AmberAndGrain.Controllers
{
    public class BatchController : Controller
    {
        // GET: Batch/Create
        [HttpGet]
        public ActionResult Create()
        {
            var recipeRepository = new RecipeRepository();
            var recipes = recipeRepository.GetAll();
            var viewModel = new AddBatchDto { Recipes = recipes.Select(x => new SelectListItem { Text = x.name, Value = x.Id.ToString() }) };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(AddBatchDto addBatch)
        {
            var batchRepository = new BatchRepository();
            batchRepository.Create(addBatch.RecipeId,addBatch.Cooker);

            return RedirectToAction("Create");
        }
    }
}