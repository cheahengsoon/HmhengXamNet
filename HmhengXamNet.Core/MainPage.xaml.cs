using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HmhengXamNet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnConnect.Clicked += SendUDP;
        }

        public void SendUDP(object sender, EventArgs e)
        {
            UdpClient ucpClient = new UdpClient();
            IPAddress ipAddress = IPAddress.Parse(txtIPAddress.Text);
            IPEndPoint endPoint = new IPEndPoint(ipAddress, Int32.Parse(txtPort.Text));

            Byte[] data = Encoding.ASCII.GetBytes(txtMessage.Text);
            ucpClient.Send(data, data.Length, endPoint);
        }
    }
}
