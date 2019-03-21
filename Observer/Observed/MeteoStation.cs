using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Observer
{
    public class MeteoStation : IObserved
    {
        private int _temperature;
        private int _pressute;

        List<IObserver> _observers = new List<IObserver>();

        public void setMeasurements(int t, int p)
        {
            _temperature = t;
            _pressute = p;
            notifyObservers();
        }

        public void addObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.handleEvent(_temperature, _pressute);
            }
        }
    }
}