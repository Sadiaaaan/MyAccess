namespace MyAccess
{
    partial class ShowSroutine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSroutine));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saturdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sundayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBStudSemesteRroutineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBStudSemesterRoutineDataSet = new MyAccess.DBStudSemesterRoutineDataSet();
            this.dBStudSemesteRroutineTableAdapter = new MyAccess.DBStudSemesterRoutineDataSetTableAdapters.DBStudSemesteRroutineTableAdapter();
            this.gunabtnShowroutine = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudSemesteRroutineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudSemesterRoutineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saturdayDataGridViewTextBoxColumn,
            this.sundayDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdayDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBStudSemesteRroutineBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(40, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // saturdayDataGridViewTextBoxColumn
            // 
            this.saturdayDataGridViewTextBoxColumn.DataPropertyName = "Saturday";
            this.saturdayDataGridViewTextBoxColumn.HeaderText = "Saturday";
            this.saturdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saturdayDataGridViewTextBoxColumn.Name = "saturdayDataGridViewTextBoxColumn";
            this.saturdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.saturdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // sundayDataGridViewTextBoxColumn
            // 
            this.sundayDataGridViewTextBoxColumn.DataPropertyName = "Sunday";
            this.sundayDataGridViewTextBoxColumn.HeaderText = "Sunday";
            this.sundayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sundayDataGridViewTextBoxColumn.Name = "sundayDataGridViewTextBoxColumn";
            this.sundayDataGridViewTextBoxColumn.ReadOnly = true;
            this.sundayDataGridViewTextBoxColumn.Width = 125;
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "Monday";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "Monday";
            this.mondayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            this.mondayDataGridViewTextBoxColumn.ReadOnly = true;
            this.mondayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "Tuesday";
            this.tuesdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            this.tuesdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.tuesdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "Wednesday";
            this.wednesdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            this.wednesdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.wednesdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // thursdayDataGridViewTextBoxColumn
            // 
            this.thursdayDataGridViewTextBoxColumn.DataPropertyName = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.HeaderText = "Thursday";
            this.thursdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thursdayDataGridViewTextBoxColumn.Name = "thursdayDataGridViewTextBoxColumn";
            this.thursdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.thursdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "Friday";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "Friday";
            this.fridayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            this.fridayDataGridViewTextBoxColumn.ReadOnly = true;
            this.fridayDataGridViewTextBoxColumn.Width = 125;
            // 
            // dBStudSemesteRroutineBindingSource
            // 
            this.dBStudSemesteRroutineBindingSource.DataMember = "DBStudSemesteRroutine";
            this.dBStudSemesteRroutineBindingSource.DataSource = this.dBStudSemesterRoutineDataSet;
            // 
            // dBStudSemesterRoutineDataSet
            // 
            this.dBStudSemesterRoutineDataSet.DataSetName = "DBStudSemesterRoutineDataSet";
            this.dBStudSemesterRoutineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBStudSemesteRroutineTableAdapter
            // 
            this.dBStudSemesteRroutineTableAdapter.ClearBeforeFill = true;
            // 
            // gunabtnShowroutine
            // 
            this.gunabtnShowroutine.AnimationHoverSpeed = 0.07F;
            this.gunabtnShowroutine.AnimationSpeed = 0.03F;
            this.gunabtnShowroutine.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnShowroutine.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunabtnShowroutine.BorderColor = System.Drawing.Color.Black;
            this.gunabtnShowroutine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunabtnShowroutine.FocusedColor = System.Drawing.Color.Empty;
            this.gunabtnShowroutine.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.gunabtnShowroutine.ForeColor = System.Drawing.Color.White;
            this.gunabtnShowroutine.Image = null;
            this.gunabtnShowroutine.ImageSize = new System.Drawing.Size(20, 20);
            this.gunabtnShowroutine.Location = new System.Drawing.Point(40, 71);
            this.gunabtnShowroutine.Name = "gunabtnShowroutine";
            this.gunabtnShowroutine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnShowroutine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnShowroutine.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnShowroutine.OnHoverImage = null;
            this.gunabtnShowroutine.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnShowroutine.Radius = 20;
            this.gunabtnShowroutine.Size = new System.Drawing.Size(360, 42);
            this.gunabtnShowroutine.TabIndex = 1;
            this.gunabtnShowroutine.Text = "Show Routine";
            this.gunabtnShowroutine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunabtnShowroutine.Click += new System.EventHandler(this.gunabtnShowroutine_Click);
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
            this.gunaGradientButton1.TabIndex = 47;
            this.gunaGradientButton1.Text = "<";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // ShowSroutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunabtnShowroutine);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowSroutine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowSroutine";
            this.Load += new System.EventHandler(this.ShowSroutine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudSemesteRroutineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudSemesterRoutineDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBStudSemesterRoutineDataSet dBStudSemesterRoutineDataSet;
        private System.Windows.Forms.BindingSource dBStudSemesteRroutineBindingSource;
        private DBStudSemesterRoutineDataSetTableAdapters.DBStudSemesteRroutineTableAdapter dBStudSemesteRroutineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton gunabtnShowroutine;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}