using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Tfs.FileDistributor.Forms {
	public partial class PanelConfig : UserControl {

		public UploadElement Element { get; private set; }
		public Configuration Configuration { get; private set; }

		public PanelConfig(UploadElement element, Configuration configuration) {
			InitializeComponent();

			Element = element;
			Configuration = configuration;
			
			Active.Checked = element.Active;
			Color.BackColor = System.Drawing.Color.FromArgb(element.Color);
			Color.Text = Color.BackColor.Name;
			UploadType.Text = element.UploadType;
			Description.Text = element.Description;
			Dock = DockStyle.Top;
		}

		private void Color_Click(object sender, EventArgs e) {
			ColorPicker.ShowDialog();
			Color.BackColor = ColorPicker.Color;
			Color.Text = ColorPicker.Color.Name;
			Element.Color = ColorPicker.Color.ToArgb();
		}

		private void Active_CheckedChanged(object sender, EventArgs e) {
			if (Active.Checked) {
				Active.BackColor = System.Drawing.Color.OrangeRed;
				Active.Text = "Active";
			}
			else {
				Active.BackColor = System.Drawing.Color.Transparent;
				Active.Text = "Inactive";
			}
			Element.Active = Active.Checked;
		}

		private void UploadType_SelectedIndexChanged(object sender, EventArgs e) {
			Element.UploadType = UploadType.Text;
		}

		private void Description_TextChanged(object sender, EventArgs e) {
			Element.Description = Description.Text;
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
			if (Configuration != null) {
				UploadSettingsConfigSection section = (UploadSettingsConfigSection)Configuration.GetSection("UploadSettings");
				if (section != null) {
					section.UploadSettings.Remove(Element);
					Parent.Controls.Remove(this);
				}
			}
		}

		private void AdditionalSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			switch (UploadType.Text) {

			}
		}
	}
}
