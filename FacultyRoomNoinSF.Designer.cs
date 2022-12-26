namespace MyAccess
{
    partial class FacultyRoomNoinSF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyRoomNoinSF));
            this.gunabtnpress = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBFacultyinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFacultyinfoDataSet1 = new MyAccess.DBFacultyinfoDataSet1();
            this.gunatxtboxId = new Guna.UI.WinForms.GunaTextBox();
            this.gunabtnshow = new Guna.UI.WinForms.GunaButton();
            this.gunalblId = new Guna.UI.WinForms.GunaLabel();
            this.dBFacultyinfoTableAdapter = new MyAccess.DBFacultyinfoDataSet1TableAdapters.DBFacultyinfoTableAdapter();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoDataSet1)).BeginInit();
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
            this.gunabtnpress.Location = new System.Drawing.Point(495, 175);
            this.gunabtnpress.Name = "gunabtnpress";
            this.gunabtnpress.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnpress.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnpress.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnpress.OnHoverImage = null;
            this.gunabtnpress.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnpress.Radius = 20;
            this.gunabtnpress.Size = new System.Drawing.Size(192, 46);
            this.gunabtnpress.TabIndex = 16;
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
            this.roomNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBFacultyinfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(44, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 91);
            this.dataGridView1.TabIndex = 15;
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
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBFacultyinfoBindingSource
            // 
            this.dBFacultyinfoBindingSource.DataMember = "DBFacultyinfo";
            this.dBFacultyinfoBindingSource.DataSource = this.dBFacultyinfoDataSet1;
            // 
            // dBFacultyinfoDataSet1
            // 
            this.dBFacultyinfoDataSet1.DataSetName = "DBFacultyinfoDataSet1";
            this.dBFacultyinfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gunatxtboxId.Location = new System.Drawing.Point(44, 175);
            this.gunatxtboxId.Name = "gunatxtboxId";
            this.gunatxtboxId.PasswordChar = '\0';
            this.gunatxtboxId.SelectedText = "";
            this.gunatxtboxId.Size = new System.Drawing.Size(416, 46);
            this.gunatxtboxId.TabIndex = 14;
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
            this.gunabtnshow.Location = new System.Drawing.Point(44, 286);
            this.gunabtnshow.Name = "gunabtnshow";
            this.gunabtnshow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnshow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnshow.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnshow.OnHoverImage = null;
            this.gunabtnshow.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnshow.Radius = 20;
            this.gunabtnshow.Size = new System.Drawing.Size(246, 46);
            this.gunabtnshow.TabIndex = 13;
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
            this.gunalblId.Location = new System.Drawing.Point(39, 147);
            this.gunalblId.Name = "gunalblId";
            this.gunalblId.Size = new System.Drawing.Size(251, 25);
            this.gunalblId.TabIndex = 12;
            this.gunalblId.Text = "Please Enter Faculty ID";
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(0, 571);
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
            // FacultyRoomNoinSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 603);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunabtnpress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunatxtboxId);
            this.Controls.Add(this.gunabtnshow);
            this.Controls.Add(this.gunalblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyRoomNoinSF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyRoomNoinSF";
            this.Load += new System.EventHandler(this.FacultyRoomNoinSF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyinfoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunabtnpress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxId;
        private Guna.UI.WinForms.GunaButton gunabtnshow;
        private Guna.UI.WinForms.GunaLabel gunalblId;
        private DBFacultyinfoDataSet1 dBFacultyinfoDataSet1;
        private System.Windows.Forms.BindingSource dBFacultyinfoBindingSource;
        private DBFacultyinfoDataSet1TableAdapters.DBFacultyinfoTableAdapter dBFacultyinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}