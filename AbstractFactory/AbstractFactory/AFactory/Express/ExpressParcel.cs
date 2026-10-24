using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Express
{
    public class ExpressParcel : IParcel
    {
        public Image Appearance => Resources.express_parcel;
    }
}
