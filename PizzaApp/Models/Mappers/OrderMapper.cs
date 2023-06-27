using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel ToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                PaymentMethod = order.PaymentMethod,
                PizzaName = order.Pizza.Name,
                UserFullName = order.User.FirstName + ' ' + order.User.LastName,
                Price = order.Pizza.Price + 50,
                UserAddress = order.User.Address

            };
        }
    }
}
