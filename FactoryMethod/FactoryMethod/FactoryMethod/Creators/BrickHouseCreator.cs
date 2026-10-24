using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    public class BrickHouseCreator : IHouseCreator
    {
        public IHouse CreateHouse()
        {
            return new BrickHouse();
        }
    }
}
