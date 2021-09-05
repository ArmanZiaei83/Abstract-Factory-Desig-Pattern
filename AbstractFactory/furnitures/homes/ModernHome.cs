namespace AbstractFactory.furnitures
{
    public class ModernHome : IHome
    {
        public IChair CreateChair()
        {
            var chair = new Chair()
                .ChairName("Modern Chair");
            return chair;
        }

        public ITable CreateTable()
        {
            var table = new Table()
                .TableModel("Modern Table");
            return table;
        }
    }
}