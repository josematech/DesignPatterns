using System;

namespace Observer
{
    public class WebBrowserInstance : IFlightChangeListener
    {
        void IFlightChangeListener.ReceiveFlightChangeNotification(FlightInfo flightChange)
        {
            Console.WriteLine($"{nameof(WebBrowserInstance)} notified: {flightChange}");
        }
    }
}
