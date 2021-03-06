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
        Form1 sender;
        public NewPlugin(Form1 sender)
        {
            InitializeComponent();
            this.sender = sender;
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
                    {
                        Directory.Delete(Location, true);
                        File.Delete(Location + ".bpw");
                    }
                }
                Directory.CreateDirectory(Location);
                StreamWriter bpwwriter = new StreamWriter(Location + ".bpw");
                //TODO Write project config to file
                bpwwriter.Close();
                Directory.CreateDirectory(Location + Path.DirectorySeparatorChar + "src");
                string[] plnamespace = pluginNamespace.Text.Split('.');
                string a = Location + Path.DirectorySeparatorChar + "src"; 
                foreach (string b in plnamespace)
                {
                    a += Path.DirectorySeparatorChar + b;
                    Directory.CreateDirectory(a);

                    /*Creates all of the subdirectories
                     * such as src/org/bukkit/blah/blah/blah from the namespace given*/
                }
                StreamWriter pluginDotJava = new StreamWriter(a + Path.DirectorySeparatorChar + pluginName.Text + ".java");
                pluginDotJava.WriteLine("package " + pluginNamespace.Text + "." + pluginName.Text +";");
                pluginDotJava.WriteLine("\n");
                //TODO Moar Imports here
                pluginDotJava.WriteLine("import org.bukkit.plugin.java.*;");
                pluginDotJava.WriteLine();
                pluginDotJava.WriteLine("public class " + pluginName.Text + " extends JavaPlugin {");
                pluginDotJava.WriteLine("    public void onDisable() { ");
                pluginDotJava.WriteLine("        //Code that runs when your plugin is disabled");
                pluginDotJava.WriteLine("    }");
                pluginDotJava.WriteLine();
                pluginDotJava.WriteLine("    public void onEnable() { ");
                pluginDotJava.WriteLine("        //Code that runs when your plugin is enabled");
                pluginDotJava.WriteLine("    }");
                pluginDotJava.WriteLine("}");
                pluginDotJava.WriteLine();
                pluginDotJava.Close();
                StreamWriter pluginDotYML = new StreamWriter(Location + Path.DirectorySeparatorChar + "plugin.yml");
                pluginDotYML.WriteLine("name: " + pluginName.Text);
                pluginDotYML.WriteLine("version: " + pluginVersion.Text);
                pluginDotYML.WriteLine("main: " + pluginNamespace.Text + "." + pluginName.Text);
                pluginDotYML.Close();
                StreamWriter dotClassPath = new StreamWriter(Location + Path.DirectorySeparatorChar + ".classpath");
                //I have set this up the same way eclipse does it, but I am beginning to think this is not neccesary.. I know nothing about compiling java.
                dotClassPath.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                dotClassPath.WriteLine("<classpath>");
                dotClassPath.WriteLine("    <classpathentry type=\"src\" path=\"src\"/>");
                dotClassPath.WriteLine("    <classpathentry type=\"con\" path=\"org.eclipse.jdt.launching.JRE_CONTAINER/org.eclipse.jdt.internal.debug.ui.launcher.StandardVMType/JavaSE-1.6\"/>");
                dotClassPath.WriteLine("    <classpathentry type=\"lib\" path=\"C:\\Program Files\\Bukkit Plugin Writer\\jars\\bukkit.jar\"/>");
                //Add more includes if needed, for a basic plugin, I think only the JRE and Bukkit are required.
                //More needs to be able to be added later :-)
                dotClassPath.WriteLine("</classpath>");
                dotClassPath.Close();
                this.sender.openProject(Location + ".bps");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make sure all fields (Website Backwards is optional if you understand the namespace) are filled and try again", "Error making plugin");
            }
        }
    }
}