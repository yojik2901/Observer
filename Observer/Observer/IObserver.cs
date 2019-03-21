namespace Observer
{
    public interface IObserver
    {
        void handleEvent(int temp, int presser);
    }
}