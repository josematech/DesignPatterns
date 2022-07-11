namespace Observer
{
    public interface IFlightChangeListener
    {
        void ReceiveFlightChangeNotification(FlightInfo flightChange);
    }



}
