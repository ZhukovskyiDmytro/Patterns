using FactoryMethod.FactoryMethod.Products;

namespace FactoryMethod.FactoryMethod.Creators
{
    public interface IHouseCreator
    {
        IHouse CreateHouse();
    }
}
