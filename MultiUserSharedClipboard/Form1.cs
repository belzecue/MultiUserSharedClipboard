using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiUserSharedClipboard
{
    public partial class frmMain : Form
    {

        private string _fileStore = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine) + @"\MultiUserSharedClipboard.txt";
        private int _formResizeBegin;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string clipContent = Clipboard.GetText();
            if (clipContent.Length > 0)
            {
                File.WriteAllText(_fileStore, clipContent);
            }
            txtContents.Text = File.ReadAllText(_fileStore);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (File.Exists(_fileStore))
            {
                Clipboard.SetText(File.ReadAllText(_fileStore));
            }
            txtContents.Text = Clipboard.GetText();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                if (notifyIcon.BalloonTipText.Length > 0) notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_ResizeBegin(object sender, EventArgs e)
        {
            _formResizeBegin = this.Height;
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            txtContents.Height += this.Height - _formResizeBegin;
        }
    }
}
