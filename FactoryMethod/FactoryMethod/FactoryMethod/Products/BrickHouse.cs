using System.Drawing;  

namespace FactoryMethod.FactoryMethod.Products
{
    public class BrickHouse : IHouse
    {
        public Image GetImage() => Properties.Resources.brick_house;
    }
}
