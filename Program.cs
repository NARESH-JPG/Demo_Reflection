using System;
using System.Reflection;


namespace Demo_Reflection
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo_Reflection in C#.....!!!");
            Type T = typeof(int);
            Console.WriteLine("Type of name :{0}", T.Name);
            Console.WriteLine("Full name of th type defined : \t{0}", T.FullName);
            Console.WriteLine("Type of Assembly in which it is defined: \t{0}", T.Assembly);
            Console.WriteLine("information about base type  : \t{0}", T.BaseType);

            //creating an object of class reflection_class
            Dynamic_Object Myobj1 = new Dynamic_Object();
            Myobj1.First_Method();
            Myobj1.Second_Method();


            dynamic Myobj2 = new Dynamic_Object();
            Myobj2.First_Method();
            Myobj2.Second_Method();
        
        }

    }
}
