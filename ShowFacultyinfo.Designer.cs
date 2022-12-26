namespace MyAccess
{
    partial class ShowFacultyinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFacultyinfo));
            this.gunabtnpress = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBFacultyinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFacultyinfoDataSet = new MyAccess.DBFacultyinfoDataSet();
            this.gunatxtboxId = new Guna.UI.WinForms.GunaTextBox();
            this.gunabtnshow = new Guna.UI.WinForms.GunaButton();
            this.gunalblId = new Guna.UI.WinForms.GunaLabel();
            this.dBFacultyinfoTableAdapter = new MyAccess.DBFacultyinfoDataSetTableAdapters.DBFacultyinfoTableAdapter();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunabtnpress
            // 
            this.gunabtnpress.AnimationHoverSpeed = 0.07F;
            this.gunabtnpress.AnimationSpeed = 0.03F;
            this.gunabtnpress.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnpress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnpress.BorderColor = System.Drawing.Color.Black;
            this.gunabtnpress.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnpress.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnpress.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.gunabtnpress.ForeColor = System.Drawing.Color.White;
            this.gunabtnpress.Image = null;
            this.gunabtnpress.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnpress.Location = new System.Drawing.Point(530, 199);
            this.gunabtnpress.Name = "gunabtnpress";
            this.gunabtnpress.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnpress.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnpress.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnpress.OnHoverImage = null;
            this.gunabtnpress.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnpress.Radius = 20;
            this.gunabtnpress.Size = new System.Drawing.Size(203, 42);
            this.gunabtnpress.TabIndex = 11;
            this.gunabtnpress.Text = "Press";
            this.gunabtnpress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnpress.Click += new System.EventHandler(this.gunabtnpress_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBFacultyinfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(53, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 87);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "Joining Date";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "Joining Date";
            this.joiningDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.Width = 125;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBFacultyinfoBindingSource
            // 
            this.dBFacultyinfoBindingSource.DataMember = "DBFacultyinfo";
            this.dBFacultyinfoBindingSource.DataSource = this.dBFacultyinfoDataSet;
            // 
            // dBFacultyinfoDataSet
            // 
            this.dBFacultyinfoDataSet.DataSetName = "DBFacultyinfoDataSet";
            this.dBFacultyinfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunatxtboxId
            // 
            this.gunatxtboxId.BaseColor = System.Drawing.Color.White;
            this.gunatxtboxId.BorderColor = System.Drawing.Color.Silver;
            this.gunatxtboxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtboxId.FocusedBaseColor = System.Drawing.Color.White;
            this.gunatxtboxId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunatxtboxId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunatxtboxId.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.gunatxtboxId.Location = new System.Drawing.Point(53, 199);
            this.gunatxtboxId.Name = "gunatxtboxId";
            this.gunatxtboxId.PasswordChar = '\0';
            this.gunatxtboxId.SelectedText = "";
            this.gunatxtboxId.Size = new System.Drawing.Size(453, 42);
            this.gunatxtboxId.TabIndex = 9;
            this.gunatxtboxId.TextChanged += new System.EventHandler(this.gunatxtboxId_TextChanged);
            // 
            // gunabtnshow
            // 
            this.gunabtnshow.AnimationHoverSpeed = 0.07F;
            this.gunabtnshow.AnimationSpeed = 0.03F;
            this.gunabtnshow.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnshow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnshow.BorderColor = System.Drawing.Color.Black;
            this.gunabtnshow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnshow.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnshow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.gunabtnshow.ForeColor = System.Drawing.Color.White;
            this.gunabtnshow.Image = null;
            this.gunabtnshow.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnshow.Location = new System.Drawing.Point(53, 310);
            this.gunabtnshow.Name = "gunabtnshow";
            this.gunabtnshow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnshow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnshow.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnshow.OnHoverImage = null;
            this.gunabtnshow.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnshow.Radius = 20;
            this.gunabtnshow.Size = new System.Drawing.Size(257, 42);
            this.gunabtnshow.TabIndex = 8;
            this.gunabtnshow.Text = "Show";
            this.gunabtnshow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnshow.Click += new System.EventHandler(this.gunabtnshow_Click);
            // 
            // gunalblId
            // 
            this.gunalblId.AutoSize = true;
            this.gunalblId.BackColor = System.Drawing.Color.Transparent;
            this.gunalblId.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunalblId.ForeColor = System.Drawing.Color.White;
            this.gunalblId.Location = new System.Drawing.Point(48, 171);
            this.gunalblId.Name = "gunalblId";
            this.gunalblId.Size = new System.Drawing.Size(222, 25);
            this.gunalblId.TabIndex = 7;
            this.gunalblId.Text = "Please Enter your ID";
            this.gunalblId.Click += new System.EventHandler(this.gunalblId_Click);
            // 
            // dBFacultyinfoTableAdapter
            // 
            this.dBFacultyinfoTableAdapter.ClearBeforeFill = true;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(0, 619);
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
            // ShowFacultyinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunabtnpress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunatxtboxId);
            this.Controls.Add(this.gunabtnshow);
            this.Controls.Add(this.gunalblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowFacultyinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowFacultyinfo";
            this.Load += new System.EventHandler(this.ShowFacultyinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunabtnpress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxId;
        private Guna.UI.WinForms.GunaButton gunabtnshow;
        private Guna.UI.WinForms.GunaLabel gunalblId;
        private DBFacultyinfoDataSet dBFacultyinfoDataSet;
        private System.Windows.Forms.BindingSource dBFacultyinfoBindingSource;
        private DBFacultyinfoDataSetTableAdapters.DBFacultyinfoTableAdapter dBFacultyinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}