using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    static class MyClass
    {
        static MyClass()
        {
            
        }

        static int myVar;

        static int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        static void Foo()
        {
            Console.WriteLine("Foo");
        }

    }
}
