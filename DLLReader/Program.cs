using System;
using System.Reflection;

namespace DLLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will read the compiled DLL of the DLLToRead project");

            
            string path = "<Add full path to DLL here>";

            Assembly asm = Assembly.LoadFile(path);
            Type[] typeArray = asm.GetTypes();

            Type Class1 = asm.GetType("DLLToRead.Class1");

            // Creating object with no parameters to constructor
            object classInstance = Activator.CreateInstance(Class1);

            // Calling sum method 
            MethodInfo sum = Class1.GetMethod("sum");
            object[] funcParms1 = {2,3};
            float result = (float)sum.Invoke(classInstance, funcParms1);
            Console.WriteLine("The result is " + result.ToString());

            // Creating object with parameters to constructor
            object[] parm2 = {2};
            object otherInstance = Activator.CreateInstance(Class1, parm2);

            // Calling addToParm method
            MethodInfo addToParm = Class1.GetMethod("addToParm");
            object[] funcParms2 = {2};
            result = (float)addToParm.Invoke(otherInstance, funcParms2);

            Console.WriteLine("The result of addToParm is " + result.ToString());
        }
    }
}
