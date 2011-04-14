using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tfs.FileDistributor.Forms {
	public partial class ContextForm : Form {
		public ContextForm(Rectangle canvas) {
			InitializeComponent();

			SetDesktopBounds(canvas.Right - 150, canvas.Bottom - 70, Width, Height);
		}

		private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Application.Exit();
		}

		private void Configure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			SettingsForm form = new SettingsForm();
			form.ShowDialog(this);
		}
	}
}
