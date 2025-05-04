using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle
    {
        //This interface object contians the class reference from the class which are not even derived by Vehicle class
        Drivestratergy obj;
        public Vehicle(Drivestratergy obj) 
        {
            this.obj = obj;
        }

        public void drive()
        {
            obj.Drive();
        }
    }
}



//The Main functioning of the stratergy pattern is that interface contian defination for the function drive ,Two class normal and Sportsperformance give body to the drive function as per the requirement
// then Vehicle class contian object of interface drive stratergy and get reference of any drived class of drive stratergy interface
// Dervied class of vehicle sends reference of derived class of interface to Vehicle class and that reference object executes the drive function
// SO this how algoithm can be changed on runtime