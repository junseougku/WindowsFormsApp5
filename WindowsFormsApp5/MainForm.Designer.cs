﻿namespace WindowsFormsApp5
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.TestButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.lineEnable = new System.Windows.Forms.Button();
            this.stopImage = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1324, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.Enter += new System.EventHandler(this.saveButton_Enter);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1324, 216);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.TabStop = false;
            this.loadButton.Text = "불러오기";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ground_1.bmp");
            this.imageList.Images.SetKeyName(1, "ground_2.bmp");
            this.imageList.Images.SetKeyName(2, "tree_01.bmp");
            this.imageList.Images.SetKeyName(3, "gress_01.bmp");
            this.imageList.Images.SetKeyName(4, "idle_1.bmp");
            this.imageList.Images.SetKeyName(5, "idle_01.png");
            this.imageList.Images.SetKeyName(6, "walk_down_01.png");
            this.imageList.Images.SetKeyName(7, "walk_down_02.png");
            this.imageList.Images.SetKeyName(8, "idle_up_01.png");
            this.imageList.Images.SetKeyName(9, "walk_up_01.png");
            this.imageList.Images.SetKeyName(10, "walk_up_02.png");
            this.imageList.Images.SetKeyName(11, "idle_left_01.png");
            this.imageList.Images.SetKeyName(12, "walk_left_01.png");
            this.imageList.Images.SetKeyName(13, "walk_left_02.png");
            this.imageList.Images.SetKeyName(14, "idle_right_01.png");
            this.imageList.Images.SetKeyName(15, "walk_right_01.png");
            this.imageList.Images.SetKeyName(16, "walk_right_02.png");
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(1324, 116);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.TabStop = false;
            this.TestButton.Text = "TEST";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            this.TestButton.Enter += new System.EventHandler(this.TestButton_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.gress_01;
            this.pictureBox4.Location = new System.Drawing.Point(1319, 592);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.tree_01;
            this.pictureBox3.ErrorImage = global::WindowsFormsApp5.Properties.Resources.tree_01;
            this.pictureBox3.Location = new System.Drawing.Point(1319, 485);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.ground_2;
            this.pictureBox2.Location = new System.Drawing.Point(1319, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.ground_1;
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.ground_1;
            this.pictureBox1.Location = new System.Drawing.Point(1319, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // MainPicture
            // 
            this.MainPicture.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainPicture.Location = new System.Drawing.Point(12, 12);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(1280, 800);
            this.MainPicture.TabIndex = 2;
            this.MainPicture.TabStop = false;
            this.MainPicture.Tag = "0";
            this.MainPicture.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.MainPicture_LoadCompleted);
            this.MainPicture.Click += new System.EventHandler(this.MainPicture_Click);
            this.MainPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPicture_Paint);
            this.MainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseClick);
            this.MainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseDown);
            this.MainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseMove);
            // 
            // lineEnable
            // 
            this.lineEnable.Location = new System.Drawing.Point(1324, 703);
            this.lineEnable.Name = "lineEnable";
            this.lineEnable.Size = new System.Drawing.Size(75, 23);
            this.lineEnable.TabIndex = 9;
            this.lineEnable.TabStop = false;
            this.lineEnable.Text = "선삭제";
            this.lineEnable.UseVisualStyleBackColor = true;
            this.lineEnable.Click += new System.EventHandler(this.lineEnable_Click);
            // 
            // stopImage
            // 
            this.stopImage.Location = new System.Drawing.Point(1324, 733);
            this.stopImage.Name = "stopImage";
            this.stopImage.Size = new System.Drawing.Size(75, 23);
            this.stopImage.TabIndex = 10;
            this.stopImage.TabStop = false;
            this.stopImage.Text = "그만하기";
            this.stopImage.UseVisualStyleBackColor = true;
            this.stopImage.Click += new System.EventHandler(this.stopImage_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1324, 763);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "타일삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(1387, 12);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(44, 23);
            this.upButton.TabIndex = 23;
            this.upButton.Text = "up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(1324, 60);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(39, 23);
            this.leftButton.TabIndex = 24;
            this.leftButton.Text = "left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(1387, 60);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(44, 23);
            this.downButton.TabIndex = 25;
            this.downButton.Text = "down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(1453, 60);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(40, 23);
            this.rightButton.TabIndex = 26;
            this.rightButton.Text = "right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(1405, 116);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(75, 23);
            this.deleteAll.TabIndex = 27;
            this.deleteAll.TabStop = false;
            this.deleteAll.Text = "전부삭제";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 836);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.stopImage);
            this.Controls.Add(this.lineEnable);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.MainPicture);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainForm";
            this.Tag = "1";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.TestButton_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button lineEnable;
        private System.Windows.Forms.Button stopImage;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button deleteAll;
    }
}

