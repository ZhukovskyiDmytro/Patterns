using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Express
{
    public class ExpressTracker : ITracker
    {
        public Image Appearance => Resources.express_tracker;
    }
}
