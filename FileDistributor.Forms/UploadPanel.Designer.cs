namespace Tfs.FileDistributor.Forms {
	partial class UploadPanel {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.DescriptionLabel.Location = new System.Drawing.Point(15, 19);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(68, 13);
			this.DescriptionLabel.TabIndex = 0;
			this.DescriptionLabel.Text = "Upload Type";
			// 
			// UploadPanel
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.DescriptionLabel);
			this.Name = "UploadPanel";
			this.Size = new System.Drawing.Size(100, 50);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UploadPanel_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UploadPanel_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DescriptionLabel;

	}
}
