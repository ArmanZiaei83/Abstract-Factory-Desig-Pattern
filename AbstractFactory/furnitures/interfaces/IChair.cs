namespace AbstractFactory.furnitures
{
    public interface IChair
    {
        IChair ChairName(string name);
        IChair ChairLegs(int legs);
        IChair ChairModel(string model);
    }
}