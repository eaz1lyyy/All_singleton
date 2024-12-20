namespace Singleton
{
    internal class Singleton
    {
        private static Singleton instance = null;

        private Singleton() { }
        
        public static Singleton GetInstance()
        {
            if (instance == null) instance = new Singleton();
            return instance;
        }
    }
}
