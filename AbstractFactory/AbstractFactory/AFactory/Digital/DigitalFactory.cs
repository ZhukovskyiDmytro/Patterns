using MailAbstractFactory.AFactory.ALevel;

namespace MailAbstractFactory.AFactory.Digital
{
    public class DigitalFactory : IMailFactory
    {
        public ITracker CreateTracker()
        {
            return new DigitalTracker();
        }

        public IParcel CreateParcel()
        {
            return new DigitalParcel();
        }

        public ILetter CreateLetter()
        {
            return new DigitalLetter();
        }
    }
}
