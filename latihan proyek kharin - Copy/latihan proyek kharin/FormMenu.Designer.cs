namespace latihan_proyek_kharin
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            buttonmulai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(130, 37);
            label1.Name = "label1";
            label1.Size = new Size(524, 61);
            label1.TabIndex = 0;
            label1.Text = "APLIKASI HITUNG GAJI";
            label1.Click += label1_Click;
            // 
            // buttonmulai
            // 
            buttonmulai.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonmulai.ForeColor = SystemColors.ActiveCaption;
            buttonmulai.Location = new Point(234, 168);
            buttonmulai.Name = "buttonmulai";
            buttonmulai.Size = new Size(296, 87);
            buttonmulai.TabIndex = 1;
            buttonmulai.Text = "MULAI";
            buttonmulai.UseVisualStyleBackColor = true;
            buttonmulai.Click += buttonmulai_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 490);
            Controls.Add(buttonmulai);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonmulai;
    }
}