/* ========================================================================
 * Copyright (c) 2005-2020 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace Opc.Ua.Server.Controls
{
    partial class ServerForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.statusServerForm = new System.Windows.Forms.StatusStrip();
            this.statusServerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.runningLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverCurrentTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.sessionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sessionValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.subscriptionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.subscriptionsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.home1 = new Opc.Ua.Server.Controls.Home();
            this.endpointsTab = new System.Windows.Forms.TabPage();
            this.endpoint1 = new Opc.Ua.Server.Controls.Endpoint();
            this.sessionTab = new System.Windows.Forms.TabPage();
            this.serverDiagnosticsCtrl1 = new Opc.Ua.Server.Controls.ServerDiagnosticsCtrl();
            this.certificationTab = new System.Windows.Forms.TabPage();
            this.certification1 = new Opc.Ua.Server.Controls.Certification();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.statusServerForm.SuspendLayout();
            this.endpointsTab.SuspendLayout();
            this.sessionTab.SuspendLayout();
            this.certificationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Controls.Add(this.endpointsTab);
            this.tabControl1.Controls.Add(this.sessionTab);
            this.tabControl1.Controls.Add(this.certificationTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1427, 696);
            this.tabControl1.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.statusServerForm);
            this.homeTab.Controls.Add(this.home1);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1419, 667);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // statusServerForm
            // 
            this.statusServerForm.BackColor = System.Drawing.SystemColors.Control;
            this.statusServerForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusServerForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusServerLabel,
            this.runningLabel,
            this.currentTimeLabel,
            this.serverCurrentTimeValue,
            this.sessionLabel,
            this.sessionValue,
            this.subscriptionLabel,
            this.subscriptionsValue,
            this.itemsLabel,
            this.itemsValue});
            this.statusServerForm.Location = new System.Drawing.Point(3, 638);
            this.statusServerForm.Name = "statusServerForm";
            this.statusServerForm.Size = new System.Drawing.Size(1413, 26);
            this.statusServerForm.TabIndex = 1;
            this.statusServerForm.Text = "statusServerForm";
            // 
            // statusServerLabel
            // 
            this.statusServerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusServerLabel.Name = "statusServerLabel";
            this.statusServerLabel.Size = new System.Drawing.Size(57, 20);
            this.statusServerLabel.Text = "Status:";
            // 
            // runningLabel
            // 
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(63, 20);
            this.runningLabel.Text = "Running";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(105, 20);
            this.currentTimeLabel.Text = "Current Time:";
            // 
            // serverCurrentTimeValue
            // 
            this.serverCurrentTimeValue.Name = "serverCurrentTimeValue";
            this.serverCurrentTimeValue.Size = new System.Drawing.Size(63, 20);
            this.serverCurrentTimeValue.Text = "00:00:00";
            // 
            // sessionLabel
            // 
            this.sessionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(65, 20);
            this.sessionLabel.Text = "Session:";
            // 
            // sessionValue
            // 
            this.sessionValue.Name = "sessionValue";
            this.sessionValue.Size = new System.Drawing.Size(17, 20);
            this.sessionValue.Text = "0";
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(107, 20);
            this.subscriptionLabel.Text = "Subscriptions:";
            // 
            // subscriptionsValue
            // 
            this.subscriptionsValue.Name = "subscriptionsValue";
            this.subscriptionsValue.Size = new System.Drawing.Size(17, 20);
            this.subscriptionsValue.Text = "0";
            // 
            // itemsLabel
            // 
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(53, 20);
            this.itemsLabel.Text = "Items:";
            // 
            // itemsValue
            // 
            this.itemsValue.Name = "itemsValue";
            this.itemsValue.Size = new System.Drawing.Size(17, 20);
            this.itemsValue.Text = "0";
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.Moccasin;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1413, 635);
            this.home1.TabIndex = 0;
            // 
            // endpointsTab
            // 
            this.endpointsTab.Controls.Add(this.endpoint1);
            this.endpointsTab.Location = new System.Drawing.Point(4, 25);
            this.endpointsTab.Name = "endpointsTab";
            this.endpointsTab.Padding = new System.Windows.Forms.Padding(3);
            this.endpointsTab.Size = new System.Drawing.Size(1419, 667);
            this.endpointsTab.TabIndex = 1;
            this.endpointsTab.Text = "Endpoints";
            this.endpointsTab.UseVisualStyleBackColor = true;
            // 
            // endpoint1
            // 
            this.endpoint1.Location = new System.Drawing.Point(42, 6);
            this.endpoint1.Name = "endpoint1";
            this.endpoint1.Size = new System.Drawing.Size(1074, 598);
            this.endpoint1.TabIndex = 0;
            // 
            // sessionTab
            // 
            this.sessionTab.Controls.Add(this.serverDiagnosticsCtrl1);
            this.sessionTab.Location = new System.Drawing.Point(4, 25);
            this.sessionTab.Name = "sessionTab";
            this.sessionTab.Padding = new System.Windows.Forms.Padding(3);
            this.sessionTab.Size = new System.Drawing.Size(1419, 667);
            this.sessionTab.TabIndex = 2;
            this.sessionTab.Text = "Session";
            this.sessionTab.UseVisualStyleBackColor = true;
            // 
            // serverDiagnosticsCtrl1
            // 
            this.serverDiagnosticsCtrl1.Location = new System.Drawing.Point(7, 19);
            this.serverDiagnosticsCtrl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverDiagnosticsCtrl1.Name = "serverDiagnosticsCtrl1";
            this.serverDiagnosticsCtrl1.Size = new System.Drawing.Size(1405, 632);
            this.serverDiagnosticsCtrl1.TabIndex = 0;
            // 
            // certificationTab
            // 
            this.certificationTab.Controls.Add(this.certification1);
            this.certificationTab.Location = new System.Drawing.Point(4, 25);
            this.certificationTab.Name = "certificationTab";
            this.certificationTab.Size = new System.Drawing.Size(1419, 667);
            this.certificationTab.TabIndex = 3;
            this.certificationTab.Text = "Certification";
            this.certificationTab.UseVisualStyleBackColor = true;
            // 
            // certification1
            // 
            this.certification1.Location = new System.Drawing.Point(119, 3);
            this.certification1.Name = "certification1";
            this.certification1.Size = new System.Drawing.Size(1069, 579);
            this.certification1.TabIndex = 0;
            // 
            // ServerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 720);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerForm";
            this.Text = "NCKH Server Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.Resize += new System.EventHandler(this.ServerForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.statusServerForm.ResumeLayout(false);
            this.statusServerForm.PerformLayout();
            this.endpointsTab.ResumeLayout(false);
            this.sessionTab.ResumeLayout(false);
            this.certificationTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage endpointsTab;
        private System.Windows.Forms.TabPage sessionTab;
        private System.Windows.Forms.TabPage certificationTab;
        private Home home1;
        private Endpoint endpoint1;
        private ServerDiagnosticsCtrl serverDiagnosticsCtrl1;
        private Certification certification1;
        private System.Windows.Forms.StatusStrip statusServerForm;
        private System.Windows.Forms.ToolStripStatusLabel statusServerLabel;
        private System.Windows.Forms.ToolStripStatusLabel runningLabel;
        private System.Windows.Forms.ToolStripStatusLabel currentTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel serverCurrentTimeValue;
        private System.Windows.Forms.ToolStripStatusLabel sessionLabel;
        private System.Windows.Forms.ToolStripStatusLabel sessionValue;
        private System.Windows.Forms.ToolStripStatusLabel subscriptionLabel;
        private System.Windows.Forms.ToolStripStatusLabel subscriptionsValue;
        private System.Windows.Forms.ToolStripStatusLabel itemsLabel;
        private System.Windows.Forms.ToolStripStatusLabel itemsValue;
    }
}
