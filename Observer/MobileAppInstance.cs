using System;

namespace Observer
{
    public class MobileAppInstance : IFlightChangeListener
    {
        void IFlightChangeListener.ReceiveFlightChangeNotification(FlightInfo flightChange)
        {
            Console.WriteLine($"{nameof(MobileAppInstance)} notified: {flightChange}");
        }
    }
}
