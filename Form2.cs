using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CapacityManager
{
    public partial class SettingForm : Form
    {
        private static string driveLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private DirectoryInfo folder;
        private ImageList ImageList1 = new ImageList();
        Icon iconForFile;
        

        public SettingForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ImageView.Columns.Add("확장자", 100);
            MovieView.Columns.Add("확장자", 100);
            DocView.Columns.Add("확장자", 100);
            EtcView.Columns.Add("확장자", 100);
            SystemView.Columns.Add("구분",100);
           
            ListViewItem item = new ListViewItem("Windows");
            SystemView.Items.Add(item);
            item = new ListViewItem("Program");
            SystemView.Items.Add(item);

            SettingController sc = SettingController.GetInstance();
            fillTree();
            fillView(sc.MovieList, sc.ImageList, sc.DocList, sc.EtcList, sc.SystemList, sc.LastDay);
            TargetFolder.Text = sc.TargetFolder;
        }

        private void fillView(ArrayList MovieList, ArrayList ImageList, ArrayList DocList, 
            ArrayList EtcList, ArrayList SystemList, int LastDay)
        {
            SettingController sc = SettingController.GetInstance();
            
            MovieView.Items.Clear();
            ImageView.Items.Clear();
            DocView.Items.Clear();
            EtcView.Items.Clear();

            foreach (string a in MovieList)
            {                
                ListViewItem item = new ListViewItem(a);
                MovieView.Items.Add(item);
            }
            foreach (string a in ImageList)
            {                
                ListViewItem item = new ListViewItem(a);
                ImageView.Items.Add(item);
            }
            foreach (string a in DocList)
            {                
                ListViewItem item = new ListViewItem(a);
                DocView.Items.Add(item);
            }
            foreach (string a in EtcList)
            {                
                ListViewItem item = new ListViewItem(a);
                EtcView.Items.Add(item);
            }
            foreach (string a in SystemList)
            {
                
                foreach (ListViewItem ac in SystemView.Items)
                {
                    if(ac.Text == a)
                        ac.Checked = true;
                }
                
            }
            LastDayTextbox.Text = LastDay.ToString();
        }

        private void fillTree()
        {
            DirectoryInfo directory;
            string sCurPath = "";

            // clear out the old values
            treeView1.Nodes.Clear();

            // loop through the drive letters and find the available drives.
            foreach (char c in driveLetters)
            {
                sCurPath = c + ":\\";
                try
                {
                    // get the directory informaiton for this path.
                    directory = new DirectoryInfo(sCurPath);


                    // if the retrieved directory information points to a valid
                    // directory or drive in this case, add it to the root of the 
                    // treeView.
                    if (directory.Exists == true)
                    {
                        TreeNode newNode = new TreeNode(directory.FullName);
                        treeView1.Nodes.Add(newNode);	// add the new node to the root level.
                        getSubDirs(newNode);			// scan for any sub folders on this drive.
                    }
                }
                catch (Exception doh)
                {
                    Console.WriteLine(doh.Message);
                }
            }
        }

        private void getSubDirs(TreeNode parent)
        {
            DirectoryInfo directory;
            try
            {
                // if we have not scanned this folder before
                if (parent.Nodes.Count == 0)
                {
                    directory = new DirectoryInfo(parent.FullPath);
                    foreach (DirectoryInfo dir in directory.GetDirectories())
                    {
                        TreeNode newNode = new TreeNode(dir.Name);
                        parent.Nodes.Add(newNode);
                    }
                }

                // now that we have the children of the parent, see if they
                // have any child members that need to be scanned.  Scanning 
                // the first level of sub folders insures that you properly 
                // see the '+' or '-' expanding controls on each node that represents
                // a sub folder with it's own children.
                foreach (TreeNode node in parent.Nodes)
                {
                    // if we have not scanned this node before.
                    if (node.Nodes.Count == 0)
                    {
                        // get the folder information for the specified path.
                        directory = new DirectoryInfo(node.FullPath);

                        // check this folder for any possible sub-folders
                        foreach (DirectoryInfo dir in directory.GetDirectories())
                        {
                            // make a new TreeNode and add it to the treeView.
                            TreeNode newNode = new TreeNode(dir.Name);
                            node.Nodes.Add(newNode);
                        }
                    }
                }
            }
            catch (Exception doh)
            {
                Console.WriteLine(doh.Message);
            }
        }

        /// <summary> method treeView1_BeforeSelect
        /// <para>Before we select a tree node we want to make sure that we scan the soon to be selected
        /// tree node for any sub-folders.  this insures proper tree construction on the fly.</para>
        /// <param name="sender">The object that invoked this event</param>
        /// <param name="e">The TreeViewCancelEventArgs event arguments.</param>
        /// <see cref="System.Windows.Forms.TreeViewCancelEventArgs"/>
        /// <see cref="System.Windows.Forms.TreeView"/>
        /// </summary>
        private void treeView1_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            getSubDirs(e.Node);					// get the sub-folders for the selected node.
            TargetFolder.Text = fixPath(e.Node);	// update the user selection text box.
            folder = new DirectoryInfo(e.Node.FullPath);	// get it's Directory info.
        }

        /// <summary> method treeView1_BeforeExpand
        /// <para>Before we expand a tree node we want to make sure that we scan the soon to be expanded
        /// tree node for any sub-folders.  this insures proper tree construction on the fly.</para>
        /// <param name="sender">The object that invoked this event</param>
        /// <param name="e">The TreeViewCancelEventArgs event arguments.</param>
        /// <see cref="System.Windows.Forms.TreeViewCancelEventArgs"/>
        /// <see cref="System.Windows.Forms.TreeView"/>
        /// </summary>
        private void treeView1_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            getSubDirs(e.Node);					// get the sub-folders for the selected node.
            TargetFolder.Text = fixPath(e.Node);	// update the user selection text box.
            folder = new DirectoryInfo(e.Node.FullPath);	// get it's Directory info.
        }

        private string fixPath(TreeNode node)
        {
            string sRet = "";
            try
            {
                sRet = node.FullPath;
                int index = sRet.IndexOf("\\\\");
                if (index > 1)
                {
                    sRet = node.FullPath.Remove(index, 1);
                }
            }
            catch (Exception doh)
            {
                Console.WriteLine(doh.Message);
            }
            return sRet;
        }

        private void LastTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fillView(SettingController.InitMovieList, SettingController.InitImageList, SettingController.InitDocList,
                SettingController.InitEtcList, SettingController.ExceptFolder, SettingController.Lastday);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveOption();
            Close();
        }
        private void SaveOption()
        {
            SettingController sc = SettingController.GetInstance();
            sc.SaveIniValue
                (GetMoviewListValue(), GetImageListValue(), GetDocwListValue(),
                GetEtcListValue(), GetSystemListValue(), LastDayTextbox.Text);
            sc.TargetFolder = TargetFolder.Text;
            sc.SettingOptionFromIni();
        }

        private ArrayList GetMoviewListValue()
        {
            ArrayList list = new ArrayList();
            list.Clear();

            foreach (ListViewItem item in MovieView.Items)
            {
                list.Add(item.Text);
            }
            
            return list;
        }
        private ArrayList GetImageListValue()
        {
            ArrayList list = new ArrayList();
            list.Clear();

            foreach (ListViewItem item in ImageView.Items)
            {
                list.Add(item.Text);
            }

            return list;
        }
        private ArrayList GetDocwListValue()
        {
            ArrayList list = new ArrayList();
            list.Clear();

            foreach (ListViewItem item in DocView.Items)
            {
                list.Add(item.Text);
            }

            return list;
        }
        private ArrayList GetEtcListValue()
        {
            ArrayList list = new ArrayList();
            list.Clear();

            foreach (ListViewItem item in EtcView.Items)
            {
                list.Add(item.Text);
            }

            return list;
        }
        private ArrayList GetSystemListValue()
        {
            ArrayList list = new ArrayList();
            list.Clear();

            foreach (ListViewItem item in SystemView.Items)
            {
                if(item.Checked)
                    list.Add(item.Text);
            }

            return list;
        }

        //Movie Ext Add
        private void button1_Click(object sender, EventArgs e)
        {
            InputWindows iw = new InputWindows();
            if(DialogResult.OK == iw.ShowDialog() && iw.Ext != null)
                MovieView.Items.Add("."+iw.Ext);
        }

        //Image Ext Add
        private void button3_Click(object sender, EventArgs e)
        {
            InputWindows iw = new InputWindows();
            if (DialogResult.OK == iw.ShowDialog() && iw.Ext != null)
                ImageView.Items.Add("." + iw.Ext);
        }

        //Doc Ext Add
        private void button6_Click(object sender, EventArgs e)
        {
            InputWindows iw = new InputWindows();
            if (DialogResult.OK == iw.ShowDialog() && iw.Ext != null)
                DocView.Items.Add("." + iw.Ext);
        }

        //Etc Ext Add
        private void button8_Click(object sender, EventArgs e)
        {
            InputWindows iw = new InputWindows();
            if (DialogResult.OK == iw.ShowDialog() && iw.Ext != null)
                EtcView.Items.Add("." + iw.Ext);
        }

        //Movie Ext Remove
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MovieView.Items)
            {
                if (item.Selected)
                    MovieView.Items.Remove(item);
            }
        }

        //Image Ext Remove
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ImageView.Items)
            {
                if (item.Selected)
                    ImageView.Items.Remove(item);
            }
        }

        //Doc Remove
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in DocView.Items)
            {
                if (item.Selected)
                    DocView.Items.Remove(item);
            }
        }

        //Etc Ext Remove
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in EtcView.Items)
            {
                if (item.Selected)
                    EtcView.Items.Remove(item);
            }
        }

    }
}
