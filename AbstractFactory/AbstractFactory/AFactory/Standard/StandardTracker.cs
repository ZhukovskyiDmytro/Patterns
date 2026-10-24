using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Standard
{
    public class StandardTracker : ITracker
    {
        public Image Appearance => Resources.standard_tracker;
    }
}
