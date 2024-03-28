using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal  class Delegate1
    {
        //action Void      --> Void
        //Func   Parameter --> Value 
        //Pred   Parameter --> Boolean 


       public static void M1 () { Console.WriteLine("action delegate"); }
        public static void M2(Action action) { action(); Console.WriteLine("after action delegate"); }


        public static int M3(int x) {return x++; }
        public static void M4(Func<int,int> func,int x) { Console.WriteLine("func delegate show me value"+func(x)); }

        public static Boolean M5(int x) { if (x > 5) { return true; }return false; }
        public static void M6(Predicate<int>predicate,int x) { Console.WriteLine("predicate delegate greater then 5 ?" + predicate(x)); }





    }
}
