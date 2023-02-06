using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opc.Ua.Server.Controls
{
    public partial class Certification : UserControl
    {
        public Certification()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        DirectoryInfo TrustedCertificatedPath = new DirectoryInfo(@"..\..\..\..\Security\pki\own\trusted\certs");
        DirectoryInfo RejectedCertificatedPath = new DirectoryInfo(@"..\..\..\..\Security\pki\own\rejected\certs");
        FileInfo[] CertificatedTrusted = { };
        FileInfo[] CertificatedRejected = { };
        string Filename = "";
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            Table.Clear();
            Table.Columns.Add("Trusted Certification");
            Table.Columns.Add("Rejected Certification");
            dataGridView1.DataSource = Table;
            dataGridView1.Columns[0].MinimumWidth = 350;
            dataGridView1.Columns[1].MinimumWidth = 350;
            trustedButton.Enabled = false;
            rejectedButton.Enabled = false;

        }
        public void UpdateCertification()
        {
            if((TrustedCertificatedPath.GetFiles().Length != CertificatedTrusted.Length)||(RejectedCertificatedPath.GetFiles().Length!=CertificatedRejected.Length))
            {
                Table.Rows.Clear();
                CertificatedTrusted = TrustedCertificatedPath.GetFiles();
                // Read trusted certification and put it in the table
                foreach(FileInfo file in CertificatedTrusted)
                {
                    DataRow row = Table.NewRow();
                    row["Trusted Certification"] = file.FullName;
                    Table.Rows.Add(row);
                }
                // Read rejected certification and put it in the table
                foreach (FileInfo file in CertificatedRejected)
                {
                    DataRow row = Table.NewRow();
                    row["Rejected Certification"] = file.FullName;
                    Table.Rows.Add(row);
                }

            }
        }

        private void openCertFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\\Security\pki\own");
        }

        private void trustedButton_Click(object sender, EventArgs e)
        {
            string sourceFile = Path.Combine(RejectedCertificatedPath.ToString(), Filename);
            string destFile = Path.Combine(TrustedCertificatedPath.ToString(), Filename);
            File.Move(sourceFile, destFile);
        }

        private void rejectedButton_Click(object sender, EventArgs e)
        {
            string sourceFile = Path.Combine(TrustedCertificatedPath.ToString(), Filename);
            string destFile = Path.Combine(RejectedCertificatedPath.ToString(), Filename);
            File.Move(sourceFile, destFile);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFile = Path.Combine(TrustedCertificatedPath.ToString(), Filename);
                File.Delete(sourceFile);
            }
            catch
            {

            }
            try
            {
                string sourceFile = Path.Combine(RejectedCertificatedPath.ToString(), Filename);
                File.Delete(sourceFile);
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Filename = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                rejectedButton.Enabled = true;
                trustedButton.Enabled = false;
            }
            if (e.ColumnIndex == 1)
            {
                rejectedButton.Enabled = false;
                trustedButton.Enabled = true;
            }
            if (Filename == "")
            {
                rejectedButton.Enabled = false;
                trustedButton.Enabled = false;
            }
        }
    }
}
