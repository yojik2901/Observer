using System;
using System.IO;

namespace Observer
{
    public class FileObserver : IObserver
    {
        public void handleEvent(int temp, int presser)
        {
            try
            {
                
                StreamWriter streamWriter = File.AppendText("TempPressure.txt");
                streamWriter.WriteLine("Погода изменилась. Температура = " + temp + ", Давление = " + presser + ".");
                streamWriter.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}