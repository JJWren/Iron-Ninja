using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
                {
                    new Food("Pepperoni Pizza", 450, true, false),
                    new Food("BBQ Bacon Hamburger", 670, false, true),
                    new Food("Chicago Style Hotdog", 390, false, false),
                    new Food("Jalapeno Sweet Bread", 250, true, true),
                    new Food("French Fries", 300, false, false),
                    new Food("Cajun Fries", 300, true, false),
                    new Food("Fudgesicle", 250, false, true),
                    new Drink("Arnold Palmer", 170, false),
                    new Drink("Water", 0, false),
                    new Drink("Bloody Mary", 210, true),
                    new Drink("Yuengling", 180, false),
                    new Drink("Mike's Hard Lemonade", 180, false),
                    new Drink("Apple Juice", 110, false),
                };
        }

        public IConsumable Serve()
        {
            var rng = new Random();
            int buffetIdx = rng.Next(Menu.Count);

            return Menu[buffetIdx];
        }
    }
}