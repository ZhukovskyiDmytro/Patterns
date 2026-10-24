using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Express
{
    public class ExpressLetter : ILetter
    {
        public Image Appearance => Resources.express_letter;
    }
}
