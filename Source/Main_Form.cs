using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace HTTPserverHere
{
    public partial class Main_Form : Form
    {
        SimpleHTTPServer server = null;
        private bool mustClose = false;

        //
        //
        //
        public Main_Form()
        {
            InitializeComponent();

            // setup trayicon
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipText = " ";
            notifyIcon.Icon = new Icon(this.Icon, 40, 40);
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;


            // dump command line options for debugging
            foreach (string arg in CommandLine.args)
            {
                Console.WriteLine(arg);
            }

            // started by command line
            if(CommandLine.args.Length > 0)
            {
                ServerPath_textBox.Text = CommandLine.args[0];
                ServerStart();
            }
        }


        //
        //
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mustClose = true;
            Close();
        }


        //
        //
        //
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // closed -> not by user clicking close button [x] form
            if ((e.CloseReason == CloseReason.UserClosing) && (mustClose == true))
            {
                ServerStop(); 

                return;
            }

            // just hide the form
            e.Cancel = true;
            Hide();
        }


        //
        //
        //
        private void ServerStart()
        {
            Int16 port;

            if(Int16.TryParse(ServerPort_textBox.Text, out port) == false)
            {
                port = 8080;
                ServerPort_textBox.Text = port.ToString();
            }

            try
            {
                server = new SimpleHTTPServer(ServerPath_textBox.Text, port);
                updateServerState(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to start server {0}", ex.Message);
                server = null;
                updateServerState(-1);
            }
        }


        //
        //
        //
        private void ServerStop()
        {
            if (server != null)
            {
                server.Stop();
                updateServerState(0);
                server = null;
            }
        }


        //
        //
        //
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("file explorer context menu option will be added !", "Question",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                ) == System.Windows.Forms.DialogResult.Yes)
            {
                Registry reg = new Registry();
                reg.ServeHere_Add(Application.ExecutablePath);
            }
        }


        //
        //
        //
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("file explorer context menu option will be removed !", "Question", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question
                                ) == System.Windows.Forms.DialogResult.Yes)
            {
                Registry reg = new Registry();
                reg.ServeHere_Remove();
            }
        }


        //
        //
        //
        private void updateServerState(int state)
        {
            switch (state)
            {
                case -1 :
                    ServerState_toolStripStatusLabel.Text = "server error";
                    ServerState_toolStripStatusLabel.ForeColor = Color.DarkRed;
                    break;

                case 0 :
                    ServerState_toolStripStatusLabel.Text = "server idle";
                    ServerState_toolStripStatusLabel.ForeColor = Color.DarkOrange;
                    break;

                case 1 :
                    ServerState_toolStripStatusLabel.Text = "server runs";
                    ServerState_toolStripStatusLabel.ForeColor = Color.DarkGreen;
                    break;

            }
        }


        //
        //
        //
        private void ShowWindow()
        {
            if (Visible == false)
            {
                WindowState = FormWindowState.Normal;
                Show();
            }
        }


        //
        //
        //
        private void Main_Form_Shown(object sender, EventArgs e)
        {
            // hide form at start of program
            Hide();

            //
            if (server != null)
            {
                notifyIcon.BalloonTipTitle = string.Format("Server started on localhost:{0}", ServerPort_textBox.Text);
                notifyIcon.ShowBalloonTip(1500);
            }
        }


        //
        //
        //
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible == false)
            {
                Console.WriteLine("notifyIcon_MouseDoubleClick");
                ShowWindow();
            }
            else
            {
                Hide();
            }
        }


        //
        //
        //
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mustClose = true;
            Close();
        }


        //
        //
        //
        private void openInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("http://localhost:{0}", ServerPort_textBox.Text));
        }


        //
        //
        //
        private void tray_contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            openInBrowserToolStripMenuItem.Enabled = server != null;
        }
    }
}
