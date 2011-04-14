using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Tfs.FileDistributor.Forms {
	public partial class UploadForm : Form {

		private Timer fadeTimer;

		public UploadForm(bool keepAlive, Rectangle canvas) {
			InitializeComponent();

			this.ResizeRedraw = true;
			
			Main.Panel1Collapsed = !keepAlive;
			int height = keepAlive ? 23 : 0;
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			UploadSettingsConfigSection section = (UploadSettingsConfigSection)configuration.GetSection("UploadSettings");
			if (section != null) {
				foreach (UploadElement uploadElement in section.UploadSettings) {
					UploadPanel panel = new UploadPanel();
					panel.BackColor = Color.FromArgb(uploadElement.Color);
					panel.Dock = DockStyle.Top;
					panel.Height = 50;
					panel.Width = 100;
					panel.Upload += new UploadAction(panel_Upload);
					panel.Description = uploadElement.Description;
					Main.Panel2.Controls.Add(panel);
					height += 50;
				}
			}

			SetDesktopBounds(canvas.Right - 150, canvas.Bottom - height, 100, height);
			
			fadeTimer = new Timer();
			fadeTimer.Interval = 5000;
			fadeTimer.Tick += new EventHandler(fadeTimer_Tick);
			if (!keepAlive) 
				fadeTimer.Start();
		}

		bool panel_Upload(object sender, UploadEventArgs e) {
			Opacity = 1;
			fadeTimer.Interval = 5000;
			MessageBox.Show(e.FileName);
			return true;
		}

		void fadeTimer_Tick(object sender, EventArgs e) {
			Opacity -= .1;
			fadeTimer.Interval = 50;
			if (Opacity == 0)
				Close();
		}

		private void Close_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
