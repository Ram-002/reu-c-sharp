using System;

namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {

            Func<Action<char>, bool, double, double> func = (action, b, arg3) =>
            {
                if (b)
                {
                    action.Invoke((char)arg3);
                }
                return arg3 * (b ? -1 : 2);
            }; 
                
            Console.WriteLine(func(Console.WriteLine,true,65));
            Console.WriteLine(func(Console.WriteLine, true, 66));
            Console.WriteLine(func(Console.WriteLine, true, 67));

            Console.WriteLine(func(Console.WriteLine, false, 68));
            Console.WriteLine(func(Console.WriteLine, false, 69));
            Console.WriteLine(func(Console.WriteLine, false, 70));
        }
    }
}
