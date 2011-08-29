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
            pluginFolder.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Bukkit Plugins";
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
            if (pluginFolder.Text != "")
                folderBrowserDialog1.SelectedPath = pluginFolder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                pluginFolder.Text = folderBrowserDialog1.SelectedPath;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (pluginName.Text != "" && pluginNamespace.Text != "" && pluginVersion.Text != "" && pluginFolder.Text != "")
            {
                string Location = pluginFolder.Text + Path.DirectorySeparatorChar + pluginName.Text;
                if (Directory.Exists(Location))
                {
                    if (MessageBox.Show("The folder that you have specified already has a plugin by that name, if you click yes it will be deleted. Continue?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                        return;
                    else
                        Directory.Delete(Location);
                }
                Directory.CreateDirectory(Location);
                StreamWriter bpwwriter = new StreamWriter(Location + ".bpw");
                //Write config to file
                bpwwriter.Close();
                
            }
            else
            {
                MessageBox.Show("Please make sure all fields (Website Backwards is optional if you understand the namespace) are filled and try again", "Error making plugin");
            }
        }
    }
}