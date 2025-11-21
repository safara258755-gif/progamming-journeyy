namespace latihan_proyek_kharin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            textBox9 = new TextBox();
            label9 = new Label();
            btnkeluar = new Button();
            btnhitung = new Button();
            button1 = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            textBoxId = new TextBox();
            textBoxNama = new TextBox();
            label13 = new Label();
            label14 = new Label();
            buttonsimpan = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 251);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "pemasukan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(206, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 3;
            label4.Text = "Total Pendapatan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 2;
            label3.Text = "Tunjangan Makan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "tunjangan transport";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Gaji Pokok";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(414, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 251);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "potongan";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(192, 134);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 133);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 10;
            label8.Text = "kasbon";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(192, 37);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(192, 188);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 9;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 88);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 4;
            label7.Text = "asuransi";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 194);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 3;
            label6.Text = "total potongan";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 37);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 2;
            label5.Text = "alfa";
            label5.Click += label5_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 459);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 75);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Info;
            textBox9.Location = new Point(163, 26);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(187, 31);
            textBox9.TabIndex = 10;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 10;
            label9.Text = "total gaji diterima";
            label9.Click += label9_Click;
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(420, 497);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(112, 34);
            btnkeluar.TabIndex = 12;
            btnkeluar.Text = "clear";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // btnhitung
            // 
            btnhitung.Location = new Point(420, 458);
            btnhitung.Name = "btnhitung";
            btnhitung.Size = new Size(112, 34);
            btnhitung.TabIndex = 11;
            btnhitung.Text = "&hitung";
            btnhitung.UseVisualStyleBackColor = true;
            btnhitung.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(579, 458);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "keluar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(175, 9);
            label10.Name = "label10";
            label10.Size = new Size(430, 58);
            label10.TabIndex = 12;
            label10.Text = "PENGHITUNG GAJI";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientInactiveCaption;
            groupBox4.Controls.Add(textBoxId);
            groupBox4.Controls.Add(textBoxNama);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(8, 70);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(772, 87);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(579, 41);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(150, 31);
            textBoxId.TabIndex = 1;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(74, 37);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(435, 31);
            textBoxNama.TabIndex = 0;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(541, 43);
            label13.Name = "label13";
            label13.Size = new Size(27, 25);
            label13.TabIndex = 1;
            label13.Text = "id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 43);
            label14.Name = "label14";
            label14.Size = new Size(56, 25);
            label14.TabIndex = 0;
            label14.Text = "nama";
            // 
            // buttonsimpan
            // 
            buttonsimpan.Location = new Point(579, 498);
            buttonsimpan.Name = "buttonsimpan";
            buttonsimpan.Size = new Size(112, 34);
            buttonsimpan.TabIndex = 14;
            buttonsimpan.Text = "simpan";
            buttonsimpan.UseVisualStyleBackColor = true;
            buttonsimpan.Click += buttonsimpan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 569);
            Controls.Add(buttonsimpan);
            Controls.Add(groupBox4);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(btnkeluar);
            Controls.Add(btnhitung);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "   ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox textBox5;
        private GroupBox groupBox3;
        private Label label9;
        private Button btnkeluar;
        private Button btnhitung;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
        private Label label10;
        private GroupBox groupBox4;
        private TextBox textBoxId;
        private TextBox textBoxNama;
        private Label label13;
        private Label label14;
        private Button buttonsimpan;
    }
}
