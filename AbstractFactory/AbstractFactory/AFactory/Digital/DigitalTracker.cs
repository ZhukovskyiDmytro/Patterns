using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Digital
{
    public class DigitalTracker : ITracker
    {
        public Image Appearance => Resources.digital_tracker;
    }
}
