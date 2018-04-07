namespace MultiUserSharedClipboard
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtContents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Image = global::MultiUserSharedClipboard.Properties.Resources.Feed_In_48;
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(61, 15);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(111, 54);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Image = global::MultiUserSharedClipboard.Properties.Resources.Feed_Out_48;
            this.btnGet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGet.Location = new System.Drawing.Point(205, 15);
            this.btnGet.MaximumSize = new System.Drawing.Size(110, 55);
            this.btnGet.MinimumSize = new System.Drawing.Size(110, 55);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(110, 55);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Multi-user Shared Clipboard";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // txtContents
            // 
            this.txtContents.Location = new System.Drawing.Point(12, 88);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContents.Size = new System.Drawing.Size(355, 74);
            this.txtContents.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 171);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(395, 600);
            this.MinimumSize = new System.Drawing.Size(395, 210);
            this.Name = "frmMain";
            this.Text = "Multi-user Shared Clipboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtContents;
    }
}

