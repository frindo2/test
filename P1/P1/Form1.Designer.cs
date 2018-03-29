namespace P1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.angka2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.angka1TextBox = new System.Windows.Forms.TextBox();
            this.hasilLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nilaiAngkaTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.hasil2Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Contoh MessagBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 514);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hasilLabel);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.angka2TextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.angka1TextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(473, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 43);
            this.button5.TabIndex = 10;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Angka 2";
            // 
            // angka2TextBox
            // 
            this.angka2TextBox.Location = new System.Drawing.Point(448, 176);
            this.angka2TextBox.Name = "angka2TextBox";
            this.angka2TextBox.Size = new System.Drawing.Size(100, 26);
            this.angka2TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Angka 1";
            // 
            // angka1TextBox
            // 
            this.angka1TextBox.Location = new System.Drawing.Point(448, 140);
            this.angka1TextBox.Name = "angka1TextBox";
            this.angka1TextBox.Size = new System.Drawing.Size(100, 26);
            this.angka1TextBox.TabIndex = 5;
            // 
            // hasilLabel
            // 
            this.hasilLabel.AutoSize = true;
            this.hasilLabel.Location = new System.Drawing.Point(419, 349);
            this.hasilLabel.Name = "hasilLabel";
            this.hasilLabel.Size = new System.Drawing.Size(52, 20);
            this.hasilLabel.TabIndex = 12;
            this.hasilLabel.Text = "[Hasil]";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hasil2Label);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.nilaiAngkaTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nilai Angka";
            // 
            // nilaiAngkaTextBox
            // 
            this.nilaiAngkaTextBox.Location = new System.Drawing.Point(457, 140);
            this.nilaiAngkaTextBox.Name = "nilaiAngkaTextBox";
            this.nilaiAngkaTextBox.Size = new System.Drawing.Size(100, 26);
            this.nilaiAngkaTextBox.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(363, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 43);
            this.button6.TabIndex = 10;
            this.button6.Text = "Ubah Nilai Huruf";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hasil2Label
            // 
            this.hasil2Label.AutoSize = true;
            this.hasil2Label.Location = new System.Drawing.Point(436, 256);
            this.hasil2Label.Name = "hasil2Label";
            this.hasil2Label.Size = new System.Drawing.Size(52, 20);
            this.hasil2Label.TabIndex = 13;
            this.hasil2Label.Text = "[Hasil]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label hasilLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angka2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angka1TextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nilaiAngkaTextBox;
        private System.Windows.Forms.Label hasil2Label;
    }
}

