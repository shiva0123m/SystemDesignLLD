using ObserverPattern_Behavourial_Design_.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Behavourial_Design_.Observable
{
    public class Iphone:Stock
    {
        public int stockcount=0;
        public List<NotificationAlert> observerlist = new List<NotificationAlert>();

        public void add(NotificationAlert observer)
        {
            observerlist.Add(observer);
        }
        public void remove(NotificationAlert observer) 
        {
            observerlist.Remove(observer);
        }
        public void notifyAll() 
        {
            foreach(NotificationAlert obses in observerlist)
            {
                obses.update();
            }
        }
        public void Set(int updatevalue)
        {
            if (stockcount == 0)
            {
                notifyAll();
            }
            stockcount = updatevalue;
        }
        public int get()
        {
            return stockcount;
        }
    }
}
