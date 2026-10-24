using System.Drawing;

namespace FactoryMethod.FactoryMethod.Products
{
    public class ConcreteHouse : IHouse
    {
        public Image GetImage() => Properties.Resources.concrete_house;
    }
}
