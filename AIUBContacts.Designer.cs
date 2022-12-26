namespace MyAccess
{
    partial class AIUBContacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIUBContacts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBAIUBContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBAIUBContactsDataSet = new MyAccess.DBAIUBContactsDataSet();
            this.dBAIUBContactsTableAdapter = new MyAccess.DBAIUBContactsDataSetTableAdapters.DBAIUBContactsTableAdapter();
            this.gunabtnshowaiubinfo = new Guna.UI.WinForms.GunaButton();
            this.gunabtnsearchinfo = new Guna.UI.WinForms.GunaButton();
            this.gunalblaiubinfo = new Guna.UI.WinForms.GunaLabel();
            this.gunatxtboxsearchinfo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAIUBContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAIUBContactsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBAIUBContactsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(30, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // facultyDepartmentDesignationDataGridViewTextBoxColumn
            // 
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn.DataPropertyName = "Faculty/ Department Designation";
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn.HeaderText = "Faculty/ Department Designation";
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn.Name = "facultyDepartmentDesignationDataGridViewTextBoxColumn";
            this.facultyDepartmentDesignationDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBAIUBContactsBindingSource
            // 
            this.dBAIUBContactsBindingSource.DataMember = "DBAIUBContacts";
            this.dBAIUBContactsBindingSource.DataSource = this.dBAIUBContactsDataSet;
            // 
            // dBAIUBContactsDataSet
            // 
            this.dBAIUBContactsDataSet.DataSetName = "DBAIUBContactsDataSet";
            this.dBAIUBContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBAIUBContactsTableAdapter
            // 
            this.dBAIUBContactsTableAdapter.ClearBeforeFill = true;
            // 
            // gunabtnshowaiubinfo
            // 
            this.gunabtnshowaiubinfo.AnimationHoverSpeed = 0.07F;
            this.gunabtnshowaiubinfo.AnimationSpeed = 0.03F;
            this.gunabtnshowaiubinfo.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnshowaiubinfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnshowaiubinfo.BorderColor = System.Drawing.Color.Black;
            this.gunabtnshowaiubinfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnshowaiubinfo.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnshowaiubinfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnshowaiubinfo.ForeColor = System.Drawing.Color.White;
            this.gunabtnshowaiubinfo.Image = null;
            this.gunabtnshowaiubinfo.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnshowaiubinfo.Location = new System.Drawing.Point(30, 47);
            this.gunabtnshowaiubinfo.Name = "gunabtnshowaiubinfo";
            this.gunabtnshowaiubinfo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnshowaiubinfo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnshowaiubinfo.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnshowaiubinfo.OnHoverImage = null;
            this.gunabtnshowaiubinfo.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnshowaiubinfo.Radius = 20;
            this.gunabtnshowaiubinfo.Size = new System.Drawing.Size(308, 45);
            this.gunabtnshowaiubinfo.TabIndex = 1;
            this.gunabtnshowaiubinfo.Text = "Show Contacts";
            this.gunabtnshowaiubinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnshowaiubinfo.Click += new System.EventHandler(this.gunabtnshowaiubinfo_Click);
            // 
            // gunabtnsearchinfo
            // 
            this.gunabtnsearchinfo.AnimationHoverSpeed = 0.07F;
            this.gunabtnsearchinfo.AnimationSpeed = 0.03F;
            this.gunabtnsearchinfo.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnsearchinfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnsearchinfo.BorderColor = System.Drawing.Color.Black;
            this.gunabtnsearchinfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnsearchinfo.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnsearchinfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnsearchinfo.ForeColor = System.Drawing.Color.White;
            this.gunabtnsearchinfo.Image = null;
            this.gunabtnsearchinfo.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnsearchinfo.Location = new System.Drawing.Point(508, 527);
            this.gunabtnsearchinfo.Name = "gunabtnsearchinfo";
            this.gunabtnsearchinfo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnsearchinfo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnsearchinfo.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnsearchinfo.OnHoverImage = null;
            this.gunabtnsearchinfo.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnsearchinfo.Radius = 20;
            this.gunabtnsearchinfo.Size = new System.Drawing.Size(240, 51);
            this.gunabtnsearchinfo.TabIndex = 2;
            this.gunabtnsearchinfo.Text = "Search";
            this.gunabtnsearchinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnsearchinfo.Click += new System.EventHandler(this.gunabtnsearchinfo_Click);
            // 
            // gunalblaiubinfo
            // 
            this.gunalblaiubinfo.AutoSize = true;
            this.gunalblaiubinfo.BackColor = System.Drawing.Color.Transparent;
            this.gunalblaiubinfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunalblaiubinfo.ForeColor = System.Drawing.Color.Transparent;
            this.gunalblaiubinfo.Location = new System.Drawing.Point(25, 489);
            this.gunalblaiubinfo.Name = "gunalblaiubinfo";
            this.gunalblaiubinfo.Size = new System.Drawing.Size(253, 25);
            this.gunalblaiubinfo.TabIndex = 3;
            this.gunalblaiubinfo.Text = "Write down your query-";
            // 
            // gunatxtboxsearchinfo
            // 
            this.gunatxtboxsearchinfo.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxsearchinfo.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxsearchinfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxsearchinfo.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxsearchinfo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxsearchinfo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxsearchinfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunatxtboxsearchinfo.Location = new System.Drawing.Point(30, 527);
            this.gunatxtboxsearchinfo.Name = "gunatxtboxsearchinfo";
            this.gunatxtboxsearchinfo.PasswordChar = '\0';
            this.gunatxtboxsearchinfo.SelectedText = "";
            this.gunatxtboxsearchinfo.Size = new System.Drawing.Size(454, 51);
            this.gunatxtboxsearchinfo.TabIndex = 4;
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
            this.gunaGradientButton1.TabIndex = 11;
            this.gunaGradientButton1.Text = "x";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // AIUBContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunatxtboxsearchinfo);
            this.Controls.Add(this.gunalblaiubinfo);
            this.Controls.Add(this.gunabtnsearchinfo);
            this.Controls.Add(this.gunabtnshowaiubinfo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AIUBContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIUBContacts";
            this.Load += new System.EventHandler(this.AIUBContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAIUBContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAIUBContactsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBAIUBContactsDataSet dBAIUBContactsDataSet;
        private System.Windows.Forms.BindingSource dBAIUBContactsBindingSource;
        private DBAIUBContactsDataSetTableAdapters.DBAIUBContactsTableAdapter dBAIUBContactsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDepartmentDesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton gunabtnshowaiubinfo;
        private Guna.UI.WinForms.GunaButton gunabtnsearchinfo;
        private Guna.UI.WinForms.GunaLabel gunalblaiubinfo;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxsearchinfo;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}