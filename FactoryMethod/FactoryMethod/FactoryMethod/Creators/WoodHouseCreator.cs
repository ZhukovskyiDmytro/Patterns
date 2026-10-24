using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    public class WoodHouseCreator : IHouseCreator
    {
        public IHouse CreateHouse()
        {
            return new WoodHouse();
        }
    }
}
