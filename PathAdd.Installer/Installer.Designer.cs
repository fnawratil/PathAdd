namespace PathAdd.Installer
{
    partial class Installer
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
            this.checkBox_folderTree = new System.Windows.Forms.CheckBox();
            this.checkBox_foldersRightPane = new System.Windows.Forms.CheckBox();
            this.checkBox_files = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_install = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_folderTree
            // 
            this.checkBox_folderTree.AutoSize = true;
            this.checkBox_folderTree.Location = new System.Drawing.Point(6, 22);
            this.checkBox_folderTree.Name = "checkBox_folderTree";
            this.checkBox_folderTree.Size = new System.Drawing.Size(128, 17);
            this.checkBox_folderTree.TabIndex = 0;
            this.checkBox_folderTree.Text = "Folders in Folder Tree";
            this.checkBox_folderTree.UseVisualStyleBackColor = true;
            // 
            // checkBox_foldersRightPane
            // 
            this.checkBox_foldersRightPane.AutoSize = true;
            this.checkBox_foldersRightPane.Location = new System.Drawing.Point(6, 45);
            this.checkBox_foldersRightPane.Name = "checkBox_foldersRightPane";
            this.checkBox_foldersRightPane.Size = new System.Drawing.Size(121, 17);
            this.checkBox_foldersRightPane.TabIndex = 1;
            this.checkBox_foldersRightPane.Text = "Folders in right pane";
            this.checkBox_foldersRightPane.UseVisualStyleBackColor = true;
            // 
            // checkBox_files
            // 
            this.checkBox_files.AutoSize = true;
            this.checkBox_files.Location = new System.Drawing.Point(6, 68);
            this.checkBox_files.Name = "checkBox_files";
            this.checkBox_files.Size = new System.Drawing.Size(47, 17);
            this.checkBox_files.TabIndex = 2;
            this.checkBox_files.Text = "Files";
            this.checkBox_files.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_foldersRightPane);
            this.groupBox1.Controls.Add(this.checkBox_files);
            this.groupBox1.Controls.Add(this.checkBox_folderTree);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show on";
            // 
            // button_install
            // 
            this.button_install.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_install.Location = new System.Drawing.Point(180, 112);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(79, 27);
            this.button_install.TabIndex = 4;
            this.button_install.Text = "Install";
            this.button_install.UseVisualStyleBackColor = true;
            this.button_install.Click += new System.EventHandler(this.button_install_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(95, 112);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(79, 27);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Installer
            // 
            this.AcceptButton = this.button_install;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(271, 151);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathAdd Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_folderTree;
        private System.Windows.Forms.CheckBox checkBox_foldersRightPane;
        private System.Windows.Forms.CheckBox checkBox_files;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_install;
        private System.Windows.Forms.Button button_cancel;
    }
}