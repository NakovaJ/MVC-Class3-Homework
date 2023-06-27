using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public decimal Price { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        //Extend the OrderViewModel with property UserAddress
        //from the address of the user and add it to the OrderDetailsViewModel Mapper.
        public string UserAddress { get; set; }

    }
}
