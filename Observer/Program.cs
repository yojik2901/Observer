using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            MeteoStation station = new MeteoStation();

            station.addObserver(new ConsoleObserver());
            station.addObserver(new FileObserver());

            station.setMeasurements(25, 760);
            station.setMeasurements(-25, -760);
        }
    }
}
