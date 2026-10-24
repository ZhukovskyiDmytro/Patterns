using MailAbstractFactory.AFactory.ALevel;

namespace MailAbstractFactory.AFactory.Standard
{
    public class StandardFactory : IMailFactory
    {
        public ILetter CreateLetter()
        {
            return new StandardLetter();
        }

        public IParcel CreateParcel()
        {
            return new StandardParcel();
        }

        public ITracker CreateTracker()
        {
            return new StandardTracker();
        }
    }
}
