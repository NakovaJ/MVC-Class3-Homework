using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
    public class PizzaViewModel
    {
        //Create Pizza ViewModel with the following properties a. Id b. Name c. Price d. PizzaSize
        public int Id { get; set; }

        public string PizzaName { get; set; }
        public decimal PriceOfPizza { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
    }
}
