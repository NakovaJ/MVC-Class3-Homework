﻿using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp.Models.Domain
{
    public class Pizza
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
        public bool HasExtras { get; set; }
        public bool IsOnPromotion { get; set; }
        //Add property IsOnPromotion to the Pizza Model
        //and the PizzaViewModel if there isn't already a property called IsPromotion.
        //Use an if expression in the Pizza Details View and
        //add a h4 tag that will say whether the pizza is on promotion
        //or not depending on the property IsOnPromotion.
    }
}
