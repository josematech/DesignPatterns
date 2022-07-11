using System.Collections.Generic;

namespace Observer
{
    public abstract class FlightChangeNotifier
    {
        private List<IFlightChangeListener> _observers = new List<IFlightChangeListener> ();

        public void AddObserver(IFlightChangeListener observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IFlightChangeListener observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(FlightInfo flightChange)
        {
            foreach (var observer in _observers)
            {
                observer.ReceiveFlightChangeNotification(flightChange);
            }
        }
    }



}
