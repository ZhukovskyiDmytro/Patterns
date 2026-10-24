using MailAbstractFactory.AFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace MailAbstractFactory.AFactory.Standard
{
    public class StandardLetter : ILetter
    {
        public Image Appearance => Resources.standard_letter;
    }
}
