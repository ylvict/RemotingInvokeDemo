using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apis
{
    public interface IEventService
    {
        void setText(string str);
        void invokeClick();
    }
}
