using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiersSecond
{
    //static class - all members must be static!!! Cann't instance!!! Cann't get inheretance!!! 
    static class Extention
    {
        static Extention()
        {
            Test();
        }
        public static int MyProperty { get; set; }

        private static void Test()
        {
            Console.WriteLine("Nahide istedi");
        }
    }

}
