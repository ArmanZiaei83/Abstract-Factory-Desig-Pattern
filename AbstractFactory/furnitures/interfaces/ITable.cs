namespace AbstractFactory.furnitures
{
    public interface ITable
    {
        ITable TableColor(string color);
        ITable TableLegs(int legs);
        ITable TableModel(string model);
    }
}