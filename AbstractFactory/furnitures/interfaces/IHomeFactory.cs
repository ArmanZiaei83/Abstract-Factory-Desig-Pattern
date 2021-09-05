namespace AbstractFactory.furnitures
{
    public interface IHomeFactory
    {
        public ModernHome ModernHome();
        public ClassicHome ClassicalHome();
    }
}