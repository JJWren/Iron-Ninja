using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class SpiceHound : Ninja
    {
        public SpiceHound()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public override bool IsFull
        {
            get { return (calorieIntake >= 1200) ? true : false; }
        }

        public override void Consume(IConsumable Item)
        {
            if (!IsFull)
            {
                if (Item.IsSpicy) calorieIntake -= 5;
                calorieIntake += Item.Calories;
                ConsumptionHistory.Add(Item);
                Item.GetInfo();
            }
            else
                Console.WriteLine("Sweet Tooth is too full to eat!");
        }
    }
}