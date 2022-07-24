using System;

namespace Observer
{
    public class RYR4677 : FlightChangeNotifier
    {
        public void UpdateInfo()
        {
            Console.WriteLine($"{nameof(RYR4677)} is changing its state, is notifying observers...");
            Notify(new FlightInfo(nameof(RYR4677), 2.11f, -1.25f, 11000f, 750));
        }
    }



}
