using System;
class Playstation : IObservable
{
    private List<IObserver> observers = new List<IObserver>();
    private int value;
    public void Add(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
    public void Set(int value)
    {
        this.value = value;
        Notify();
    }
}