
using ObserverPattern_Behavourial_Design_.Observable;
using ObserverPattern_Behavourial_Design_.Observer;

public class Store
{
    static void Main(String[] args)
    {
        Stock iphone=new Iphone();

        NotificationAlert observer1=new EmailNotificationAlert("abcgmail.com",iphone);
        NotificationAlert observer2 = new EmailNotificationAlert("abwgmail.com", iphone);
        NotificationAlert observer3 = new EmailNotificationAlert("abegmail.com", iphone);

        iphone.add(observer1);
        iphone.add(observer2);
        iphone.add(observer3);

        iphone.Set(10);
    }
}