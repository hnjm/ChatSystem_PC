﻿namespace QQ_piracy.MusicForms
{
    partial class MusicMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicMainForm));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tackBarMove = new System.Windows.Forms.TrackBar();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.panelPlayControl = new System.Windows.Forms.Panel();
            this.pbHiFi = new System.Windows.Forms.PictureBox();
            this.pbMusicStyle = new System.Windows.Forms.PictureBox();
            this.pbListCount = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pbLyric = new System.Windows.Forms.PictureBox();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.btnPlayMode = new System.Windows.Forms.Button();
            this.labelMusicTimer = new System.Windows.Forms.Label();
            this.labelMusicDetail = new System.Windows.Forms.Label();
            this.pbSmallAlbum = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbMusicVolume = new System.Windows.Forms.TrackBar();
            this.panelMusicVlume = new System.Windows.Forms.Panel();
            this.labelListCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackBarMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.panelPlayControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHiFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLyric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).BeginInit();
            this.panelMusicVlume.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(722, 250);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(223, 189);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // tackBarMove
            // 
            this.tackBarMove.AutoSize = false;
            this.tackBarMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tackBarMove.Location = new System.Drawing.Point(258, 41);
            this.tackBarMove.Maximum = 100;
            this.tackBarMove.Name = "tackBarMove";
            this.tackBarMove.Size = new System.Drawing.Size(356, 15);
            this.tackBarMove.TabIndex = 2;
            this.tackBarMove.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pbNext
            // 
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNext.Image = global::QQ_piracy.Properties.Resources.下一首;
            this.pbNext.Location = new System.Drawing.Point(133, 18);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(35, 35);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 17;
            this.pbNext.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNext, "下一首");
            this.pbNext.MouseLeave += new System.EventHandler(this.pbNext_MouseLeave);
            this.pbNext.MouseHover += new System.EventHandler(this.pbNext_MouseHover);
            // 
            // pbBack
            // 
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBack.Image = global::QQ_piracy.Properties.Resources.上一首;
            this.pbBack.Location = new System.Drawing.Point(18, 18);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(35, 35);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 16;
            this.pbBack.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBack, "上一首");
            this.pbBack.MouseLeave += new System.EventHandler(this.pbBack_MouseLeave);
            this.pbBack.MouseHover += new System.EventHandler(this.pbBack_MouseHover);
            // 
            // pbPlay
            // 
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPlay.Image = global::QQ_piracy.Properties.Resources.播放;
            this.pbPlay.Location = new System.Drawing.Point(67, 9);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(50, 50);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 15;
            this.pbPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPlay, "播放/暂停");
            this.pbPlay.MouseLeave += new System.EventHandler(this.pbPlay_MouseLeave);
            this.pbPlay.MouseHover += new System.EventHandler(this.pbPlay_MouseHover);
            // 
            // panelPlayControl
            // 
            this.panelPlayControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelPlayControl.Controls.Add(this.labelListCount);
            this.panelPlayControl.Controls.Add(this.pbHiFi);
            this.panelPlayControl.Controls.Add(this.pbMusicStyle);
            this.panelPlayControl.Controls.Add(this.pbListCount);
            this.panelPlayControl.Controls.Add(this.pbLike);
            this.panelPlayControl.Controls.Add(this.pbLyric);
            this.panelPlayControl.Controls.Add(this.pbVolume);
            this.panelPlayControl.Controls.Add(this.tackBarMove);
            this.panelPlayControl.Controls.Add(this.btnPlayMode);
            this.panelPlayControl.Controls.Add(this.labelMusicTimer);
            this.panelPlayControl.Controls.Add(this.labelMusicDetail);
            this.panelPlayControl.Controls.Add(this.pbSmallAlbum);
            this.panelPlayControl.Controls.Add(this.pbNext);
            this.panelPlayControl.Controls.Add(this.pbBack);
            this.panelPlayControl.Controls.Add(this.pbPlay);
            this.panelPlayControl.Location = new System.Drawing.Point(0, 523);
            this.panelPlayControl.Name = "panelPlayControl";
            this.panelPlayControl.Size = new System.Drawing.Size(990, 70);
            this.panelPlayControl.TabIndex = 18;
            // 
            // pbHiFi
            // 
            this.pbHiFi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHiFi.Image = global::QQ_piracy.Properties.Resources.HiFi;
            this.pbHiFi.Location = new System.Drawing.Point(777, 12);
            this.pbHiFi.Name = "pbHiFi";
            this.pbHiFi.Size = new System.Drawing.Size(48, 48);
            this.pbHiFi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHiFi.TabIndex = 19;
            this.pbHiFi.TabStop = false;
            this.toolTip1.SetToolTip(this.pbHiFi, "开启HiFi独占模式（功能暂未开启）");
            this.pbHiFi.MouseLeave += new System.EventHandler(this.pbHiFi_MouseLeave);
            this.pbHiFi.MouseHover += new System.EventHandler(this.pbHiFi_MouseHover);
            // 
            // pbMusicStyle
            // 
            this.pbMusicStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMusicStyle.Image = global::QQ_piracy.Properties.Resources.音效;
            this.pbMusicStyle.Location = new System.Drawing.Point(713, 12);
            this.pbMusicStyle.Name = "pbMusicStyle";
            this.pbMusicStyle.Size = new System.Drawing.Size(48, 48);
            this.pbMusicStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMusicStyle.TabIndex = 19;
            this.pbMusicStyle.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMusicStyle, "点击开启音效（功能暂未开启）");
            this.pbMusicStyle.MouseLeave += new System.EventHandler(this.pbMusicStyle_MouseLeave);
            this.pbMusicStyle.MouseHover += new System.EventHandler(this.pbMusicStyle_MouseHover);
            // 
            // pbListCount
            // 
            this.pbListCount.Image = global::QQ_piracy.Properties.Resources.列表;
            this.pbListCount.Location = new System.Drawing.Point(926, 24);
            this.pbListCount.Name = "pbListCount";
            this.pbListCount.Size = new System.Drawing.Size(25, 25);
            this.pbListCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListCount.TabIndex = 19;
            this.pbListCount.TabStop = false;
            this.toolTip1.SetToolTip(this.pbListCount, "播放列表");
            this.pbListCount.MouseLeave += new System.EventHandler(this.pbListCount_MouseLeave);
            this.pbListCount.MouseHover += new System.EventHandler(this.pbListCount_MouseHover);
            // 
            // pbLike
            // 
            this.pbLike.Image = global::QQ_piracy.Properties.Resources.收藏;
            this.pbLike.Location = new System.Drawing.Point(883, 24);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(22, 22);
            this.pbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLike.TabIndex = 19;
            this.pbLike.TabStop = false;
            this.toolTip1.SetToolTip(this.pbLike, "收藏");
            this.pbLike.MouseLeave += new System.EventHandler(this.pbLike_MouseLeave);
            this.pbLike.MouseHover += new System.EventHandler(this.pbLike_MouseHover);
            // 
            // pbLyric
            // 
            this.pbLyric.Image = global::QQ_piracy.Properties.Resources.词;
            this.pbLyric.Location = new System.Drawing.Point(841, 21);
            this.pbLyric.Name = "pbLyric";
            this.pbLyric.Size = new System.Drawing.Size(30, 30);
            this.pbLyric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLyric.TabIndex = 19;
            this.pbLyric.TabStop = false;
            this.toolTip1.SetToolTip(this.pbLyric, "显示桌面歌词");
            this.pbLyric.MouseLeave += new System.EventHandler(this.pbLyric_MouseLeave);
            this.pbLyric.MouseHover += new System.EventHandler(this.pbLyric_MouseHover);
            // 
            // pbVolume
            // 
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(653, 25);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(25, 25);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolume.TabIndex = 19;
            this.pbVolume.TabStop = false;
            this.pbVolume.MouseLeave += new System.EventHandler(this.pbVolume_MouseLeave);
            this.pbVolume.MouseHover += new System.EventHandler(this.pbVolume_MouseHover);
            // 
            // btnPlayMode
            // 
            this.btnPlayMode.BackgroundImage = global::QQ_piracy.Properties.Resources.随机播放;
            this.btnPlayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayMode.FlatAppearance.BorderSize = 0;
            this.btnPlayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMode.Location = new System.Drawing.Point(621, 25);
            this.btnPlayMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayMode.Name = "btnPlayMode";
            this.btnPlayMode.Size = new System.Drawing.Size(25, 25);
            this.btnPlayMode.TabIndex = 19;
            this.btnPlayMode.UseVisualStyleBackColor = true;
            // 
            // labelMusicTimer
            // 
            this.labelMusicTimer.AutoSize = true;
            this.labelMusicTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelMusicTimer.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMusicTimer.ForeColor = System.Drawing.Color.White;
            this.labelMusicTimer.Location = new System.Drawing.Point(510, 18);
            this.labelMusicTimer.Name = "labelMusicTimer";
            this.labelMusicTimer.Size = new System.Drawing.Size(98, 13);
            this.labelMusicTimer.TabIndex = 21;
            this.labelMusicTimer.Text = "00:00 / 03:50";
            // 
            // labelMusicDetail
            // 
            this.labelMusicDetail.AutoSize = true;
            this.labelMusicDetail.BackColor = System.Drawing.Color.Transparent;
            this.labelMusicDetail.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMusicDetail.ForeColor = System.Drawing.Color.White;
            this.labelMusicDetail.Location = new System.Drawing.Point(255, 18);
            this.labelMusicDetail.Name = "labelMusicDetail";
            this.labelMusicDetail.Size = new System.Drawing.Size(98, 13);
            this.labelMusicDetail.TabIndex = 20;
            this.labelMusicDetail.Text = "音乐名 - 歌手";
            this.toolTip1.SetToolTip(this.labelMusicDetail, "音乐名 - 歌手");
            // 
            // pbSmallAlbum
            // 
            this.pbSmallAlbum.BackgroundImage = global::QQ_piracy.Properties.Resources.defaultSmallAblum;
            this.pbSmallAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSmallAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbSmallAlbum.Location = new System.Drawing.Point(185, 3);
            this.pbSmallAlbum.Name = "pbSmallAlbum";
            this.pbSmallAlbum.Size = new System.Drawing.Size(64, 64);
            this.pbSmallAlbum.TabIndex = 19;
            this.pbSmallAlbum.TabStop = false;
            this.toolTip1.SetToolTip(this.pbSmallAlbum, "打开音乐详情页");
            // 
            // tbMusicVolume
            // 
            this.tbMusicVolume.AutoSize = false;
            this.tbMusicVolume.Location = new System.Drawing.Point(6, 11);
            this.tbMusicVolume.Name = "tbMusicVolume";
            this.tbMusicVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbMusicVolume.Size = new System.Drawing.Size(15, 111);
            this.tbMusicVolume.TabIndex = 19;
            this.tbMusicVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panelMusicVlume
            // 
            this.panelMusicVlume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMusicVlume.Controls.Add(this.tbMusicVolume);
            this.panelMusicVlume.Location = new System.Drawing.Point(653, 405);
            this.panelMusicVlume.Name = "panelMusicVlume";
            this.panelMusicVlume.Size = new System.Drawing.Size(25, 140);
            this.panelMusicVlume.TabIndex = 20;
            this.panelMusicVlume.Visible = false;
            this.panelMusicVlume.MouseLeave += new System.EventHandler(this.panelMusicVlume_MouseLeave);
            // 
            // labelListCount
            // 
            this.labelListCount.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelListCount.ForeColor = System.Drawing.Color.Silver;
            this.labelListCount.Location = new System.Drawing.Point(946, 30);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(41, 25);
            this.labelListCount.TabIndex = 22;
            this.labelListCount.Text = "111";
            this.toolTip1.SetToolTip(this.labelListCount, "播放列表");
            this.labelListCount.MouseLeave += new System.EventHandler(this.pbListCount_MouseLeave);
            this.labelListCount.MouseHover += new System.EventHandler(this.pbListCount_MouseHover);
            // 
            // MusicMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(989, 597);
            this.Controls.Add(this.panelMusicVlume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panelPlayControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐播放器";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackBarMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.panelPlayControl.ResumeLayout(false);
            this.panelPlayControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHiFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLyric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).EndInit();
            this.panelMusicVlume.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar tackBarMove;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.Panel panelPlayControl;
        private System.Windows.Forms.Label labelMusicTimer;
        private System.Windows.Forms.Label labelMusicDetail;
        private System.Windows.Forms.PictureBox pbSmallAlbum;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.Button btnPlayMode;
        private System.Windows.Forms.TrackBar tbMusicVolume;
        private System.Windows.Forms.Panel panelMusicVlume;
        private System.Windows.Forms.PictureBox pbMusicStyle;
        private System.Windows.Forms.PictureBox pbHiFi;
        private System.Windows.Forms.PictureBox pbListCount;
        private System.Windows.Forms.PictureBox pbLike;
        private System.Windows.Forms.PictureBox pbLyric;
        private System.Windows.Forms.Label labelListCount;
    }
}