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

		private const int WM_MOUSEACTIVATE = 0x0021;
		private const int MA_NOACTIVATEANDEAT = 0x0004;

		protected override bool ShowWithoutActivation
		{
			get { return true; }
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams baseParams = base.CreateParams;

				const int WS_EX_NOACTIVATE = 0x08000000;
				const int WS_EX_TOOLWINDOW = 0x00000080;
				baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

				return baseParams;
			}
		}

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
			volQuitterIco.Icon = SystemIcons.Application;
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
				ClientSize = new Size(32, 128);
				MaximizeBox = false;
				MaximumSize = new Size(32, 128);
				MinimizeBox = false;
				MinimumSize = new Size(32, 128);
				WindowState = FormWindowState.Normal;
				
			}
			if ((Location.X != 32) || (Location.Y != 32))
			{
				Location = new Point(32, 32);
				WindowState = FormWindowState.Normal;
			}
		}

		private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (PollVolume.Enabled)
			{
				PollVolume.Stop();
				Opacity = 0;
				visibility = 0;
				lastVolume = -1;
			}
			else
			{
				PollVolume.Start();
			}
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
