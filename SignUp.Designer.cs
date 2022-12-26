namespace MyAccess
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.gunalblName = new Guna.UI.WinForms.GunaLabel();
            this.gunalblUsername = new Guna.UI.WinForms.GunaLabel();
            this.gunalblPassword = new Guna.UI.WinForms.GunaLabel();
            this.gunalblConfirmpass = new Guna.UI.WinForms.GunaLabel();
            this.gunatxtboxname = new Guna.UI.WinForms.GunaTextBox();
            this.gunatxtboxuserame = new Guna.UI.WinForms.GunaTextBox();
            this.gunatxtboxpass = new Guna.UI.WinForms.GunaTextBox();
            this.gunatxtboxconfirmpass = new Guna.UI.WinForms.GunaTextBox();
            this.gunabtnsignup = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // gunalblName
            // 
            this.gunalblName.AutoSize = true;
            this.gunalblName.BackColor = System.Drawing.Color.Transparent;
            this.gunalblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunalblName.ForeColor = System.Drawing.Color.White;
            this.gunalblName.Location = new System.Drawing.Point(160, 42);
            this.gunalblName.Name = "gunalblName";
            this.gunalblName.Size = new System.Drawing.Size(71, 25);
            this.gunalblName.TabIndex = 0;
            this.gunalblName.Text = "Name";
            // 
            // gunalblUsername
            // 
            this.gunalblUsername.AutoSize = true;
            this.gunalblUsername.BackColor = System.Drawing.Color.Transparent;
            this.gunalblUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gunalblUsername.ForeColor = System.Drawing.Color.White;
            this.gunalblUsername.Location = new System.Drawing.Point(160, 145);
            this.gunalblUsername.Name = "gunalblUsername";
            this.gunalblUsername.Size = new System.Drawing.Size(156, 25);
            this.gunalblUsername.TabIndex = 1;
            this.gunalblUsername.Text = "Username(ID)";
            // 
            // gunalblPassword
            // 
            this.gunalblPassword.AutoSize = true;
            this.gunalblPassword.BackColor = System.Drawing.Color.Transparent;
            this.gunalblPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gunalblPassword.ForeColor = System.Drawing.Color.White;
            this.gunalblPassword.Location = new System.Drawing.Point(160, 256);
            this.gunalblPassword.Name = "gunalblPassword";
            this.gunalblPassword.Size = new System.Drawing.Size(109, 25);
            this.gunalblPassword.TabIndex = 2;
            this.gunalblPassword.Text = "Password";
            this.gunalblPassword.Click += new System.EventHandler(this.gunalblPassword_Click);
            // 
            // gunalblConfirmpass
            // 
            this.gunalblConfirmpass.AutoSize = true;
            this.gunalblConfirmpass.BackColor = System.Drawing.Color.Transparent;
            this.gunalblConfirmpass.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gunalblConfirmpass.ForeColor = System.Drawing.Color.White;
            this.gunalblConfirmpass.Location = new System.Drawing.Point(160, 377);
            this.gunalblConfirmpass.Name = "gunalblConfirmpass";
            this.gunalblConfirmpass.Size = new System.Drawing.Size(199, 25);
            this.gunalblConfirmpass.TabIndex = 3;
            this.gunalblConfirmpass.Text = "Confirm Password";
            // 
            // gunatxtboxname
            // 
            this.gunatxtboxname.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxname.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxname.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxname.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.gunatxtboxname.Location = new System.Drawing.Point(165, 70);
            this.gunatxtboxname.Name = "gunatxtboxname";
            this.gunatxtboxname.PasswordChar = '\0';
            this.gunatxtboxname.SelectedText = "";
            this.gunatxtboxname.Size = new System.Drawing.Size(374, 44);
            this.gunatxtboxname.TabIndex = 4;
            // 
            // gunatxtboxuserame
            // 
            this.gunatxtboxuserame.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxuserame.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxuserame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxuserame.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxuserame.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxuserame.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxuserame.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.gunatxtboxuserame.Location = new System.Drawing.Point(165, 173);
            this.gunatxtboxuserame.Name = "gunatxtboxuserame";
            this.gunatxtboxuserame.PasswordChar = '\0';
            this.gunatxtboxuserame.SelectedText = "";
            this.gunatxtboxuserame.Size = new System.Drawing.Size(374, 44);
            this.gunatxtboxuserame.TabIndex = 5;
            // 
            // gunatxtboxpass
            // 
            this.gunatxtboxpass.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxpass.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxpass.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxpass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxpass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxpass.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.gunatxtboxpass.Location = new System.Drawing.Point(165, 284);
            this.gunatxtboxpass.Name = "gunatxtboxpass";
            this.gunatxtboxpass.PasswordChar = '*';
            this.gunatxtboxpass.SelectedText = "";
            this.gunatxtboxpass.Size = new System.Drawing.Size(374, 44);
            this.gunatxtboxpass.TabIndex = 6;
            // 
            // gunatxtboxconfirmpass
            // 
            this.gunatxtboxconfirmpass.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxconfirmpass.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxconfirmpass.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxconfirmpass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxconfirmpass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxconfirmpass.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.gunatxtboxconfirmpass.Location = new System.Drawing.Point(165, 405);
            this.gunatxtboxconfirmpass.Name = "gunatxtboxconfirmpass";
            this.gunatxtboxconfirmpass.PasswordChar = '*';
            this.gunatxtboxconfirmpass.SelectedText = "";
            this.gunatxtboxconfirmpass.Size = new System.Drawing.Size(374, 44);
            this.gunatxtboxconfirmpass.TabIndex = 7;
            // 
            // gunabtnsignup
            // 
            this.gunabtnsignup.AnimationHoverSpeed = 0.07F;
            this.gunabtnsignup.AnimationSpeed = 0.03F;
            this.gunabtnsignup.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnsignup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnsignup.BorderColor = System.Drawing.Color.Transparent;
            this.gunabtnsignup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnsignup.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnsignup.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.gunabtnsignup.ForeColor = System.Drawing.Color.White;
            this.gunabtnsignup.Image = null;
            this.gunabtnsignup.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnsignup.Location = new System.Drawing.Point(165, 501);
            this.gunabtnsignup.Name = "gunabtnsignup";
            this.gunabtnsignup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnsignup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnsignup.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnsignup.OnHoverImage = null;
            this.gunabtnsignup.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnsignup.Radius = 20;
            this.gunabtnsignup.Size = new System.Drawing.Size(374, 52);
            this.gunabtnsignup.TabIndex = 8;
            this.gunabtnsignup.Text = "Sign Up";
            this.gunabtnsignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnsignup.Click += new System.EventHandler(this.gunabtnsignup_Click);
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(2, 619);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 10;
            this.gunaGradientButton1.Size = new System.Drawing.Size(33, 30);
            this.gunaGradientButton1.TabIndex = 47;
            this.gunaGradientButton1.Text = "<";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunabtnsignup);
            this.Controls.Add(this.gunatxtboxconfirmpass);
            this.Controls.Add(this.gunatxtboxpass);
            this.Controls.Add(this.gunatxtboxuserame);
            this.Controls.Add(this.gunatxtboxname);
            this.Controls.Add(this.gunalblConfirmpass);
            this.Controls.Add(this.gunalblPassword);
            this.Controls.Add(this.gunalblUsername);
            this.Controls.Add(this.gunalblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunalblName;
        private Guna.UI.WinForms.GunaLabel gunalblUsername;
        private Guna.UI.WinForms.GunaLabel gunalblPassword;
        private Guna.UI.WinForms.GunaLabel gunalblConfirmpass;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxname;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxuserame;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxpass;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxconfirmpass;
        private Guna.UI.WinForms.GunaButton gunabtnsignup;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}