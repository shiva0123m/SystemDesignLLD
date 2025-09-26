using System;

class Online
{
    static void Main(string[] args)
    {
        IObservable ob1 = new Playstation();
        IObserver observer1 = new FlipKart("shivam.jakkanwar4@gmail.com", ob1);
        IObserver observer2 = new Amazon("shiv4@gmail.com", ob1);
        ob1.Add(observer1);
        ob1.Add(observer2);
        ob1.Set(10);
    }
}