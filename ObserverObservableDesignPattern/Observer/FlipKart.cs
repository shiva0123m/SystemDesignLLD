using System;

class FlipKart : IObserver
{
    IObservable observable;
    string Email;

    public FlipKart(string email, IObservable observable)
    {
        this.observable = observable;
        this.Email = email;
    }
    public void Update()
    {
        SendEmail(Email);
    }
    public void SendEmail(string email)
    {
        Console.WriteLine("Email sent to " + email);
    }
}