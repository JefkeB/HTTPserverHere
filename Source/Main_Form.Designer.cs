namespace HTTPserverHere
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHTTPServerHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.ServerPort_label = new System.Windows.Forms.Label();
            this.ServerPort_textBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ServerPath_Label = new System.Windows.Forms.Label();
            this.ServerPath_textBox = new System.Windows.Forms.TextBox();
            this.ServerState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(516, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHTTPServerHereToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addHTTPServerHereToolStripMenuItem
            // 
            this.addHTTPServerHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.addHTTPServerHereToolStripMenuItem.Name = "addHTTPServerHereToolStripMenuItem";
            this.addHTTPServerHereToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addHTTPServerHereToolStripMenuItem.Text = "HTTP server here ... ";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerState_toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 162);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(516, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Start_button
            // 
            this.Start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_button.Enabled = false;
            this.Start_button.Location = new System.Drawing.Point(298, 100);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(100, 50);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            // 
            // Stop_button
            // 
            this.Stop_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_button.Enabled = false;
            this.Stop_button.Location = new System.Drawing.Point(404, 100);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(100, 50);
            this.Stop_button.TabIndex = 3;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            // 
            // ServerPort_label
            // 
            this.ServerPort_label.AutoSize = true;
            this.ServerPort_label.Location = new System.Drawing.Point(28, 42);
            this.ServerPort_label.Name = "ServerPort_label";
            this.ServerPort_label.Size = new System.Drawing.Size(26, 13);
            this.ServerPort_label.TabIndex = 4;
            this.ServerPort_label.Text = "Port";
            // 
            // ServerPort_textBox
            // 
            this.ServerPort_textBox.Location = new System.Drawing.Point(88, 38);
            this.ServerPort_textBox.Name = "ServerPort_textBox";
            this.ServerPort_textBox.Size = new System.Drawing.Size(100, 20);
            this.ServerPort_textBox.TabIndex = 5;
            this.ServerPort_textBox.Text = "8080";
            this.toolTip.SetToolTip(this.ServerPort_textBox, "Enter port for server [1...65535]");
            // 
            // ServerPath_Label
            // 
            this.ServerPath_Label.AutoSize = true;
            this.ServerPath_Label.Location = new System.Drawing.Point(28, 73);
            this.ServerPath_Label.Name = "ServerPath_Label";
            this.ServerPath_Label.Size = new System.Drawing.Size(29, 13);
            this.ServerPath_Label.TabIndex = 6;
            this.ServerPath_Label.Text = "Path";
            // 
            // ServerPath_textBox
            // 
            this.ServerPath_textBox.Location = new System.Drawing.Point(88, 69);
            this.ServerPath_textBox.Name = "ServerPath_textBox";
            this.ServerPath_textBox.ReadOnly = true;
            this.ServerPath_textBox.Size = new System.Drawing.Size(416, 20);
            this.ServerPath_textBox.TabIndex = 7;
            // 
            // ServerState_toolStripStatusLabel
            // 
            this.ServerState_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerState_toolStripStatusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.ServerState_toolStripStatusLabel.Name = "ServerState_toolStripStatusLabel";
            this.ServerState_toolStripStatusLabel.Size = new System.Drawing.Size(71, 17);
            this.ServerState_toolStripStatusLabel.Text = "server idle";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 184);
            this.Controls.Add(this.ServerPath_textBox);
            this.Controls.Add(this.ServerPath_Label);
            this.Controls.Add(this.ServerPort_textBox);
            this.Controls.Add(this.ServerPort_label);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTPserverHere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label ServerPort_label;
        private System.Windows.Forms.TextBox ServerPort_textBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHTTPServerHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label ServerPath_Label;
        private System.Windows.Forms.TextBox ServerPath_textBox;
        private System.Windows.Forms.ToolStripStatusLabel ServerState_toolStripStatusLabel;
    }
}

