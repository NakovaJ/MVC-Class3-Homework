using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel toPizzaViewModel(Pizza pizza)
        {
            if (pizza.HasExtras == true)
            {
                pizza.Price = pizza.Price + 10;
            }
            return new PizzaViewModel
            {
             Id = pizza.Id,
             PizzaName=pizza.Name,
             PriceOfPizza=pizza.Price,
             PizzaSize=pizza.PizzaSize,
             IsOnPromotion=pizza.IsOnPromotion,
            };
        }
    }
}
