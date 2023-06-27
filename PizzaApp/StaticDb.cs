using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza()
            {
                Id=1,
                Name="Cappriciosa",
                Price=300,
                IsOnPromotion=true,
                PizzaSize=PizzaSizeEnum.Normal,
                HasExtras=true
            },
            new Pizza()
            {
                Id=2,
                Name="Pepperoni",
                Price=350,
                IsOnPromotion=false,
                PizzaSize=PizzaSizeEnum.Family,
                HasExtras=false
            }
        };


        public static List<User> Users = new List<User>
        {
            new User() 
            {
              Id=1,
              FirstName="Jelena",
              LastName="Nakova",
              PhoneNumber="070123456",
              Address="street1"
            },
            new User() 
            {
             Id=2,
              FirstName="Mihaela",
              LastName="Nakov",
              PhoneNumber="070678910",
              Address="street2"

            }

        };

        public static List<Order> Orders = new List<Order>
        { 
          new Order()
          {
              Id=1,
              PizzaId=1,
              Pizza=Pizzas.FirstOrDefault(),
              UserId=1,
              User=Users.FirstOrDefault(),
              PaymentMethod=PaymentMethodEnum.Cash
          },
           new Order()
          {
              Id=2,
              PizzaId=2,
              Pizza=Pizzas.FirstOrDefault(x=>x.Id==2),
              UserId=2,
              User=Users.FirstOrDefault(x=>x.Id==2),
              PaymentMethod=PaymentMethodEnum.Card
          }
        };
    }
}
