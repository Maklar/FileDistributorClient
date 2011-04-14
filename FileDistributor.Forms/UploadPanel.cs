using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tfs.FileDistributor.Forms {

	public delegate bool UploadAction(object sender, UploadEventArgs e);
	
	public partial class UploadPanel : UserControl {
		public event UploadAction BeforeUpload;
		public event UploadAction Upload;
		public event UploadAction AfterUpload;
		public string Description {
			get { return DescriptionLabel.Text; }
			set { 
				DescriptionLabel.Text = value;
				DescriptionLabel.Left = Width / 2 - DescriptionLabel.Width / 2;
				DescriptionLabel.Top = Height / 2 - DescriptionLabel.Height / 2;
			}
		}

		public UploadPanel() {
			InitializeComponent();
		}

		private void UploadFiles(string[] fileNames) {
			foreach (string fileName in fileNames) {
				if (fileName.EndsWith(@"\")) {
					if (BeforeUpload != null)
						BeforeUpload(this, new UploadEventArgs { DirectoryName = fileName });
					if (Upload != null)
						Upload(this, new UploadEventArgs { DirectoryName = fileName });
					if (AfterUpload != null)
						AfterUpload(this, new UploadEventArgs { DirectoryName = fileName });
				}
				else {
					if (BeforeUpload != null)
						BeforeUpload(this, new UploadEventArgs { FileName = fileName });
					if (Upload != null)
						Upload(this, new UploadEventArgs { FileName = fileName });
					if (AfterUpload != null)
						AfterUpload(this, new UploadEventArgs { FileName = fileName });
				}
			}
		}

		private void UploadPanel_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
		        e.Effect = DragDropEffects.Copy;
		}

		private void UploadPanel_DragDrop(object sender, DragEventArgs e) {
			string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
			    if (e.Effect == DragDropEffects.Copy)
			        UploadFiles(fileNames);
		}
	}

	public class UploadEventArgs {
		public string FileName { get; set; }
		public string DirectoryName { get; set; }
	}
}
