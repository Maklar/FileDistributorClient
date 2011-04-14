namespace Tfs.FileDistributor.Forms {
	partial class UploadForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
			this.Banner = new System.Windows.Forms.Panel();
			this.Main = new System.Windows.Forms.SplitContainer();
			this.Close = new System.Windows.Forms.PictureBox();
			this.Banner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
			this.Main.Panel1.SuspendLayout();
			this.Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
			this.SuspendLayout();
			// 
			// Banner
			// 
			this.Banner.BackColor = System.Drawing.Color.Azure;
			this.Banner.Controls.Add(this.Close);
			this.Banner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Banner.Location = new System.Drawing.Point(0, 0);
			this.Banner.Name = "Banner";
			this.Banner.Size = new System.Drawing.Size(100, 23);
			this.Banner.TabIndex = 0;
			// 
			// Main
			// 
			this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.Main.IsSplitterFixed = true;
			this.Main.Location = new System.Drawing.Point(0, 0);
			this.Main.Name = "Main";
			this.Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Main.Panel1
			// 
			this.Main.Panel1.Controls.Add(this.Banner);
			this.Main.Panel1MinSize = 0;
			this.Main.Panel2MinSize = 0;
			this.Main.Size = new System.Drawing.Size(100, 89);
			this.Main.SplitterDistance = 23;
			this.Main.SplitterWidth = 1;
			this.Main.TabIndex = 1;
			// 
			// Close
			// 
			this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
			this.Close.Location = new System.Drawing.Point(80, 4);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(17, 19);
			this.Close.TabIndex = 1;
			this.Close.TabStop = false;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// UploadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(100, 89);
			this.ControlBox = false;
			this.Controls.Add(this.Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "UploadForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TopMost = true;
			this.Banner.ResumeLayout(false);
			this.Main.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
			this.Main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Banner;
		private System.Windows.Forms.SplitContainer Main;
		private System.Windows.Forms.PictureBox Close;

	}
}