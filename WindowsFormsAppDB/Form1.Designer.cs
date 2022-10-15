namespace WindowsFormsAppDB
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.Time = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BF = new System.Windows.Forms.PictureBox();
            this.BB = new System.Windows.Forms.PictureBox();
            this.BR = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.X좌표 = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EMR = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.Now = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_insert);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 218);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(577, 12);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(15, 15);
            this.Time.TabIndex = 6;
            this.Time.Text = "-";
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(12, 84);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(234, 66);
            this.btn_play.TabIndex = 7;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "BumperFront";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "BumperBack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "BumperRight";
            // 
            // BF
            // 
            this.BF.BackColor = System.Drawing.Color.Black;
            this.BF.Location = new System.Drawing.Point(420, 108);
            this.BF.Name = "BF";
            this.BF.Size = new System.Drawing.Size(56, 56);
            this.BF.TabIndex = 11;
            this.BF.TabStop = false;
            // 
            // BB
            // 
            this.BB.BackColor = System.Drawing.Color.Black;
            this.BB.Location = new System.Drawing.Point(541, 108);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(57, 56);
            this.BB.TabIndex = 12;
            this.BB.TabStop = false;
            // 
            // BR
            // 
            this.BR.BackColor = System.Drawing.Color.Black;
            this.BR.Location = new System.Drawing.Point(663, 108);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(55, 56);
            this.BR.TabIndex = 13;
            this.BR.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "S좌표";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y좌표";
            // 
            // X좌표
            // 
            this.X좌표.AutoSize = true;
            this.X좌표.Location = new System.Drawing.Point(444, 61);
            this.X좌표.Name = "X좌표";
            this.X좌표.Size = new System.Drawing.Size(46, 15);
            this.X좌표.TabIndex = 17;
            this.X좌표.Text = "X좌표";
            // 
            // BL
            // 
            this.BL.BackColor = System.Drawing.Color.Black;
            this.BL.Location = new System.Drawing.Point(780, 108);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(58, 56);
            this.BL.TabIndex = 20;
            this.BL.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "BumperLeft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "EMR :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Stop : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Start :";
            // 
            // EMR
            // 
            this.EMR.AutoSize = true;
            this.EMR.Location = new System.Drawing.Point(777, 183);
            this.EMR.Name = "EMR";
            this.EMR.Size = new System.Drawing.Size(15, 15);
            this.EMR.TabIndex = 28;
            this.EMR.Text = "-";
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(628, 183);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(15, 15);
            this.Stop.TabIndex = 27;
            this.Stop.Text = "-";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(461, 183);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(15, 15);
            this.Start.TabIndex = 26;
            this.Start.Text = "-";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(777, 61);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(15, 15);
            this.S.TabIndex = 31;
            this.S.Text = "-";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(638, 61);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(15, 15);
            this.Y.TabIndex = 30;
            this.Y.Text = "-";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(506, 61);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(15, 15);
            this.X.TabIndex = 29;
            this.X.Text = "-";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 454);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1001, 56);
            this.trackBar1.TabIndex = 32;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(12, 156);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(234, 68);
            this.btn_Stop.TabIndex = 33;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Now
            // 
            this.Now.AutoSize = true;
            this.Now.Location = new System.Drawing.Point(301, 40);
            this.Now.Name = "Now";
            this.Now.Size = new System.Drawing.Size(15, 15);
            this.Now.TabIndex = 34;
            this.Now.Text = "-";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(362, 40);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(15, 15);
            this.Total.TabIndex = 35;
            this.Total.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "변경시간 : ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(281, 108);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(62, 15);
            this.lbTime.TabIndex = 38;
            this.lbTime.Text = "타이머 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "배속";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(304, 156);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(43, 25);
            this.textBox.TabIndex = 41;
            this.textBox.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "총 시간 : ";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(100, 495);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(15, 15);
            this.TotalTime.TabIndex = 43;
            this.TotalTime.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 539);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Now);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.EMR);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.X좌표);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BB);
            this.Controls.Add(this.BF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BF;
        private System.Windows.Forms.PictureBox BB;
        private System.Windows.Forms.PictureBox BR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label X좌표;
        private System.Windows.Forms.PictureBox BL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EMR;
        private System.Windows.Forms.Label Stop;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label Now;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalTime;
    }
}

