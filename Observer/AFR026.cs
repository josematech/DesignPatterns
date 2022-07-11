using System;

namespace Observer
{
    public class AFR026 : FlightChangeNotifier
    {
        public void UpdateInfo()
        {
            Console.WriteLine($"{nameof(AFR026)} is changing its state, is notifying observers...");
            Notify(new FlightInfo(nameof(AFR026), 0.56f, -2.89f, 7589f, 512));
        }
    }



}
