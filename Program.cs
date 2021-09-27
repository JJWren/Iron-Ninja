using System;
using System.Collections.Generic;

namespace Iron_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet BobsBuffet = new Buffet();
            SweetTooth Lilli = new SweetTooth();
            SpiceHound Josh = new SpiceHound();

            while (!Lilli.IsFull)
                Lilli.Consume(BobsBuffet.Serve());

            while (!Josh.IsFull)
                Josh.Consume(BobsBuffet.Serve());

            if (Lilli.ConsumptionHistory.Count > Josh.ConsumptionHistory.Count)
                Console.WriteLine($"Lilli ate more than Josh with a total of {Lilli.ConsumptionHistory.Count} vs {Josh.ConsumptionHistory.Count}!");
            else if (Josh.ConsumptionHistory.Count > Lilli.ConsumptionHistory.Count)
                Console.WriteLine($"Lilli ate more than Josh with a total of {Lilli.ConsumptionHistory.Count} vs {Josh.ConsumptionHistory.Count}!");
            else
                Console.WriteLine($"They ate the same amount with a total of Lilli's {Lilli.ConsumptionHistory.Count} vs Josh's {Josh.ConsumptionHistory.Count}!");
        }
    }
}