using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opc.Ua.Server.Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }


        #region
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        string[] EndpointUrl = new string[10];
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            this.m_server = server;
            this.m_configuration = configuration;
            labelDateTime.Text = String.Format("{0:dd/MM/yyy HH:mm:ss}", DateTime.Now);
            int count = 0;
            foreach(EndpointDescription endpoint in m_server.GetEndpoints())
            {
                EndpointUrl[count] = endpoint.EndpointUrl;
                count++;

            }
            tcpAddressValue.Text = EndpointUrl[0];
            httpsAddressValue.Text = EndpointUrl[count-1];
        }

        public void UpdateServer()
        {
            try
            {
                statusValue.Text = m_server.CurrentInstance.ToString();
                currentTimeValue.Text = string.Format("{0:dd/MM/yyy HH:mm:ss}", DateTime.Now);
            }
            catch(Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }



    }
}
