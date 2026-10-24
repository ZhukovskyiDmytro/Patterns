using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Standard
{
    public class StandardParcel : IParcel
    {
        public Image Appearance => Resources.standard_parcel;
    }
}
