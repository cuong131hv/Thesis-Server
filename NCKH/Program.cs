using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;

namespace NCKH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "Demo Plant";

       try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new NckhServer());
                    return;
                }

                //load the application configuration
                application.LoadApplicationConfiguration(@"..\..\ThesisServer.Config.xml", false).Wait();

                //check the application certification
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                //start the server
                application.Start(new NckhServer()).Wait();
                //run the application
                Application.Run (new Opc.Ua.Server.Controls.ServerForm(application));
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }

        }

    }
}
