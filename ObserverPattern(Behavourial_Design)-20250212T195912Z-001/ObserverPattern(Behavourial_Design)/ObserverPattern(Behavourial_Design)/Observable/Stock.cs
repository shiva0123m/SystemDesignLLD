using ObserverPattern_Behavourial_Design_.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Behavourial_Design_.Observable
{
    public interface Stock
    {
        public void add(NotificationAlert observer);
        public void remove(NotificationAlert observer);
        public void notifyAll();

        public void Set(int updatevalue);
        public int get();
    }
}
