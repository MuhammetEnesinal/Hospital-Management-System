namespace HastaneYonetimUygulamasi
{
    partial class YönetimSistemi
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DoktorSistemiBtn = new Button();
            HastaSistemiBtn = new Button();
            YoneticiSistemiBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 140);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.loader3;
            pictureBox1.Location = new Point(997, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Yu Gothic", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(260, 33);
            label1.Name = "label1";
            label1.Size = new Size(681, 56);
            label1.TabIndex = 0;
            label1.Text = "Hastane Sistemine Hos Geldiniz";
            // 
            // DoktorSistemiBtn
            // 
            DoktorSistemiBtn.BackColor = SystemColors.ButtonShadow;
            DoktorSistemiBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            DoktorSistemiBtn.Location = new Point(456, 365);
            DoktorSistemiBtn.Margin = new Padding(3, 4, 3, 4);
            DoktorSistemiBtn.Name = "DoktorSistemiBtn";
            DoktorSistemiBtn.Size = new Size(332, 104);
            DoktorSistemiBtn.TabIndex = 1;
            DoktorSistemiBtn.Text = "Doktor Girişi";
            DoktorSistemiBtn.UseVisualStyleBackColor = false;
            DoktorSistemiBtn.Click += DoktorSistemiBtn_Click;
            // 
            // HastaSistemiBtn
            // 
            HastaSistemiBtn.BackColor = SystemColors.ControlDark;
            HastaSistemiBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            HastaSistemiBtn.Location = new Point(834, 365);
            HastaSistemiBtn.Margin = new Padding(3, 4, 3, 4);
            HastaSistemiBtn.Name = "HastaSistemiBtn";
            HastaSistemiBtn.Size = new Size(332, 104);
            HastaSistemiBtn.TabIndex = 2;
            HastaSistemiBtn.Text = "Hasta Girişi";
            HastaSistemiBtn.UseVisualStyleBackColor = false;
            HastaSistemiBtn.Click += HastaSistemiBtn_Click;
            // 
            // YoneticiSistemiBtn
            // 
            YoneticiSistemiBtn.BackColor = SystemColors.AppWorkspace;
            YoneticiSistemiBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            YoneticiSistemiBtn.Location = new Point(48, 365);
            YoneticiSistemiBtn.Margin = new Padding(3, 4, 3, 4);
            YoneticiSistemiBtn.Name = "YoneticiSistemiBtn";
            YoneticiSistemiBtn.Size = new Size(332, 104);
            YoneticiSistemiBtn.TabIndex = 3;
            YoneticiSistemiBtn.Text = "Yönetici Girişi";
            YoneticiSistemiBtn.UseVisualStyleBackColor = false;
            YoneticiSistemiBtn.Click += YoneticiSistemiBtn_Click;
            // 
            // YönetimSistemi
            // 
            AutoScaleDimensions = new SizeF(9F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1203, 647);
            Controls.Add(YoneticiSistemiBtn);
            Controls.Add(HastaSistemiBtn);
            Controls.Add(DoktorSistemiBtn);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YönetimSistemi";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DoktorSistemiBtn;
        private Button HastaSistemiBtn;
        private Label label1;
        private Button YoneticiSistemiBtn;
        private PictureBox pictureBox1;
    }
}
