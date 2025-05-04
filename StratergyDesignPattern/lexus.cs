using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class lexus:Vehicle
    {

//This base keyword is sending class reference to the Vehicle class which already contians interface reference
        public lexus() : base(new SportsPerfomance()) { } CallConvThiscall 
    }
}
