namespace Tfs.FileDistributor.Forms {
	partial class PanelConfig {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelConfig));
			this.UploadType = new System.Windows.Forms.ComboBox();
			this.Description = new System.Windows.Forms.TextBox();
			this.ColorPicker = new System.Windows.Forms.ColorDialog();
			this.Color = new System.Windows.Forms.Button();
			this.Active = new System.Windows.Forms.CheckBox();
			this.RemoveItem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AdditionalSettings = new System.Windows.Forms.LinkLabel();
			this.RemoveItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// UploadType
			// 
			this.UploadType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UploadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UploadType.FormattingEnabled = true;
			this.UploadType.ItemHeight = 13;
			this.UploadType.Items.AddRange(new object[] {
            "NAS",
            "FTP",
            "GIT"});
			this.UploadType.Location = new System.Drawing.Point(220, 2);
			this.UploadType.Name = "UploadType";
			this.UploadType.Size = new System.Drawing.Size(135, 21);
			this.UploadType.TabIndex = 0;
			this.UploadType.SelectedIndexChanged += new System.EventHandler(this.UploadType_SelectedIndexChanged);
			// 
			// Description
			// 
			this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description.Location = new System.Drawing.Point(4, 3);
			this.Description.Multiline = true;
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(210, 21);
			this.Description.TabIndex = 2;
			this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
			// 
			// ColorPicker
			// 
			this.ColorPicker.Color = System.Drawing.Color.White;
			this.ColorPicker.FullOpen = true;
			// 
			// Color
			// 
			this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Color.BackColor = System.Drawing.Color.Transparent;
			this.Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Color.Location = new System.Drawing.Point(361, 2);
			this.Color.Name = "Color";
			this.Color.Size = new System.Drawing.Size(50, 21);
			this.Color.TabIndex = 3;
			this.Color.Text = "Color";
			this.Color.UseVisualStyleBackColor = false;
			this.Color.Click += new System.EventHandler(this.Color_Click);
			// 
			// Active
			// 
			this.Active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Active.Appearance = System.Windows.Forms.Appearance.Button;
			this.Active.BackColor = System.Drawing.Color.Orange;
			this.Active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Active.Location = new System.Drawing.Point(417, 2);
			this.Active.Name = "Active";
			this.Active.Size = new System.Drawing.Size(59, 21);
			this.Active.TabIndex = 4;
			this.Active.Text = "Active";
			this.Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Active.UseVisualStyleBackColor = false;
			this.Active.CheckedChanged += new System.EventHandler(this.Active_CheckedChanged);
			// 
			// RemoveItem
			// 
			this.RemoveItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
			this.RemoveItem.Name = "AddItem";
			this.RemoveItem.Size = new System.Drawing.Size(153, 48);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// AdditionalSettings
			// 
			this.AdditionalSettings.AutoSize = true;
			this.AdditionalSettings.BackColor = System.Drawing.Color.Transparent;
			this.AdditionalSettings.Location = new System.Drawing.Point(482, 5);
			this.AdditionalSettings.Name = "AdditionalSettings";
			this.AdditionalSettings.Size = new System.Drawing.Size(31, 13);
			this.AdditionalSettings.TabIndex = 5;
			this.AdditionalSettings.TabStop = true;
			this.AdditionalSettings.Text = "More";
			this.AdditionalSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdditionalSettings_LinkClicked);
			// 
			// PanelConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ContextMenuStrip = this.RemoveItem;
			this.Controls.Add(this.AdditionalSettings);
			this.Controls.Add(this.Description);
			this.Controls.Add(this.UploadType);
			this.Controls.Add(this.Active);
			this.Controls.Add(this.Color);
			this.Name = "PanelConfig";
			this.Size = new System.Drawing.Size(526, 28);
			this.RemoveItem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox UploadType;
		private System.Windows.Forms.TextBox Description;
		private System.Windows.Forms.ColorDialog ColorPicker;
		private System.Windows.Forms.Button Color;
		private System.Windows.Forms.CheckBox Active;
		private System.Windows.Forms.ContextMenuStrip RemoveItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.LinkLabel AdditionalSettings;
	}
}
