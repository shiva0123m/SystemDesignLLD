using System;

interface IObservable
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify();
    void Set(int value);
}