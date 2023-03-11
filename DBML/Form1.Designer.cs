namespace DBML
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbEntryList = new System.Windows.Forms.ListBox();
            this.tbDOSBoxConfig = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbLaunch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart32 = new System.Windows.Forms.Button();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbFriendlyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenPathInExplorer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenDefaultConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatusWindow = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEntryList
            // 
            this.lbEntryList.AllowDrop = true;
            this.lbEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbEntryList.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbEntryList.DisplayMember = "FriendlyName";
            this.lbEntryList.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEntryList.ForeColor = System.Drawing.Color.Cyan;
            this.lbEntryList.FormattingEnabled = true;
            this.lbEntryList.ItemHeight = 23;
            this.lbEntryList.Location = new System.Drawing.Point(9, 12);
            this.lbEntryList.Name = "lbEntryList";
            this.lbEntryList.Size = new System.Drawing.Size(421, 395);
            this.lbEntryList.TabIndex = 0;
            this.lbEntryList.ValueMember = "FriendlyName";
            this.lbEntryList.SelectedIndexChanged += new System.EventHandler(this.lbEntryList_SelectedIndexChanged);
            this.lbEntryList.DoubleClick += new System.EventHandler(this.lbEntryList_DoubleClick);
            this.lbEntryList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbEntryList_KeyDown);
            // 
            // tbDOSBoxConfig
            // 
            this.tbDOSBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDOSBoxConfig.BackColor = System.Drawing.Color.White;
            this.tbDOSBoxConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDOSBoxConfig.Enabled = false;
            this.tbDOSBoxConfig.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDOSBoxConfig.ForeColor = System.Drawing.Color.Black;
            this.tbDOSBoxConfig.Location = new System.Drawing.Point(446, 194);
            this.tbDOSBoxConfig.Multiline = true;
            this.tbDOSBoxConfig.Name = "tbDOSBoxConfig";
            this.tbDOSBoxConfig.Size = new System.Drawing.Size(410, 282);
            this.tbDOSBoxConfig.TabIndex = 1;
            this.tbDOSBoxConfig.TextChanged += new System.EventHandler(this.tbDOSBoxConfig_TextChanged);
            this.tbDOSBoxConfig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDOSBoxConfig_KeyDown);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(446, 84);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(374, 20);
            this.tbPath.TabIndex = 2;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // tbLaunch
            // 
            this.tbLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLaunch.Enabled = false;
            this.tbLaunch.Location = new System.Drawing.Point(446, 133);
            this.tbLaunch.Name = "tbLaunch";
            this.tbLaunch.Size = new System.Drawing.Size(410, 20);
            this.tbLaunch.TabIndex = 2;
            this.tbLaunch.TextChanged += new System.EventHandler(this.tbLaunch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(443, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOSBox configuration patch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(443, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to mount as C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(443, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Commands to execute:";
            // 
            // btnStart32
            // 
            this.btnStart32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart32.Enabled = false;
            this.btnStart32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart32.Location = new System.Drawing.Point(241, 490);
            this.btnStart32.Name = "btnStart32";
            this.btnStart32.Size = new System.Drawing.Size(83, 29);
            this.btnStart32.TabIndex = 4;
            this.btnStart32.Text = "START";
            this.btnStart32.UseVisualStyleBackColor = false;
            this.btnStart32.Click += new System.EventHandler(this.btnStart32_Click);
            // 
            // tTimer
            // 
            this.tTimer.Interval = 10000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(117, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbFriendlyName
            // 
            this.tbFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFriendlyName.Enabled = false;
            this.tbFriendlyName.Location = new System.Drawing.Point(446, 36);
            this.tbFriendlyName.Name = "tbFriendlyName";
            this.tbFriendlyName.Size = new System.Drawing.Size(410, 20);
            this.tbFriendlyName.TabIndex = 5;
            this.tbFriendlyName.TextChanged += new System.EventHandler(this.tbFriendlyName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(443, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entry:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(335, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenPathInExplorer
            // 
            this.btnOpenPathInExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPathInExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenPathInExplorer.Enabled = false;
            this.btnOpenPathInExplorer.Location = new System.Drawing.Point(384, 68);
            this.btnOpenPathInExplorer.Name = "btnOpenPathInExplorer";
            this.btnOpenPathInExplorer.Size = new System.Drawing.Size(34, 22);
            this.btnOpenPathInExplorer.TabIndex = 7;
            this.btnOpenPathInExplorer.Text = "...";
            this.btnOpenPathInExplorer.UseVisualStyleBackColor = true;
            this.btnOpenPathInExplorer.Click += new System.EventHandler(this.btnOpenPathInExplorer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnOpenDefaultConfig);
            this.panel1.Controls.Add(this.btnOpenPathInExplorer);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(436, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 509);
            this.panel1.TabIndex = 8;
            // 
            // btnOpenDefaultConfig
            // 
            this.btnOpenDefaultConfig.Location = new System.Drawing.Point(8, 468);
            this.btnOpenDefaultConfig.Name = "btnOpenDefaultConfig";
            this.btnOpenDefaultConfig.Size = new System.Drawing.Size(83, 29);
            this.btnOpenDefaultConfig.TabIndex = 8;
            this.btnOpenDefaultConfig.Text = "Open default";
            this.btnOpenDefaultConfig.UseVisualStyleBackColor = true;
            this.btnOpenDefaultConfig.Click += new System.EventHandler(this.btnOpenDefaultConfig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 65);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter starts the game\r\nF1 toggles favourite\r\nDelete removes entry\r\nShift+Delete r" +
    "emoves entry and deletes folder\r\nCtrl+S saves configuration";
            // 
            // cbStatusWindow
            // 
            this.cbStatusWindow.AutoSize = true;
            this.cbStatusWindow.Location = new System.Drawing.Point(293, 414);
            this.cbStatusWindow.Name = "cbStatusWindow";
            this.cbStatusWindow.Size = new System.Drawing.Size(137, 17);
            this.cbStatusWindow.TabIndex = 10;
            this.cbStatusWindow.Text = "DOSBox status window";
            this.cbStatusWindow.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(869, 533);
            this.Controls.Add(this.cbStatusWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFriendlyName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStart32);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLaunch);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbDOSBoxConfig);
            this.Controls.Add(this.lbEntryList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DBML";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEntryList;
        private System.Windows.Forms.TextBox tbDOSBoxConfig;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbLaunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart32;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbFriendlyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenPathInExplorer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbStatusWindow;
        private System.Windows.Forms.Button btnOpenDefaultConfig;
    }
}

