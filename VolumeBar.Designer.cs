﻿namespace Win8StyleVolumeBar
{
    partial class VolumeBar
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
			this.volBG = new System.Windows.Forms.Panel();
			this.volFG = new System.Windows.Forms.Panel();
			this.VolTxt = new System.Windows.Forms.Label();
			this.PollVolume = new System.Windows.Forms.Timer(this.components);
			this.volDot = new System.Windows.Forms.Panel();
			this.volBG.SuspendLayout();
			this.volFG.SuspendLayout();
			this.SuspendLayout();
			// 
			// volBG
			// 
			this.volBG.BackColor = System.Drawing.Color.Black;
			this.volBG.Controls.Add(this.volFG);
			this.volBG.Location = new System.Drawing.Point(9, 9);
			this.volBG.Margin = new System.Windows.Forms.Padding(0);
			this.volBG.Name = "volBG";
			this.volBG.Size = new System.Drawing.Size(14, 94);
			this.volBG.TabIndex = 0;
			// 
			// volFG
			// 
			this.volFG.BackColor = System.Drawing.Color.Maroon;
			this.volFG.Controls.Add(this.volDot);
			this.volFG.Location = new System.Drawing.Point(0, 0);
			this.volFG.Name = "volFG";
			this.volFG.Size = new System.Drawing.Size(14, 94);
			this.volFG.TabIndex = 0;
			// 
			// VolTxt
			// 
			this.VolTxt.BackColor = System.Drawing.Color.Transparent;
			this.VolTxt.ForeColor = System.Drawing.Color.White;
			this.VolTxt.Location = new System.Drawing.Point(0, 106);
			this.VolTxt.Name = "VolTxt";
			this.VolTxt.Size = new System.Drawing.Size(32, 16);
			this.VolTxt.TabIndex = 1;
			this.VolTxt.Text = "100";
			this.VolTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PollVolume
			// 
			this.PollVolume.Enabled = true;
			this.PollVolume.Interval = 50;
			this.PollVolume.Tick += new System.EventHandler(this.PollVolume_Tick);
			// 
			// volDot
			// 
			this.volDot.BackColor = System.Drawing.Color.Silver;
			this.volDot.Location = new System.Drawing.Point(0, 0);
			this.volDot.Name = "volDot";
			this.volDot.Size = new System.Drawing.Size(14, 14);
			this.volDot.TabIndex = 0;
			// 
			// VolumeBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(32, 128);
			this.Controls.Add(this.VolTxt);
			this.Controls.Add(this.volBG);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(32, 32);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(32, 128);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(32, 128);
			this.Name = "VolumeBar";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Volume Bar";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.VolumeBar_Load);
			this.volBG.ResumeLayout(false);
			this.volFG.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel volBG;
        private System.Windows.Forms.Panel volFG;
        private System.Windows.Forms.Label VolTxt;
        private System.Windows.Forms.Timer PollVolume;
		private System.Windows.Forms.Panel volDot;
	}
}

