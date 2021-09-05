namespace AbstractFactory.furnitures
{
    public class HomeFactory
    {

        public static ModernHome ModernHome()
        {
            return new ModernHome();
        }
        
        public static ClassicHome ClassicalHome()
        {
            return new ClassicHome();
        }
    }
}