using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;

namespace MailAbstractFactory.AFactory.Digital
{
    public class DigitalLetter : ILetter
    {
        public System.Drawing.Image Appearance => Resources.digital_letter;
    }
}
