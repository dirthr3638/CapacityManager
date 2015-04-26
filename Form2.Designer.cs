namespace CapacityManager
{
    partial class SettingForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TargetFolder = new System.Windows.Forms.TextBox();
            this.LastDayTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MovieView = new System.Windows.Forms.ListView();
            this.ImageView = new System.Windows.Forms.ListView();
            this.DocView = new System.Windows.Forms.ListView();
            this.EtcView = new System.Windows.Forms.ListView();
            this.SystemView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 100);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(205, 319);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "추가";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "삭제";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(567, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "추가";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(567, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "삭제";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(567, 259);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 30);
            this.button8.TabIndex = 11;
            this.button8.Text = "추가";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(720, 369);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 50);
            this.button9.TabIndex = 14;
            this.button9.Text = "확인";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(634, 369);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 50);
            this.button10.TabIndex = 15;
            this.button10.Text = "기본값";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blippo Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HYnamM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(152, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "사용자가 폴더, 파일종류를 선택하여 검색합니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "검색폴더 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(221, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Movie 확장자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(223, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Image 확장자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(426, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Doc 확장자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(426, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "기타 확장자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(631, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "검사예외폴더";
            // 
            // TargetFolder
            // 
            this.TargetFolder.Location = new System.Drawing.Point(12, 73);
            this.TargetFolder.Name = "TargetFolder";
            this.TargetFolder.Size = new System.Drawing.Size(205, 21);
            this.TargetFolder.TabIndex = 24;
            // 
            // LastDayTextbox
            // 
            this.LastDayTextbox.Location = new System.Drawing.Point(634, 332);
            this.LastDayTextbox.MaxLength = 5000;
            this.LastDayTextbox.Name = "LastDayTextbox";
            this.LastDayTextbox.Size = new System.Drawing.Size(93, 21);
            this.LastDayTextbox.TabIndex = 25;
            this.LastDayTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastDayTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(632, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "최종 사용일자";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(733, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "일전";
            // 
            // MovieView
            // 
            this.MovieView.Location = new System.Drawing.Point(226, 73);
            this.MovieView.Name = "MovieView";
            this.MovieView.Size = new System.Drawing.Size(130, 158);
            this.MovieView.TabIndex = 28;
            this.MovieView.UseCompatibleStateImageBehavior = false;
            this.MovieView.View = System.Windows.Forms.View.Details;
            // 
            // ImageView
            // 
            this.ImageView.Location = new System.Drawing.Point(226, 261);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(130, 158);
            this.ImageView.TabIndex = 29;
            this.ImageView.UseCompatibleStateImageBehavior = false;
            this.ImageView.View = System.Windows.Forms.View.Details;
            // 
            // DocView
            // 
            this.DocView.Location = new System.Drawing.Point(429, 73);
            this.DocView.Name = "DocView";
            this.DocView.Size = new System.Drawing.Size(130, 158);
            this.DocView.TabIndex = 30;
            this.DocView.UseCompatibleStateImageBehavior = false;
            this.DocView.View = System.Windows.Forms.View.Details;
            // 
            // EtcView
            // 
            this.EtcView.Location = new System.Drawing.Point(429, 266);
            this.EtcView.Name = "EtcView";
            this.EtcView.Size = new System.Drawing.Size(130, 158);
            this.EtcView.TabIndex = 31;
            this.EtcView.UseCompatibleStateImageBehavior = false;
            this.EtcView.View = System.Windows.Forms.View.Details;
            // 
            // SystemView
            // 
            this.SystemView.CheckBoxes = true;
            this.SystemView.Location = new System.Drawing.Point(634, 73);
            this.SystemView.Name = "SystemView";
            this.SystemView.Size = new System.Drawing.Size(130, 216);
            this.SystemView.TabIndex = 32;
            this.SystemView.UseCompatibleStateImageBehavior = false;
            this.SystemView.View = System.Windows.Forms.View.Details;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 429);
            this.Controls.Add(this.SystemView);
            this.Controls.Add(this.EtcView);
            this.Controls.Add(this.DocView);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.MovieView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LastDayTextbox);
            this.Controls.Add(this.TargetFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.Text = "환경설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TargetFolder;
        private System.Windows.Forms.TextBox LastDayTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView MovieView;
        private System.Windows.Forms.ListView ImageView;
        private System.Windows.Forms.ListView DocView;
        private System.Windows.Forms.ListView EtcView;
        private System.Windows.Forms.ListView SystemView;
    }
}