using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;
using System.IO;
using ScintillaNet;
namespace Bukkit_Plugin_Writer
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void adderror(ErrorType type, string Description, string File, int Line, int Column)
        {
            /*
            if (switchButton1.Value && type == ErrorType.Error)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));
            if (switchButton2.Value && type == ErrorType.Warning)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));
            if (switchButton3.Value && type == ErrorType.Message)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));*/
        }

        public enum ErrorType { Error, Warning, Message }

        public void openProject(string bpwFile)
        {
            string[] split = bpwFile.Split('\\');
            string Folder = bpwFile.Remove(bpwFile.Length - 4);
            treeView1.Nodes.Clear();
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(Folder);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(System.IO.DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);

                foreach (FileInfo file in subDir.EnumerateFiles())
                {
                    TreeNode bNode = new TreeNode(file.Name, 0, 0);
                    bNode.Tag = file.FullName;
                    bNode.ImageKey = "file";
                    aNode.Nodes.Add(bNode);
                }
            }
        }

        public void createEditorTab(string Location)
        {
            ScintillaNet.Scintilla scintilla = new ScintillaNet.Scintilla();
            scintilla.Caret.BlinkRate = 500;
            scintilla.ConfigurationManager.CustomLocation = "C:\\Program Files\\Bukkit Plugin Writer\\code highlighting.xml";
            scintilla.ConfigurationManager.Language = "java";
            scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            scintilla.Folding.IsEnabled = false;
            scintilla.Indentation.TabWidth = 4;
            scintilla.Indentation.UseTabs = false;
            scintilla.Location = new System.Drawing.Point(0, 0);
            scintilla.Margins.Margin0.Width = 20;
            scintilla.Margins.Margin2.IsClickable = false;
            scintilla.Margins.Margin2.IsFoldMargin = false;
            scintilla.Name = "scintilla1";
            scintilla.Printing.PageSettings.Color = false;
            scintilla.Size = new System.Drawing.Size(377, 147);
            scintilla.Styles.Bits = 5;
            scintilla.Styles.BraceBad.FontName = "Verdana";
            scintilla.Styles.BraceLight.FontName = "Verdana";
            scintilla.Styles.ControlChar.FontName = "Verdana";
            scintilla.Styles.Default.FontName = "Verdana";
            scintilla.Styles.IndentGuide.FontName = "Verdana";
            scintilla.Styles.LastPredefined.FontName = "Verdana";
            scintilla.Styles.LineNumber.FontName = "Verdana";
            scintilla.Styles.Max.FontName = "Verdana";
            scintilla.TabIndex = 0;
            DockContainerItem tab = new DockContainerItem();
            PanelDockContainer container = new PanelDockContainer();
            tab.Control = container;
            bar4.Items.Add(tab);
            container.Controls.Add(scintilla);
            tab.Text = "New File";
            if (Location != "")
            {
                if(System.IO.File.Exists(Location))
                {
                    System.IO.StreamReader reader = new System.IO.StreamReader(Location);
                    scintilla.Text = reader.ReadToEnd();
                    scintilla.Tag = Location;
                    reader.Close();
                    tab.Text = Location.Split('\\')[Location.Split('\\').Count() - 1];
                }
            }
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 27;
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            (new NewPlugin(this)).ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openProject(openFileDialog1.FileName);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (File.Exists(e.Node.Tag.ToString()))
                createEditorTab(e.Node.Tag.ToString());
            else
                MessageBox.Show(e.Node.Tag.ToString());
              
        }

        private void save(string text, string location)
        {
            StreamWriter stream = new StreamWriter(location);
            stream.Write(text);
            stream.Close();
        }

        private void bar4_DockTabClosing(object sender, DockTabClosingEventArgs e)
        {
            foreach (object b in e.DockContainerItem.Control.Controls)
            {
                if (b is Scintilla)
                {
                    Scintilla saveme = (Scintilla)b;
                    save(saveme.Text, saveme.Tag.ToString());
                }
            }
            
        }
    }
}
