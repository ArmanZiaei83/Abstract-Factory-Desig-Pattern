namespace AbstractFactory.furnitures
{
    public class Home : IHome
    {
        public IChair CreateChair()
        {
            return new Chair();
        }

        public ITable CreateTable()
        {
            return new CoffeeTable();
        }
    }
}