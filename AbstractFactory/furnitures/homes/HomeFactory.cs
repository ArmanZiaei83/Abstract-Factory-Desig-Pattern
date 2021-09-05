namespace AbstractFactory.furnitures
{
    public class HomeFactory : IHomeFactory
    {
        public ModernHome ModernHome()
        {
            return new ModernHome();
        }

        public ClassicHome ClassicalHome()
        {
            return new ClassicHome();
        }
    }
}