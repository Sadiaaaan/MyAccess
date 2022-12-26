namespace MyAccess
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunabtnAdministration = new Guna.UI.WinForms.GunaButton();
            this.gunabtnFaculty = new Guna.UI.WinForms.GunaButton();
            this.gunabtnStudent = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(240, 46);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(265, 224);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunabtnAdministration
            // 
            this.gunabtnAdministration.AnimationHoverSpeed = 0.07F;
            this.gunabtnAdministration.AnimationSpeed = 0.03F;
            this.gunabtnAdministration.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnAdministration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunabtnAdministration.BorderColor = System.Drawing.Color.Black;
            this.gunabtnAdministration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnAdministration.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnAdministration.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnAdministration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunabtnAdministration.Image = null;
            this.gunabtnAdministration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnAdministration.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnAdministration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunabtnAdministration.Location = new System.Drawing.Point(178, 332);
            this.gunabtnAdministration.Name = "gunabtnAdministration";
            this.gunabtnAdministration.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnAdministration.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnAdministration.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnAdministration.OnHoverImage = null;
            this.gunabtnAdministration.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnAdministration.Radius = 20;
            this.gunabtnAdministration.Size = new System.Drawing.Size(388, 56);
            this.gunabtnAdministration.TabIndex = 1;
            this.gunabtnAdministration.Text = "Administration";
            this.gunabtnAdministration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnAdministration.Click += new System.EventHandler(this.gunabtnAdministration_Click);
            // 
            // gunabtnFaculty
            // 
            this.gunabtnFaculty.AnimationHoverSpeed = 0.07F;
            this.gunabtnFaculty.AnimationSpeed = 0.03F;
            this.gunabtnFaculty.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnFaculty.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunabtnFaculty.BorderColor = System.Drawing.Color.Black;
            this.gunabtnFaculty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnFaculty.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnFaculty.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnFaculty.ForeColor = System.Drawing.Color.White;
            this.gunabtnFaculty.Image = null;
            this.gunabtnFaculty.ImageSize = new System.Drawing.Size(30, 30);
            this.gunabtnFaculty.Location = new System.Drawing.Point(178, 419);
            this.gunabtnFaculty.Name = "gunabtnFaculty";
            this.gunabtnFaculty.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnFaculty.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnFaculty.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnFaculty.OnHoverImage = null;
            this.gunabtnFaculty.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnFaculty.Radius = 20;
            this.gunabtnFaculty.Size = new System.Drawing.Size(388, 55);
            this.gunabtnFaculty.TabIndex = 2;
            this.gunabtnFaculty.Text = "Faculty";
            this.gunabtnFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnFaculty.Click += new System.EventHandler(this.gunabtnFaculty_Click);
            // 
            // gunabtnStudent
            // 
            this.gunabtnStudent.AnimationHoverSpeed = 0.07F;
            this.gunabtnStudent.AnimationSpeed = 0.03F;
            this.gunabtnStudent.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnStudent.BaseColor = System.Drawing.Color.RoyalBlue;
            this.gunabtnStudent.BorderColor = System.Drawing.Color.Black;
            this.gunabtnStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnStudent.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnStudent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnStudent.ForeColor = System.Drawing.Color.White;
            this.gunabtnStudent.Image = null;
            this.gunabtnStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnStudent.Location = new System.Drawing.Point(178, 504);
            this.gunabtnStudent.Name = "gunabtnStudent";
            this.gunabtnStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnStudent.OnHoverImage = null;
            this.gunabtnStudent.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnStudent.OnPressedDepth = 0;
            this.gunabtnStudent.Radius = 20;
            this.gunabtnStudent.Size = new System.Drawing.Size(388, 49);
            this.gunabtnStudent.TabIndex = 3;
            this.gunabtnStudent.Text = "Student";
            this.gunabtnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnStudent.Click += new System.EventHandler(this.gunabtnStudent_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(1, 619);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 10;
            this.gunaGradientButton1.Size = new System.Drawing.Size(33, 30);
            this.gunaGradientButton1.TabIndex = 10;
            this.gunaGradientButton1.Text = "x";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunabtnStudent);
            this.Controls.Add(this.gunabtnFaculty);
            this.Controls.Add(this.gunabtnAdministration);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccess";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton gunabtnAdministration;
        private Guna.UI.WinForms.GunaButton gunabtnFaculty;
        private Guna.UI.WinForms.GunaButton gunabtnStudent;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}

