using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tfs.FileDistributor.Forms {
	public partial class MainForm : Form {
		private UploadForm uploadForm;
		
		public MainForm() {
			InitializeComponent();
		}

		public void UploadPopup(bool keepAlive) {
			if (uploadForm != null)
				uploadForm.Close();

			uploadForm = new UploadForm(keepAlive, Screen.PrimaryScreen.WorkingArea);
			uploadForm.Show();
		}

		private void FileUploadIcon_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == System.Windows.Forms.MouseButtons.Right) 
				MainMenu.Show(Screen.PrimaryScreen.WorkingArea.Right - 150, Screen.PrimaryScreen.WorkingArea.Bottom - 50);
				//new ContextForm(Screen.PrimaryScreen.WorkingArea).Show();
			else 
				UploadPopup(false);
		}

		private void FileUploadIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (e.Button != System.Windows.Forms.MouseButtons.Right) 
				UploadPopup(true);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void configureToolStripMenuItem_Click(object sender, EventArgs e) {
			new SettingsForm().ShowDialog(this);
		}
	}
}
