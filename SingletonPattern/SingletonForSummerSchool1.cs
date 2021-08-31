namespace SingletonForSummerSchool.SingletonPattern
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Singleton - No Thread Safe Singleton
    // Bad code! Do not use!
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // The following code is not thread-safe.
    // Two different threads could both have evaluated the test(if instance == null) and found it to be true,
    // then both create instances, which violates the singleton pattern.
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public sealed class SingletonForSummerSchool1
    {
        private static SingletonForSummerSchool1 instance = null;

        private SingletonForSummerSchool1() { }

        public static SingletonForSummerSchool1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonForSummerSchool1();
                }
                return instance;
            }
        }
    }
}