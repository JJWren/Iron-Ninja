using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class SweetTooth : Ninja
    {
        public SweetTooth()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public override bool IsFull
        {
            get { return (calorieIntake >= 1500) ? true : false; }
        }

        public override void Consume(IConsumable Item)
        {
            if (!IsFull)
            {
                if (Item.IsSweet) calorieIntake += 10;
                calorieIntake += Item.Calories;
                ConsumptionHistory.Add(Item);
                Item.GetInfo();
            }
            else
                Console.WriteLine("Sweet Tooth is too full to eat!");
        }
    }
}