using MailAbstractFactory.AFactory.ALevel;

namespace MailAbstractFactory.AFactory.Express
{
    public class ExpressFactory : IMailFactory
    {
        public ILetter CreateLetter()
        {
            return new ExpressLetter();
        }

        public IParcel CreateParcel()
        {
            return new ExpressParcel();
        }

        public ITracker CreateTracker()
        {
            return new ExpressTracker();
        }
    }
}
