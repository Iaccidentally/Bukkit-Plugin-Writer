using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

namespace Bukkit_Plugin_Writer
{
    public partial class NewPlugin : DevComponents.DotNetBar.Office2007Form
    {
        public NewPlugin()
        {
            InitializeComponent();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have a website, type it here backwards, otherwise use your email backwards.\nFor example.org, type \"org.example\"\nFor john.sample@example.org, type org.example.sample.john");
        }

        private void pluginWriterName_TextChanged(object sender, EventArgs e)
        {
            pluginNamespace.Text = pluginWebsiteBackwards.Text + ".plugins." + pluginName.Text;
        }

        private void pluginNamespace_TextChanged(object sender, EventArgs e)
        {
            if (pluginNamespace.Text.StartsWith("org.bukkit"))
            {
                MessageBox.Show("You may not use a namespace that begins with org.bukkit.");
                pluginNamespace.Text = "";
                if (pluginWebsiteBackwards.Text.StartsWith("org.bukkit"))
                    pluginWebsiteBackwards.Text = "";

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                pluginFolder.Text = folderBrowserDialog1.SelectedPath;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (pluginName.Text != "" && pluginNamespace.Text != "" && pluginVersion.Text != "" && pluginFolder.Text != "")
            {
                if (Directory.Exists(pluginFolder.Text + Path.PathSeparator + pluginName.Text))
                {
                    MessageBox.Show("The folder that you have specified already has a plugin by that name, if you click yes it will be deleted. Continue?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                }
                Directory.CreateDirectory(pluginFolder.Text + Path.PathSeparator + pluginName.Text);
                
            }
            else
            {
                MessageBox.Show("Please make sure all fields (Website Backwards is optional if you understand the namespace) are filled and try again", "Error making plugin");
            }
        }
    }
}