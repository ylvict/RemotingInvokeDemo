using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private EventService service = null;

        public Form1()
        {
            InitializeComponent();

            TcpChannel channel = new TcpChannel(8887);
            ChannelServices.RegisterChannel(channel, true);

            service = new EventService();
            service.Obj = this;
            ObjRef objRef = RemotingServices.Marshal((MarshalByRefObject)service, "Service");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invokeClick();
        }

        public void invokeClick()
        {
            MessageBox.Show(this.textBox1.Text);
        }
    }
}
