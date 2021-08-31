using SingletonForSummerSchool.SingletonPattern;
using System;

namespace SingletonForSummerSchool
{
    // Singleton is a creational design pattern,
    // which ensures that only one object of its kind exists
    // and provides a single point of access to it for any other code.
    class Program
    {
        // The common characteristics of a singleton pattern.
        // 1. Private and parameterless single constructor
        // 2. Sealed class.
        // 3. Static variable to hold a reference to the single created instance.
        // 4. A public and static way of getting the reference to the created instance.
        static void Main()
        {
            CompareObjects(SingletonForSummerSchool1.Instance, SingletonForSummerSchool1.Instance);
            CompareObjects(SingletonForSummerSchool2.Instance, SingletonForSummerSchool2.Instance);
            CompareObjects(SingletonForSummerSchool3.Instance, SingletonForSummerSchool3.Instance);
            CompareObjects(SingletonForSummerSchool4.Instance, SingletonForSummerSchool4.Instance);
            CompareObjects(SingletonForSummerSchool5.Instance, SingletonForSummerSchool5.Instance);

            Console.ReadLine();
        }

        static void CompareObjects(object obj1, object obj2)
        {
            if (obj1 == obj2) Console.WriteLine("We both are once instance having two names");
            else Console.WriteLine("We both are once instance having two names");
        }
    }
}
