namespace Tfs.FileDistributor.Forms {
	partial class SettingsForm {
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
			this.components = new System.ComponentModel.Container();
			this.AddItem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Panels = new System.Windows.Forms.Panel();
			this.AddItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// AddItem
			// 
			this.AddItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPanelToolStripMenuItem});
			this.AddItem.Name = "AddItem";
			this.AddItem.Size = new System.Drawing.Size(134, 26);
			// 
			// addPanelToolStripMenuItem
			// 
			this.addPanelToolStripMenuItem.Name = "addPanelToolStripMenuItem";
			this.addPanelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.addPanelToolStripMenuItem.Text = "Add Panel";
			this.addPanelToolStripMenuItem.Click += new System.EventHandler(this.addPanelToolStripMenuItem_Click);
			// 
			// Panels
			// 
			this.Panels.AutoSize = true;
			this.Panels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Panels.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panels.Location = new System.Drawing.Point(10, 10);
			this.Panels.Name = "Panels";
			this.Panels.Size = new System.Drawing.Size(442, 106);
			this.Panels.TabIndex = 2;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(462, 126);
			this.ContextMenuStrip = this.AddItem;
			this.Controls.Add(this.Panels);
			this.Name = "SettingsForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Distributor Configuration";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.AddItem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip AddItem;
		private System.Windows.Forms.ToolStripMenuItem addPanelToolStripMenuItem;
		private System.Windows.Forms.Panel Panels;
	}
}