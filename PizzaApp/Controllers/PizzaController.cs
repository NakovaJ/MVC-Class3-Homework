using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;
using PizzaApp.Models.Mappers;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzasFromDb = StaticDb.Pizzas;
            /*List<PizzaViewModel> pizzaViewModelsList = pizzasFromDb.Select(x => new PizzaViewModel()
            {
              Id = x.Id,
              PizzaName = x.Name,
              PriceOfPizza=x.Price,
              PizzaSize=x.PizzaSize
            }).ToList();
            return View(pizzaViewModelsList);*/
            List<PizzaViewModel> pizzaViewModelsList=pizzasFromDb.Select(x => PizzaMapper.toPizzaViewModel(x)).ToList();

            return View(pizzaViewModelsList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza somePizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if(somePizza == null)
            {
                return new EmptyResult();
            }
            PizzaViewModel pizzaViewModel = PizzaMapper.toPizzaViewModel(somePizza);


            return View(pizzaViewModel);
        }
    }
}
