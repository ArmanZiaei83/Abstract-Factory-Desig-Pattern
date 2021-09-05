using AbstractFactory.furnitures;

namespace AbstractFactory
{
    public class ClassicHome : IHome
    {
        public IChair CreateChair()
        {
            return new Chair().ChairModel("Classic Chair");
        }

        public ITable CreateTable()
        {
            return new Table().TableModel("Classic Table");
        }
    }
}