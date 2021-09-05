namespace AbstractFactory.furnitures
{
    public interface IHome
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}