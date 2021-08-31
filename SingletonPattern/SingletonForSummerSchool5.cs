using System;

namespace SingletonForSummerSchool.SingletonPattern
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Singleton - Thread Safety Singleton using Double-Check Locking
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // 1. The System.Lazy<T> type makes the laziness really simple.
    // 2. You can pass a delegate to the constructor that calls the Singleton constructor,
    // which is done most easily with a lambda expression.
    // 3. Allows you to check whether or not the instance has been created with the IsValueCreated property.
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public sealed class SingletonForSummerSchool5
    {
        private SingletonForSummerSchool5()
        {
        }

        private static readonly Lazy<SingletonForSummerSchool5> lazy = new Lazy<SingletonForSummerSchool5>(() => new SingletonForSummerSchool5());

        public static SingletonForSummerSchool5 Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}