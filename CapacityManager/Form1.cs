using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

using System.Collections;

namespace CapacityManager
{
    public partial class CapacityManager : Form
    {
        Image oldBtnImage;
        Button oldClickedButton;
        IController uc;
        long FileTotalCount;
        long DetectedCount;
        bool Searching;
        ListView SelectedListView;
        

        public CapacityManager()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DetectedCount = 0;

            InitialChecker IC = new InitialChecker();
            IC.UpdateRegistAccessDate();
            IC.CheckOptionFile();

            InitializeComponent();
            InitializeListView();

            SelectedListView = ListV_Movie;

            uc = new UIController(this);
            CheckForIllegalCrossThreadCalls = false;

            oldBtnImage = TAB_BTN_MOVIE.BackgroundImage;

            
        }
        private void InitializeListView()
        {
            ListV_Movie.Columns.Add("파일명", 400);
            ListV_Movie.Columns.Add("파일크기", 150);
            ListV_Movie.Columns.Add("마지막사용", 150);

            ListV_Doc.Columns.Add("파일명", 400);
            ListV_Doc.Columns.Add("파일크기", 150);
            ListV_Doc.Columns.Add("마지막사용", 150);

            ListV_Image.Columns.Add("파일명", 400);
            ListV_Image.Columns.Add("파일크기", 150);
            ListV_Image.Columns.Add("마지막사용", 150);

            ListV_Etc.Columns.Add("파일명", 400);
            ListV_Etc.Columns.Add("파일크기", 150);
            ListV_Etc.Columns.Add("마지막사용", 150);
            ListV_Movie.Show();
            ListV_Etc.Hide();
            ListV_Doc.Hide();
            ListV_Image.Hide();
        }


        private void TAB_BTN_MOVIE_Pocused(object sender, EventArgs e)
        {
            oldBtnImage = TAB_BTN_MOVIE.BackgroundImage;
        }


        private void TAB_BTN_MOVIE_Click(object sender, EventArgs e)
        {
            ListV_Movie.Show();
            ListV_Etc.Hide();
            ListV_Doc.Hide();
            ListV_Image.Hide();
            OnceClickImage(TAB_BTN_MOVIE);
            SelectedListView = ListV_Movie;
        }

        private void TAB_BTN_IMAGE_Click(object sender, EventArgs e)
        {
            ListV_Movie.Hide();
            ListV_Etc.Hide();
            ListV_Doc.Hide();
            ListV_Image.Show();
            OnceClickImage(TAB_BTN_IMAGE);
            SelectedListView = ListV_Image;
        }

        private void TAB_BTN_DOC_Click(object sender, EventArgs e)
        {
            ListV_Movie.Hide();
            ListV_Etc.Hide();
            ListV_Doc.Show();
            ListV_Image.Hide();
            OnceClickImage(TAB_BTN_DOC);
            SelectedListView = ListV_Doc;
        }

        private void TAB_BTN_FILES_Click(object sender, EventArgs e)
        {
            ListV_Movie.Hide();
            ListV_Etc.Show();
            ListV_Doc.Hide();
            ListV_Image.Hide();
            OnceClickImage(TAB_BTN_FILES);
            SelectedListView = ListV_Etc;

        }

        private void OnceClickImage(Button clickedBtn)
        {
            if(oldClickedButton != null)
               oldClickedButton.BackgroundImage = oldBtnImage;
            oldClickedButton = clickedBtn;
            clickedBtn.BackgroundImage = global::CapacityManager.Properties.Resources.BottonBack1;
        }

        private void BTN_START_Click(object sender, EventArgs e)
        {
            if (Searching == false)
            {
                ListClear();
                DetectedCount = 0;
                StatusLable.Text = "검색을 진행하기 위한 폴더 취합 중입니다.";
                uc.SearchStart();
            }
            else
            {
                StatusLable.Text = "검색을 중단합니다.";
                uc.StopSearch();
                StatusLable.Text = "검색이 중단되었습니다.";
            }
        }

        private void BTN_FILEDELETE_Click(object sender, EventArgs e)
        {
            CirmfirmDelete cm = new CirmfirmDelete(SelectedListView.CheckedItems.Count);
            if (cm.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in SelectedListView.CheckedItems)
                {
                    File.Delete(item.Group.Header + "\\" + item.Text);
                    item.Remove();
                }
            }
        }

        public void BeforeSearchStart()
        {
            SettingButton.Enabled = false;
            DeleteButton.Enabled = false;
            DetectedCount = 0;
            StartButton.Text = "정지";
            Searching = true;
        }

        public void StopComplete()
        {
            SettingButton.Enabled = true;
            DeleteButton.Enabled = true;
            StartButton.Text = "검색시작";
            Searching = false;
        }
        public void AlarmBeforeDetectingFile()
        {
            StatusLable.Text = "검색이 진행중입니다.";
        }
        public void AlarmComleteDetect()
        {
            StatusLable.Text = "검색이 완료되었습니다.";
            StopComplete();
        }

        public void DetectFile(FileInformation file)
        {
            ListView listV;

            switch (file.FileKind)
            {
                case FileInformation.EXT_KIND.IMAGE :
                    listV = ListV_Image;
                    break;
                case FileInformation.EXT_KIND.MOVIE:
                    listV = ListV_Movie;
                    break;
                case FileInformation.EXT_KIND.DOC:
                    listV = ListV_Doc;
                    break;
                case FileInformation.EXT_KIND.ETC:
                    listV = ListV_Etc;
                    break;
                default :
                    listV = null;
                    break;
            }

            if(listV != null)
                InsertFileItem(file, listV);
           
        }
        private void InsertFileItem(FileInformation file, ListView listV)
        {
            ListViewGroup ltGrp;
            ListViewItem a = new ListViewItem(new string[] { file.FileName, file.FileSize.ToString() + "KB", file.LastAccessDate + "일 전" });
            bool group_exists = false;

            foreach (ListViewGroup group in listV.Groups)
            {
                if (group.Header == file.FilePath)
                {
                    a.Group = group;
                    group_exists = true;
                    break;
                }
            }

            if (!group_exists)
            {
                ltGrp = new ListViewGroup(file.FilePath);
                listV.Groups.Add(ltGrp);
                a.Group = ltGrp;
            }

            listV.Items.Add(a);
        }
        
        private void BTN_SETTING_Click(object sender, EventArgs e)
        {
            SettingForm a = new SettingForm();
            a.ShowDialog();
        }

        public void ListClear()
        {
            ListV_Doc.Items.Clear();
            ListV_Movie.Items.Clear();
            ListV_Etc.Items.Clear();
            ListV_Image.Items.Clear();

        }

        public void DetectStartAlarm(long TotalFileCount)
        {
            FileTotalCount = TotalFileCount;
        }

        public void DelectedFolder(long count, string folder)
        {
            FolderLable.Text = folder;
            DetectedCount += count;
            int a = (int) ((10000* DetectedCount) / FileTotalCount);
            progressBar1.Value = a;
            PerLable.Text = string.Format("{0}/{1}", DetectedCount, FileTotalCount);
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void ListViewDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelectedListView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = SelectedListView.SelectedItems;

                ListViewItem item = items[0];
                string a = string.Format("\"{0}\"", item.Group.Header);
                System.Diagnostics.Process.Start("explorer.exe", a );

            }
        }

        private void WindowsClosed(object sender, FormClosedEventArgs e)
        {
            if(Searching)
                uc.StopSearch();
        }

    }
}
