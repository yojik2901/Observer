using System;

namespace Observer
{
    public class ConsoleObserver : IObserver
    {
        public void handleEvent(int temp, int presser)
        {
            Console.WriteLine("Погода изменилась. Температура = " + temp + ", Давление = " + presser + ".");
        }
    }
}