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
	public partial class SettingsForm : Form {
		Configuration configuration;
		
		public SettingsForm() {
			InitializeComponent();

			configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			UploadSettingsConfigSection section = (UploadSettingsConfigSection)configuration.GetSection("UploadSettings");
			if (section != null) {
				foreach (UploadElement uploadElement in section.UploadSettings) {
					Panels.Controls.Add(new PanelConfig(uploadElement, configuration));
				}
			}
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (configuration != null)
				configuration.Save(ConfigurationSaveMode.Full);
		}

		private void addPanelToolStripMenuItem_Click(object sender, EventArgs e) {
			UploadSettingsConfigSection section = (UploadSettingsConfigSection)configuration.GetSection("UploadSettings");
			if (section != null) { 
				UploadElement uploadElement = new UploadElement { UploadType = "NAS", Color = 0, Active = false };
				section.UploadSettings.Add(uploadElement);
				Panels.Controls.Add(new PanelConfig(uploadElement, configuration));
			}
		}
	}
}
