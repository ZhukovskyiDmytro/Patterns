using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    public class ConcreteHouseCreator : IHouseCreator
    {
        public IHouse CreateHouse()
        {
            return new ConcreteHouse();
        }
    }
}
