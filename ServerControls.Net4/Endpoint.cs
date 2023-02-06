using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace Opc.Ua.Server.Controls
{
    public partial class Endpoint : UserControl
    {
        public Endpoint()
        {
            InitializeComponent();
        }
        #region
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
        string[] EndpointUrl = new string[11];
        private string path = @"..\..\ThesisServer.Config.xml";
        #region
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        string[] SecurityMode = new string[11];
        string[] SecurityPolicy = new string[11];

        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            this.m_server = server;
            this.m_configuration = configuration;
            int count = 0;
            foreach(EndpointDescription enpoint in m_server.GetEndpoints())
            {
                EndpointUrl[count] = enpoint.EndpointUrl;
                count++;
            }
            uaTcpAddressValue.Text = EndpointUrl[0];
            uaHttpsAddressValue.Text = EndpointUrl[count - 1];
            // Update the security
            // check if the file config is exist
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("file not exist");
            }
            DataSet SecurityDataSet = new DataSet();
            SecurityDataSet.ReadXml(path);
            DataTable dataTable = new DataTable();
            dataTable = SecurityDataSet.Tables["ServerSecurityPolicy"];
            int temp = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                SecurityMode[temp] = dataRow["SecurityMode"].ToString();
                SecurityPolicy[temp] = dataRow["SecurityPolicyUri"].ToString();
                temp++;
            }
            for(int i = 0; i< 11;i++)
            {
                try
                {
                    if (SecurityMode[i] == "None_1") checkBoxNoneTcp.Checked = true;
                    if(SecurityMode[i]=="Sign_2")
                    {
                        checkBoxSignTcp.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256") checkBoxBasic256Sign.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256") checkBoxBasic256SHA256Sign.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15") checkBoxBasic128RSA15Sign.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep") checkBoxAes128Sha256RsaOaepSign.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss") checkBoxAes128Sha256RsaPssSign.Checked = true;

                    }
                    if(SecurityMode[i]=="SignAndEncrypt_3")
                    {
                        checkBoxSignEncryptTcp.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256") checkBoxBasic256Sae.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256") checkBoxBasic256SHA256Sae.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15") checkBoxBasic128RSA15Sae.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep") checkBoxAes128Sha256RsaOaepSae.Checked = true;
                        if (SecurityPolicy[i] == "http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss") checkBoxAes128Sha256RsaPssSae.Checked = true;

                    }
                    if (checkBoxSignTcp.Checked == false) groupBoxSecurityPoliciesSign.Visible = false;
                    if (checkBoxSignEncryptTcp.Checked == false) groupBoxSecuritySignAndEncrypt.Visible = false;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }

        }
        private void checkBoxSignTcp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignTcp.Checked) groupBoxSecurityPoliciesSign.Visible = true;
            else groupBoxSecurityPoliciesSign.Visible = false;
        }

        private void checkBoxSignEncryptTcp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignEncryptTcp.Checked) groupBoxSecuritySignAndEncrypt.Visible = true;
            else groupBoxSecuritySignAndEncrypt.Visible = false;
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            //Creating namespace
            XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlNamespaceManager.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlNamespaceManager.AddNamespace("ua", "http://opcfoundation.org/UA/2008/02/Types.xsd");
            xmlNamespaceManager.AddNamespace("ns", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
            // Creating node for policy
            XmlNode xmlNode = xmlDocument.SelectSingleNode("ns:ApplicationConfiguration/ns:ServerConfiguration/ns:SecurityPolicies", xmlNamespaceManager);
            xmlNode.RemoveAll();

            if(checkBoxNoneTcp.Checked)
            {
                XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                value.AppendChild(xmlDocument.CreateTextNode("None_1"));

                value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#None"));
                xmlNode.AppendChild(element);
            }
            if (checkBoxSignTcp.Checked)
            {
                if (checkBoxBasic128RSA15Sign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("Sign_2"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxBasic256Sign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("Sign_2"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxBasic256SHA256Sign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("Sign_2"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxAes128Sha256RsaOaepSign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("Sign_2"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxAes128Sha256RsaPssSign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("Sign_2"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss"));
                    xmlNode.AppendChild(element);
                }

            }
            if (checkBoxSignEncryptTcp.Checked)
            {
                if (checkBoxBasic128RSA15Sae.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("SignAndEncrypt_3"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic128Rsa15"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxBasic256Sae.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("SignAndEncrypt_3"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxBasic256SHA256Sae.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("SignAndEncrypt_3")); ;

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Basic256Sha256"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxAes128Sha256RsaOaepSae.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("SignAndEncrypt_3"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes128_Sha256_RsaOaep"));
                    xmlNode.AppendChild(element);
                }
                if (checkBoxAes128Sha256RsaPssSign.Checked)
                {
                    XmlNode element = xmlDocument.CreateNode(XmlNodeType.Element, "ServerSecurityPolicy", "http://opcfoundation.org/UA/SDK/Configuration.xsd");
                    var value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityMode", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("SignAndEncrypt_3"));

                    value = element.AppendChild(xmlDocument.CreateNode(XmlNodeType.Element, "SecurityPolicyUri", "http://opcfoundation.org/UA/SDK/Configuration.xsd"));
                    value.AppendChild(xmlDocument.CreateTextNode("http://opcfoundation.org/UA/SecurityPolicy#Aes256_Sha256_RsaPss"));
                    xmlNode.AppendChild(element);
                }
            }
            try
            {
                xmlDocument.Save(path);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }
    }
}
