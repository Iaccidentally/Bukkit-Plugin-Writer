using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace Bukkit_Plugin_Writer
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {

        public Form1()
        {
            InitializeComponent();
            adderror(ErrorType.Error, "Random", "blah", 1, 2);
            adderror(ErrorType.Warning, "Random", "blah", 1, 2);
            adderror(ErrorType.Message, "Random", "blah", 1, 2);
            adderror(ErrorType.Error, "Random", "blah", 1, 2);
        }

        public void adderror(ErrorType type, string Description, string File, int Line, int Column)
        {
            if (switchButton1.Value && type == ErrorType.Error)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));
            if (switchButton2.Value && type == ErrorType.Warning)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));
            if (switchButton3.Value && type == ErrorType.Message)
                advTree1.Nodes.Add(new Error(type, advTree1.Nodes.Count + 1, Description, File, Line, Column));
        }

        public enum ErrorType { Error, Warning, Message }

        public class Error : DevComponents.AdvTree.Node
        {
            public Error(ErrorType type, int Number, string Description, string File, int Line, int Column)
            {
                this.Cells.Clear();
                this.Cells.Insert(0, new DevComponents.AdvTree.Cell((type.ToString()[0]).ToString()));
                this.Cells.Insert(1, new DevComponents.AdvTree.Cell(Number.ToString()));
                this.Cells.Insert(2, new DevComponents.AdvTree.Cell(Description));
                this.Cells.Insert(3, new DevComponents.AdvTree.Cell(File));
                this.Cells.Insert(4, new DevComponents.AdvTree.Cell(Line.ToString()));
                this.Cells.Insert(5, new DevComponents.AdvTree.Cell(Column.ToString()));
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
    }
}
