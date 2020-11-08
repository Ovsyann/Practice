using System;

namespace AbstractFactory
{
    public class Client
    {
        private ITable Table { set; get; }
        private IChair Chair { set; get; }
        private ISofa Sofa { get; set; }
        private IWardrobe Wardrobe { get; set; }
        private IFactory Factory { set; get; }

        public Client(IFactory factory)
        {
            this.Factory = factory;
        }
        
        public void Create()
        {
            this.Table = Factory.CreateTable();
            this.Chair = Factory.CreateChair();
            this.Sofa = Factory.CreateSofa();
            this.Wardrobe = Factory.CreateWardrobe();
        }
    }
}