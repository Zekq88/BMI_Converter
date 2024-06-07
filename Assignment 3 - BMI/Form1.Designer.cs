namespace Assignment_3___BMI
{
    partial class Form1
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
            this.EUunitbtn = new System.Windows.Forms.RadioButton();
            this.USunitBtn = new System.Windows.Forms.RadioButton();
            this.calcBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.resultTxt2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultTxt1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EUunitbtn
            // 
            this.EUunitbtn.AutoSize = true;
            this.EUunitbtn.Checked = true;
            this.EUunitbtn.Location = new System.Drawing.Point(25, 32);
            this.EUunitbtn.Name = "EUunitbtn";
            this.EUunitbtn.Size = new System.Drawing.Size(137, 20);
            this.EUunitbtn.TabIndex = 4;
            this.EUunitbtn.TabStop = true;
            this.EUunitbtn.Text = "Metric Unit (kg cm)";
            this.EUunitbtn.UseVisualStyleBackColor = true;
            this.EUunitbtn.CheckedChanged += new System.EventHandler(this.EUunitbtn_CheckedChanged);
            // 
            // USunitBtn
            // 
            this.USunitBtn.AutoSize = true;
            this.USunitBtn.Location = new System.Drawing.Point(25, 63);
            this.USunitBtn.Name = "USunitBtn";
            this.USunitBtn.Size = new System.Drawing.Size(130, 20);
            this.USunitBtn.TabIndex = 5;
            this.USunitBtn.TabStop = true;
            this.USunitBtn.Text = "US Unit (foot, lbs)";
            this.USunitBtn.UseVisualStyleBackColor = true;
            this.USunitBtn.CheckedChanged += new System.EventHandler(this.USunitBtn_CheckedChanged);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(435, 37);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(130, 47);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EUunitbtn);
            this.groupBox1.Controls.Add(this.USunitBtn);
            this.groupBox1.Location = new System.Drawing.Point(410, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.resultTxt2);
            this.resultBox.Controls.Add(this.label6);
            this.resultBox.Controls.Add(this.resultTxt1);
            this.resultBox.Controls.Add(this.label5);
            this.resultBox.Controls.Add(this.label4);
            this.resultBox.Location = new System.Drawing.Point(12, 242);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(608, 175);
            this.resultBox.TabIndex = 8;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Your Results";
            // 
            // resultTxt2
            // 
            this.resultTxt2.Location = new System.Drawing.Point(355, 89);
            this.resultTxt2.Name = "resultTxt2";
            this.resultTxt2.ReadOnly = true;
            this.resultTxt2.Size = new System.Drawing.Size(205, 22);
            this.resultTxt2.TabIndex = 16;
            this.resultTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Normal BMI is between 18.50 and 24.9";
            // 
            // resultTxt1
            // 
            this.resultTxt1.Location = new System.Drawing.Point(460, 42);
            this.resultTxt1.Name = "resultTxt1";
            this.resultTxt1.ReadOnly = true;
            this.resultTxt1.Size = new System.Drawing.Size(100, 22);
            this.resultTxt1.TabIndex = 15;
            this.resultTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your BMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Height (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Weight (kg)\r\n";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(137, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(236, 22);
            this.txt1.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(273, 84);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 13;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(273, 128);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 22);
            this.txt3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(134, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "e.g. 183cm = 183";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(140, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "e.g. 100kg = 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator <By: Robin Kadergran>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton EUunitbtn;
        private System.Windows.Forms.RadioButton USunitBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTxt2;
        private System.Windows.Forms.TextBox resultTxt1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

