namespace CapacityManager
{
    partial class CapacityManager
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapacityManager));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.ListV_Movie = new System.Windows.Forms.ListView();
            this.StatusLable = new System.Windows.Forms.Label();
            this.FolderLable = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TAB_BTN_FILES = new System.Windows.Forms.Button();
            this.TAB_BTN_DOC = new System.Windows.Forms.Button();
            this.TAB_BTN_IMAGE = new System.Windows.Forms.Button();
            this.TAB_BTN_MOVIE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListV_Doc = new System.Windows.Forms.ListView();
            this.ListV_Image = new System.Windows.Forms.ListView();
            this.ListV_Etc = new System.Windows.Forms.ListView();
            this.SettingButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PerLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListV_Movie
            // 
            this.ListV_Movie.CheckBoxes = true;
            this.ListV_Movie.FullRowSelect = true;
            this.ListV_Movie.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup2.Tag = "d";
            this.ListV_Movie.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListV_Movie.Location = new System.Drawing.Point(13, 153);
            this.ListV_Movie.Name = "ListV_Movie";
            this.ListV_Movie.Size = new System.Drawing.Size(798, 412);
            this.ListV_Movie.TabIndex = 0;
            this.ListV_Movie.UseCompatibleStateImageBehavior = false;
            this.ListV_Movie.View = System.Windows.Forms.View.Details;
           // this.ListV_Movie.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            //this.ListV_Movie.Click += new System.EventHandler(this.ListViewClicked);
           // this.ListV_Movie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseClicked);
            this.ListV_Movie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDoubleClick);
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StatusLable.Location = new System.Drawing.Point(117, 30);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(89, 13);
            this.StatusLable.TabIndex = 2;
            this.StatusLable.Text = "대기중입니다.";
            //this.StatusLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // FolderLable
            // 
            this.FolderLable.AutoSize = true;
            this.FolderLable.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FolderLable.Location = new System.Drawing.Point(117, 63);
            this.FolderLable.MaximumSize = new System.Drawing.Size(500, 20);
            this.FolderLable.Name = "FolderLable";
            this.FolderLable.Size = new System.Drawing.Size(89, 13);
            this.FolderLable.TabIndex = 3;
            this.FolderLable.Text = "대기중입니다.";
            //this.FolderLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 84);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(622, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 10;
            //this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartButton.Location = new System.Drawing.Point(745, 79);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(65, 33);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "검색시작";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.BTN_START_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.Location = new System.Drawing.Point(728, 575);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 29);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "파일삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.BTN_FILEDELETE_Click);
            // 
            // TAB_BTN_FILES
            // 
            this.TAB_BTN_FILES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TAB_BTN_FILES.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TAB_BTN_FILES.Image = global::CapacityManager.Properties.Resources.Documents_icon;
            this.TAB_BTN_FILES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_BTN_FILES.Location = new System.Drawing.Point(383, 121);
            this.TAB_BTN_FILES.Name = "TAB_BTN_FILES";
            this.TAB_BTN_FILES.Size = new System.Drawing.Size(130, 33);
            this.TAB_BTN_FILES.TabIndex = 10;
            this.TAB_BTN_FILES.Text = "기타";
            this.TAB_BTN_FILES.UseVisualStyleBackColor = true;
            this.TAB_BTN_FILES.Click += new System.EventHandler(this.TAB_BTN_FILES_Click);
            // 
            // TAB_BTN_DOC
            // 
            this.TAB_BTN_DOC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TAB_BTN_DOC.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TAB_BTN_DOC.Image = global::CapacityManager.Properties.Resources.Actions_document_edit_icon;
            this.TAB_BTN_DOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_BTN_DOC.Location = new System.Drawing.Point(258, 121);
            this.TAB_BTN_DOC.Name = "TAB_BTN_DOC";
            this.TAB_BTN_DOC.Size = new System.Drawing.Size(126, 33);
            this.TAB_BTN_DOC.TabIndex = 9;
            this.TAB_BTN_DOC.Text = "문서";
            this.TAB_BTN_DOC.UseVisualStyleBackColor = true;
            this.TAB_BTN_DOC.Click += new System.EventHandler(this.TAB_BTN_DOC_Click);
            // 
            // TAB_BTN_IMAGE
            // 
            this.TAB_BTN_IMAGE.FlatAppearance.BorderSize = 5;
            this.TAB_BTN_IMAGE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TAB_BTN_IMAGE.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TAB_BTN_IMAGE.Image = global::CapacityManager.Properties.Resources._1_Pictures_icon;
            this.TAB_BTN_IMAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_BTN_IMAGE.Location = new System.Drawing.Point(141, 121);
            this.TAB_BTN_IMAGE.Name = "TAB_BTN_IMAGE";
            this.TAB_BTN_IMAGE.Size = new System.Drawing.Size(118, 33);
            this.TAB_BTN_IMAGE.TabIndex = 8;
            this.TAB_BTN_IMAGE.Text = "이미지";
            this.TAB_BTN_IMAGE.UseVisualStyleBackColor = true;
            this.TAB_BTN_IMAGE.Click += new System.EventHandler(this.TAB_BTN_IMAGE_Click);
            // 
            // TAB_BTN_MOVIE
            // 
            this.TAB_BTN_MOVIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TAB_BTN_MOVIE.BackgroundImage")));
            this.TAB_BTN_MOVIE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TAB_BTN_MOVIE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TAB_BTN_MOVIE.FlatAppearance.BorderSize = 2;
            this.TAB_BTN_MOVIE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TAB_BTN_MOVIE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TAB_BTN_MOVIE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TAB_BTN_MOVIE.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TAB_BTN_MOVIE.Image = global::CapacityManager.Properties.Resources.Folders_Videos_icon;
            this.TAB_BTN_MOVIE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAB_BTN_MOVIE.Location = new System.Drawing.Point(13, 121);
            this.TAB_BTN_MOVIE.Name = "TAB_BTN_MOVIE";
            this.TAB_BTN_MOVIE.Size = new System.Drawing.Size(129, 33);
            this.TAB_BTN_MOVIE.TabIndex = 7;
            this.TAB_BTN_MOVIE.Text = "동영상";
            this.TAB_BTN_MOVIE.UseVisualStyleBackColor = true;
            this.TAB_BTN_MOVIE.Click += new System.EventHandler(this.TAB_BTN_MOVIE_Click);
            this.TAB_BTN_MOVIE.Enter += new System.EventHandler(this.TAB_BTN_MOVIE_Pocused);
           // this.TAB_BTN_MOVIE.Leave += new System.EventHandler(this.TAB_BTN_MOVIE_LEAVE_Pocused);
            //this.TAB_BTN_MOVIE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TAB_BTN_MOVIE_MOUSEOVER);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapacityManager.Properties.Resources.sun79;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 87);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            //this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // ListV_Doc
            // 
            this.ListV_Doc.CheckBoxes = true;
            this.ListV_Doc.FullRowSelect = true;
            this.ListV_Doc.GridLines = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup2";
            listViewGroup4.Tag = "d";
            this.ListV_Doc.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.ListV_Doc.Location = new System.Drawing.Point(13, 153);
            this.ListV_Doc.Name = "ListV_Doc";
            this.ListV_Doc.Size = new System.Drawing.Size(798, 412);
            this.ListV_Doc.TabIndex = 12;
            this.ListV_Doc.UseCompatibleStateImageBehavior = false;
            this.ListV_Doc.View = System.Windows.Forms.View.Details;
            this.ListV_Doc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDoubleClick);
            // 
            // ListV_Image
            // 
            this.ListV_Image.CheckBoxes = true;
            this.ListV_Image.FullRowSelect = true;
            this.ListV_Image.GridLines = true;
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup1";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup2";
            listViewGroup6.Tag = "d";
            this.ListV_Image.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.ListV_Image.Location = new System.Drawing.Point(13, 153);
            this.ListV_Image.Name = "ListV_Image";
            this.ListV_Image.Size = new System.Drawing.Size(798, 412);
            this.ListV_Image.TabIndex = 13;
            this.ListV_Image.UseCompatibleStateImageBehavior = false;
            this.ListV_Image.View = System.Windows.Forms.View.Details;
            this.ListV_Image.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDoubleClick);
            // 
            // ListV_Etc
            // 
            this.ListV_Etc.CheckBoxes = true;
            this.ListV_Etc.FullRowSelect = true;
            this.ListV_Etc.GridLines = true;
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "listViewGroup1";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "listViewGroup2";
            listViewGroup8.Tag = "d";
            this.ListV_Etc.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8});
            this.ListV_Etc.Location = new System.Drawing.Point(13, 153);
            this.ListV_Etc.Name = "ListV_Etc";
            this.ListV_Etc.Size = new System.Drawing.Size(798, 412);
            this.ListV_Etc.TabIndex = 14;
            this.ListV_Etc.UseCompatibleStateImageBehavior = false;
            this.ListV_Etc.View = System.Windows.Forms.View.Details;
            this.ListV_Etc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDoubleClick);
            // 
            // SettingButton
            // 
            this.SettingButton.Font = new System.Drawing.Font("Haan YHead L", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingButton.Location = new System.Drawing.Point(745, 114);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(65, 36);
            this.SettingButton.TabIndex = 15;
            this.SettingButton.Text = "환경설정";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.BTN_SETTING_Click);
            // 
            // PerLable
            // 
            this.PerLable.AutoSize = true;
            this.PerLable.Location = new System.Drawing.Point(673, 63);
            this.PerLable.Name = "PerLable";
            this.PerLable.Size = new System.Drawing.Size(23, 12);
            this.PerLable.TabIndex = 16;
            this.PerLable.Text = "0/0";
            // 
            // CapacityManager
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(822, 612);
            this.Controls.Add(this.PerLable);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.ListV_Etc);
            this.Controls.Add(this.ListV_Image);
            this.Controls.Add(this.ListV_Doc);
            this.Controls.Add(this.TAB_BTN_FILES);
            this.Controls.Add(this.TAB_BTN_DOC);
            this.Controls.Add(this.TAB_BTN_IMAGE);
            this.Controls.Add(this.TAB_BTN_MOVIE);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FolderLable);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListV_Movie);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = global::CapacityManager.Properties.Resources.sunIcon;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CapacityManager";
            this.Text = "CapacityManager v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowsClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ListView ListV_Movie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label FolderLable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button TAB_BTN_MOVIE;
        private System.Windows.Forms.Button TAB_BTN_IMAGE;
        private System.Windows.Forms.Button TAB_BTN_DOC;
        private System.Windows.Forms.Button TAB_BTN_FILES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ListView ListV_Doc;
        private System.Windows.Forms.ListView ListV_Image;
        private System.Windows.Forms.ListView ListV_Etc;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PerLable;

    }
}

