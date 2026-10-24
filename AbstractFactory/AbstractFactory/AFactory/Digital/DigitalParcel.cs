using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Digital
{
    public class DigitalParcel : IParcel
    {
        public Image Appearance => Resources.digital_parcel;
    }
}
