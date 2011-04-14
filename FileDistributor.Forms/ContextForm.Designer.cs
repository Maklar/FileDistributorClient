namespace Tfs.FileDistributor.Forms {
	partial class ContextForm {
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
			this.Main = new System.Windows.Forms.SplitContainer();
			this.Exit = new System.Windows.Forms.LinkLabel();
			this.Configure = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
			this.Main.Panel1.SuspendLayout();
			this.Main.Panel2.SuspendLayout();
			this.Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main
			// 
			this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.Main.Location = new System.Drawing.Point(0, 0);
			this.Main.Name = "Main";
			this.Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Main.Panel1
			// 
			this.Main.Panel1.Controls.Add(this.Exit);
			this.Main.Panel1MinSize = 0;
			// 
			// Main.Panel2
			// 
			this.Main.Panel2.Controls.Add(this.Configure);
			this.Main.Panel2MinSize = 0;
			this.Main.Size = new System.Drawing.Size(60, 67);
			this.Main.SplitterDistance = 31;
			this.Main.TabIndex = 0;
			// 
			// Exit
			// 
			this.Exit.AutoSize = true;
			this.Exit.Location = new System.Drawing.Point(3, 9);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(24, 13);
			this.Exit.TabIndex = 0;
			this.Exit.TabStop = true;
			this.Exit.Text = "Exit";
			this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
			// 
			// Configure
			// 
			this.Configure.AutoSize = true;
			this.Configure.Location = new System.Drawing.Point(3, 10);
			this.Configure.Name = "Configure";
			this.Configure.Size = new System.Drawing.Size(52, 13);
			this.Configure.TabIndex = 1;
			this.Configure.TabStop = true;
			this.Configure.Text = "Configure";
			this.Configure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Configure_LinkClicked);
			// 
			// ContextForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(60, 67);
			this.ControlBox = false;
			this.Controls.Add(this.Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ContextForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TopMost = true;
			this.Main.Panel1.ResumeLayout(false);
			this.Main.Panel1.PerformLayout();
			this.Main.Panel2.ResumeLayout(false);
			this.Main.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
			this.Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer Main;
		private System.Windows.Forms.LinkLabel Exit;
		private System.Windows.Forms.LinkLabel Configure;
	}
}