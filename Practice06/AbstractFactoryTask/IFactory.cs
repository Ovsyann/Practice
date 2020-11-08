namespace AbstractFactory
{
    public interface IFactory
    {
        public ITable CreateTable();
        public IChair CreateChair();
        public ISofa CreateSofa();
        public IWardrobe CreateWardrobe();
    }
}