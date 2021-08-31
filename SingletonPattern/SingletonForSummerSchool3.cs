namespace SingletonForSummerSchool.SingletonPattern
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Singleton - Thread Safety Singleton using Double-Check Locking
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // In the following code, the thread is locked on a shared object and checks whether
    // an instance has been created or not with double checking.
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public sealed class SingletonForSummerSchool3
    {
        private SingletonForSummerSchool3() { }
        private static readonly object singletonLock = new object();
        private static SingletonForSummerSchool3 instance = null;
        public static SingletonForSummerSchool3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (singletonLock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonForSummerSchool3();
                        }
                    }
                }
                return instance;
            }
        }
    }
}