using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAbstractFactory.AFactory.ALevel
{
    public interface IMail
    {
        Image Appearance { get; }
    }
}
