using Apis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, true);

            IEventService service =
                (IEventService)Activator.GetObject
                (typeof(IEventService), "tcp://127.0.0.1:8887/Service");

            while (true)
            {
                Console.Write("Any Words: ");
                string str = Console.ReadLine();
                service.setText(str);
                service.invokeClick();
            }
        }
    }
}
