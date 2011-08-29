namespace Bukkit_Plugin_Writer
{
    partial class NewPlugin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlugin));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pluginName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pluginVersion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pluginWebsiteBackwards = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.pluginNamespace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pluginFolder = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Plugin Name";
            // 
            // pluginName
            // 
            // 
            // 
            // 
            this.pluginName.Border.Class = "TextBoxBorder";
            this.pluginName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pluginName.Location = new System.Drawing.Point(135, 12);
            this.pluginName.Name = "pluginName";
            this.pluginName.Size = new System.Drawing.Size(244, 20);
            this.pluginName.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Website Backwards";
            // 
            // pluginVersion
            // 
            // 
            // 
            // 
            this.pluginVersion.Border.Class = "TextBoxBorder";
            this.pluginVersion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pluginVersion.Location = new System.Drawing.Point(135, 41);
            this.pluginVersion.Name = "pluginVersion";
            this.pluginVersion.Size = new System.Drawing.Size(244, 20);
            this.pluginVersion.TabIndex = 1;
            this.pluginVersion.Text = "0.0.1";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Version";
            // 
            // pluginWebsiteBackwards
            // 
            // 
            // 
            // 
            this.pluginWebsiteBackwards.Border.Class = "TextBoxBorder";
            this.pluginWebsiteBackwards.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pluginWebsiteBackwards.Location = new System.Drawing.Point(135, 73);
            this.pluginWebsiteBackwards.Name = "pluginWebsiteBackwards";
            this.pluginWebsiteBackwards.Size = new System.Drawing.Size(244, 20);
            this.pluginWebsiteBackwards.TabIndex = 1;
            this.pluginWebsiteBackwards.TextChanged += new System.EventHandler(this.pluginWriterName_TextChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelX4.Location = new System.Drawing.Point(117, 70);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(10, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "?";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 99);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Plugin Namespace";
            // 
            // pluginNamespace
            // 
            // 
            // 
            // 
            this.pluginNamespace.Border.Class = "TextBoxBorder";
            this.pluginNamespace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pluginNamespace.Location = new System.Drawing.Point(135, 102);
            this.pluginNamespace.Name = "pluginNamespace";
            this.pluginNamespace.Size = new System.Drawing.Size(244, 20);
            this.pluginNamespace.TabIndex = 1;
            this.pluginNamespace.TextChanged += new System.EventHandler(this.pluginNamespace_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(312, 156);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Create";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // pluginFolder
            // 
            // 
            // 
            // 
            this.pluginFolder.Border.Class = "TextBoxBorder";
            this.pluginFolder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pluginFolder.Location = new System.Drawing.Point(135, 128);
            this.pluginFolder.Name = "pluginFolder";
            this.pluginFolder.Size = new System.Drawing.Size(175, 20);
            this.pluginFolder.TabIndex = 1;
            this.pluginFolder.TextChanged += new System.EventHandler(this.pluginNamespace_TextChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(312, 128);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Choose";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 125);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Location";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose the folder all your plugins are kept in";
            // 
            // NewPlugin
            // 
            this.ClientSize = new System.Drawing.Size(399, 191);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.pluginFolder);
            this.Controls.Add(this.pluginNamespace);
            this.Controls.Add(this.pluginWebsiteBackwards);
            this.Controls.Add(this.pluginVersion);
            this.Controls.Add(this.pluginName);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlugin";
            this.Text = "New Plugin";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX pluginName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX pluginVersion;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX pluginWebsiteBackwards;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX pluginNamespace;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX pluginFolder;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}