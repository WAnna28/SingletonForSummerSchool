namespace SingletonForSummerSchool.SingletonPattern
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Singleton - Thread Safety Singleton using Double-Check Locking
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // 1. The preceding implementation looks like a very simple code.
    // 2. This type of implementation has a static constructor, so it executes only once per Application Domain.
    // 3. It is not as lazy as the other implementation.
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public sealed class SingletonForSummerSchool4
    {
        private static readonly SingletonForSummerSchool4 instance = new SingletonForSummerSchool4();

        static SingletonForSummerSchool4()
        {
        }

        private SingletonForSummerSchool4()
        {
        }

        public static SingletonForSummerSchool4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}