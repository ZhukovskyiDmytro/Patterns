using System.Drawing;

namespace FactoryMethod.FactoryMethod.Products
{
    public class WoodHouse : IHouse
    {
        public Image GetImage() => Properties.Resources.wood_house;
    }
}
