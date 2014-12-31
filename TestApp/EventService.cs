using Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp
{
    class EventService : MarshalByRefObject, IEventService
    {
        internal Form1 Obj { get; set; }

        public void setText(string str)
        {
            this.Obj.textBox1.Text = str;
        }

        public void invokeClick()
        {
            this.Obj.invokeClick();
        }

    }
}
