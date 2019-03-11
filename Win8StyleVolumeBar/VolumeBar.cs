using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;


namespace Win8StyleVolumeBar
{
	public partial class VolumeBar : Form
	{
		CoreAudioDevice playbackDevice;
		double lastVolume = -1;

		int idleTimer;
		double visibility = 0d;

		public VolumeBar(int? color)
		{
			InitializeComponent();
			playbackDevice = new CoreAudioController().DefaultPlaybackDevice;
			if (color.HasValue)
			{
				volFG.BackColor = Color.FromArgb(color.Value);
			}
			FormClosing += VolumeBar_FormClosing;
		}

		private void VolumeBar_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
			}
		}

		private void VolumeBar_Load(object sender, EventArgs e)
		{
			volFG.Location = new Point(0, 80 - (int)(playbackDevice.Volume / 100 * 80));
			VolTxt.Text = $"{playbackDevice.Volume}";
			lastVolume = playbackDevice.Volume;
			Location = new Point(32, 32);
		}

		private void PollVolume_Tick(object sender, EventArgs e)
		{
			volFG.Location = new Point(0, 80 - (int)(playbackDevice.Volume / 100 * 80));
			VolTxt.Text = $"{playbackDevice.Volume}";
			idleTimer++;
			if (lastVolume != playbackDevice.Volume)
			{
				lastVolume = playbackDevice.Volume;
				idleTimer = 0;
				Opacity = 1;
				visibility = 1;
			}
			if (idleTimer > 40)
			{
				visibility -= .1d;
				if (visibility < 0)
				{
					visibility = 0;
				}
				Opacity = visibility;
			}
			if ((ClientSize.Width != 32) || (ClientSize.Height != 128))
			{
				ClientSize = new System.Drawing.Size(32, 128);
				MaximizeBox = false;
				MaximumSize = new System.Drawing.Size(32, 128);
				MinimizeBox = false;
				MinimumSize = new System.Drawing.Size(32, 128);
				WindowState = FormWindowState.Normal;
				
			}
			if ((Location.X != 32) || (Location.Y != 32))
			{
				Location = new System.Drawing.Point(32, 32);
				WindowState = FormWindowState.Normal;
			}
		}
	}
}
