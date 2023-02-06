
namespace Opc.Ua.Server.Controls
{
    partial class Certification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openCertFolderButton = new System.Windows.Forms.Button();
            this.trustedButton = new System.Windows.Forms.Button();
            this.rejectedButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 457);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // openCertFolderButton
            // 
            this.openCertFolderButton.Location = new System.Drawing.Point(848, 54);
            this.openCertFolderButton.Name = "openCertFolderButton";
            this.openCertFolderButton.Size = new System.Drawing.Size(108, 96);
            this.openCertFolderButton.TabIndex = 1;
            this.openCertFolderButton.Text = "Open Certificate Folder";
            this.openCertFolderButton.UseVisualStyleBackColor = true;
            this.openCertFolderButton.Click += new System.EventHandler(this.openCertFolderButton_Click);
            // 
            // trustedButton
            // 
            this.trustedButton.Location = new System.Drawing.Point(848, 273);
            this.trustedButton.Name = "trustedButton";
            this.trustedButton.Size = new System.Drawing.Size(108, 76);
            this.trustedButton.TabIndex = 1;
            this.trustedButton.Text = "Trusted";
            this.trustedButton.UseVisualStyleBackColor = true;
            this.trustedButton.Click += new System.EventHandler(this.trustedButton_Click);
            // 
            // rejectedButton
            // 
            this.rejectedButton.Location = new System.Drawing.Point(848, 355);
            this.rejectedButton.Name = "rejectedButton";
            this.rejectedButton.Size = new System.Drawing.Size(108, 80);
            this.rejectedButton.TabIndex = 1;
            this.rejectedButton.Text = "Rejected";
            this.rejectedButton.UseVisualStyleBackColor = true;
            this.rejectedButton.Click += new System.EventHandler(this.rejectedButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(848, 441);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(108, 72);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Certification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.rejectedButton);
            this.Controls.Add(this.trustedButton);
            this.Controls.Add(this.openCertFolderButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Certification";
            this.Size = new System.Drawing.Size(1069, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openCertFolderButton;
        private System.Windows.Forms.Button trustedButton;
        private System.Windows.Forms.Button rejectedButton;
        private System.Windows.Forms.Button removeButton;
    }
}
