namespace SingletonForSummerSchool.SingletonPattern
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Singleton - Thread Safety Singleton
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // 1. The following code is thread-safe.
    // 2. In the code, the thread is locked on a shared object and checks whether an instance has been created or not.
    // It takes care of the memory barrier issue and ensures that only one thread will create an instance.
    // For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it,
    // the first thread will have created the instance, so the expression will evaluate as false.
    // 3. The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public sealed class SingletonForSummerSchool2
    {
        private static SingletonForSummerSchool2 instance = null;
        private static readonly object singletonLock = new object();

        private SingletonForSummerSchool2() { }

        public static SingletonForSummerSchool2 Instance
        {
            get
            {
                lock (singletonLock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonForSummerSchool2();
                    }
                    return instance;
                }
            }
        }
    }
}