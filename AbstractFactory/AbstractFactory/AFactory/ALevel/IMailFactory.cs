using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAbstractFactory.AFactory.ALevel
{
    public interface IMailFactory
    {
        ILetter CreateLetter();
        IParcel CreateParcel();
        ITracker CreateTracker();
    }
}
