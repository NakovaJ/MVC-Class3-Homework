using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using PizzaApp.Models.Enums;
using PizzaApp.Models.ViewModels;
using PizzaApp.Models.Mappers;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;
            //return View(ordersFromDb);

            List<OrderDetailsViewModel> orderViewModel = ordersFromDb.Select(x => OrderMapper.ToOrderDetailsViewModel(x)).ToList(); ;
           return View(orderViewModel);
            /* List<OrderDetailsViewModel> orderViewModel=ordersFromDb.Select(x => new OrderDetailsViewModel
            {
                PaymentMethod = x.PaymentMethod,
                PizzaName=x.Pizza.Name,
                Price = x.Pizza.Price +50 ,
                UserFullName=$"{x.User.FirstName} {x.User.LastName}",
            })
                .ToList();
          
            return View(orderViewModel);*/

           
            
            /*List<OrderDetailsViewModel> odvm = new List<OrderDetailsViewModel>();

            foreach (Order order in ordersFromDb)
            {
                var viewModel = new OrderDetailsViewModel
                {
                    PaymentMethod = order.PaymentMethod,
                    PizzaName = order.Pizza.Name,
                    UserFullName = order.User.FirstName + ' ' + order.User.LastName,
                    Price = order.Pizza.Price + 50
                };
                odvm.Add(viewModel);
            }*/

        }

        public IActionResult Details(int? id) 
        {
            if (id == null) 
            {
                return new EmptyResult();
            }

            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if(order == null)
            {
                return new EmptyResult();
            }

            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.ToOrderDetailsViewModel(order);

            return View(orderDetailsViewModel);
                

        }
    }
}
