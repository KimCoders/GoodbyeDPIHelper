namespace GoodbyeDPIHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OSRB1 = new System.Windows.Forms.RadioButton();
            this.OSRB2 = new System.Windows.Forms.RadioButton();
            this.DPISetRB1 = new System.Windows.Forms.RadioButton();
            this.DPISetRB2 = new System.Windows.Forms.RadioButton();
            this.DPISetRB3 = new System.Windows.Forms.RadioButton();
            this.DPISetRB4 = new System.Windows.Forms.RadioButton();
            this.DPISetRB5 = new System.Windows.Forms.RadioButton();
            this.DPISetRB6 = new System.Windows.Forms.RadioButton();
            this.DPISetRB7 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(222, 331);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(214, 291);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "실행";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.DPISetRB7);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.DPISetRB6);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.DPISetRB5);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(214, 291);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "설정";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OSRB2);
            this.groupBox1.Controls.Add(this.OSRB1);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "운영체제 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DPISetRB4);
            this.groupBox2.Controls.Add(this.DPISetRB3);
            this.groupBox2.Controls.Add(this.DPISetRB2);
            this.groupBox2.Controls.Add(this.DPISetRB1);
            this.groupBox2.Location = new System.Drawing.Point(3, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DPI 설정";
            // 
            // OSRB1
            // 
            this.OSRB1.AutoSize = true;
            this.OSRB1.Location = new System.Drawing.Point(19, 30);
            this.OSRB1.Name = "OSRB1";
            this.OSRB1.Size = new System.Drawing.Size(48, 16);
            this.OSRB1.TabIndex = 0;
            this.OSRB1.Text = "32bit";
            this.OSRB1.UseVisualStyleBackColor = true;
            // 
            // OSRB2
            // 
            this.OSRB2.AutoSize = true;
            this.OSRB2.Checked = true;
            this.OSRB2.Location = new System.Drawing.Point(19, 52);
            this.OSRB2.Name = "OSRB2";
            this.OSRB2.Size = new System.Drawing.Size(48, 16);
            this.OSRB2.TabIndex = 1;
            this.OSRB2.TabStop = true;
            this.OSRB2.Text = "64bit";
            this.OSRB2.UseVisualStyleBackColor = true;
            // 
            // DPISetRB1
            // 
            this.DPISetRB1.AutoSize = true;
            this.DPISetRB1.Location = new System.Drawing.Point(16, 29);
            this.DPISetRB1.Name = "DPISetRB1";
            this.DPISetRB1.Size = new System.Drawing.Size(35, 16);
            this.DPISetRB1.TabIndex = 1;
            this.DPISetRB1.Text = "-1";
            this.DPISetRB1.UseVisualStyleBackColor = true;
            // 
            // DPISetRB2
            // 
            this.DPISetRB2.AutoSize = true;
            this.DPISetRB2.Location = new System.Drawing.Point(16, 51);
            this.DPISetRB2.Name = "DPISetRB2";
            this.DPISetRB2.Size = new System.Drawing.Size(35, 16);
            this.DPISetRB2.TabIndex = 2;
            this.DPISetRB2.Text = "-2";
            this.DPISetRB2.UseVisualStyleBackColor = true;
            // 
            // DPISetRB3
            // 
            this.DPISetRB3.AutoSize = true;
            this.DPISetRB3.Checked = true;
            this.DPISetRB3.Location = new System.Drawing.Point(16, 73);
            this.DPISetRB3.Name = "DPISetRB3";
            this.DPISetRB3.Size = new System.Drawing.Size(35, 16);
            this.DPISetRB3.TabIndex = 3;
            this.DPISetRB3.TabStop = true;
            this.DPISetRB3.Text = "-3";
            this.DPISetRB3.UseVisualStyleBackColor = true;
            // 
            // DPISetRB4
            // 
            this.DPISetRB4.AutoSize = true;
            this.DPISetRB4.Location = new System.Drawing.Point(16, 95);
            this.DPISetRB4.Name = "DPISetRB4";
            this.DPISetRB4.Size = new System.Drawing.Size(35, 16);
            this.DPISetRB4.TabIndex = 4;
            this.DPISetRB4.Text = "-4";
            this.DPISetRB4.UseVisualStyleBackColor = true;
            // 
            // DPISetRB5
            // 
            this.DPISetRB5.AutoSize = true;
            this.DPISetRB5.Location = new System.Drawing.Point(135, 139);
            this.DPISetRB5.Name = "DPISetRB5";
            this.DPISetRB5.Size = new System.Drawing.Size(100, 16);
            this.DPISetRB5.TabIndex = 5;
            this.DPISetRB5.Text = "Active DPI - 4";
            this.DPISetRB5.UseVisualStyleBackColor = true;
            this.DPISetRB5.Visible = false;
            // 
            // DPISetRB6
            // 
            this.DPISetRB6.AutoSize = true;
            this.DPISetRB6.Location = new System.Drawing.Point(135, 161);
            this.DPISetRB6.Name = "DPISetRB6";
            this.DPISetRB6.Size = new System.Drawing.Size(100, 16);
            this.DPISetRB6.TabIndex = 6;
            this.DPISetRB6.Text = "Active DPI - 5";
            this.DPISetRB6.UseVisualStyleBackColor = true;
            this.DPISetRB6.Visible = false;
            // 
            // DPISetRB7
            // 
            this.DPISetRB7.AutoSize = true;
            this.DPISetRB7.Location = new System.Drawing.Point(135, 183);
            this.DPISetRB7.Name = "DPISetRB7";
            this.DPISetRB7.Size = new System.Drawing.Size(100, 16);
            this.DPISetRB7.TabIndex = 7;
            this.DPISetRB7.Text = "Active DPI - 6";
            this.DPISetRB7.UseVisualStyleBackColor = true;
            this.DPISetRB7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "중지";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 411);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GoodbyeDPI Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DPISetRB7;
        private System.Windows.Forms.RadioButton DPISetRB6;
        private System.Windows.Forms.RadioButton DPISetRB5;
        private System.Windows.Forms.RadioButton DPISetRB4;
        private System.Windows.Forms.RadioButton DPISetRB3;
        private System.Windows.Forms.RadioButton DPISetRB2;
        private System.Windows.Forms.RadioButton DPISetRB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OSRB2;
        private System.Windows.Forms.RadioButton OSRB1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

