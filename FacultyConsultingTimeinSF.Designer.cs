namespace MyAccess
{
    partial class FacultyConsultingTimeinSF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyConsultingTimeinSF));
            this.gunabtnpress = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunatxtboxId = new Guna.UI.WinForms.GunaTextBox();
            this.gunalblId = new Guna.UI.WinForms.GunaLabel();
            this.dBFacultyConsultingDataSet = new MyAccess.DBFacultyConsultingDataSet();
            this.dBFacultyConsultingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFacultyConsultingTableAdapter = new MyAccess.DBFacultyConsultingDataSetTableAdapters.DBFacultyConsultingTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultingSession1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultingSession2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultingSession3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultingSession4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyConsultingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyConsultingBindingSource)).BeginInit();
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
            this.gunabtnpress.Location = new System.Drawing.Point(495, 199);
            this.gunabtnpress.Name = "gunabtnpress";
            this.gunabtnpress.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunabtnpress.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunabtnpress.OnHoverForeColor = System.Drawing.Color.White;
            this.gunabtnpress.OnHoverImage = null;
            this.gunabtnpress.OnPressedColor = System.Drawing.Color.Black;
            this.gunabtnpress.Radius = 20;
            this.gunabtnpress.Size = new System.Drawing.Size(238, 42);
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
            this.consultingSession1DataGridViewTextBoxColumn,
            this.consultingSession2DataGridViewTextBoxColumn,
            this.consultingSession3DataGridViewTextBoxColumn,
            this.consultingSession4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBFacultyConsultingBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(53, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 237);
            this.dataGridView1.TabIndex = 10;
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
            this.gunatxtboxId.Size = new System.Drawing.Size(413, 42);
            this.gunatxtboxId.TabIndex = 9;
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
            // 
            // dBFacultyConsultingDataSet
            // 
            this.dBFacultyConsultingDataSet.DataSetName = "DBFacultyConsultingDataSet";
            this.dBFacultyConsultingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBFacultyConsultingBindingSource
            // 
            this.dBFacultyConsultingBindingSource.DataMember = "DBFacultyConsulting";
            this.dBFacultyConsultingBindingSource.DataSource = this.dBFacultyConsultingDataSet;
            // 
            // dBFacultyConsultingTableAdapter
            // 
            this.dBFacultyConsultingTableAdapter.ClearBeforeFill = true;
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
            // consultingSession1DataGridViewTextBoxColumn
            // 
            this.consultingSession1DataGridViewTextBoxColumn.DataPropertyName = "Consulting Session 1";
            this.consultingSession1DataGridViewTextBoxColumn.HeaderText = "Consulting Session 1";
            this.consultingSession1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consultingSession1DataGridViewTextBoxColumn.Name = "consultingSession1DataGridViewTextBoxColumn";
            this.consultingSession1DataGridViewTextBoxColumn.Width = 125;
            // 
            // consultingSession2DataGridViewTextBoxColumn
            // 
            this.consultingSession2DataGridViewTextBoxColumn.DataPropertyName = "Consulting Session 2";
            this.consultingSession2DataGridViewTextBoxColumn.HeaderText = "Consulting Session 2";
            this.consultingSession2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consultingSession2DataGridViewTextBoxColumn.Name = "consultingSession2DataGridViewTextBoxColumn";
            this.consultingSession2DataGridViewTextBoxColumn.Width = 125;
            // 
            // consultingSession3DataGridViewTextBoxColumn
            // 
            this.consultingSession3DataGridViewTextBoxColumn.DataPropertyName = "Consulting Session 3";
            this.consultingSession3DataGridViewTextBoxColumn.HeaderText = "Consulting Session 3";
            this.consultingSession3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consultingSession3DataGridViewTextBoxColumn.Name = "consultingSession3DataGridViewTextBoxColumn";
            this.consultingSession3DataGridViewTextBoxColumn.Width = 125;
            // 
            // consultingSession4DataGridViewTextBoxColumn
            // 
            this.consultingSession4DataGridViewTextBoxColumn.DataPropertyName = "Consulting Session 4";
            this.consultingSession4DataGridViewTextBoxColumn.HeaderText = "Consulting Session 4";
            this.consultingSession4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consultingSession4DataGridViewTextBoxColumn.Name = "consultingSession4DataGridViewTextBoxColumn";
            this.consultingSession4DataGridViewTextBoxColumn.Width = 125;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(-1, 619);
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
            // FacultyConsultingTimeinSF
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
            this.Controls.Add(this.gunalblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyConsultingTimeinSF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyConsultingTimeinSF";
            this.Load += new System.EventHandler(this.FacultyConsultingTimeinSF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyConsultingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacultyConsultingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunabtnpress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaTextBox gunatxtboxId;
        private Guna.UI.WinForms.GunaLabel gunalblId;
        private DBFacultyConsultingDataSet dBFacultyConsultingDataSet;
        private System.Windows.Forms.BindingSource dBFacultyConsultingBindingSource;
        private DBFacultyConsultingDataSetTableAdapters.DBFacultyConsultingTableAdapter dBFacultyConsultingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultingSession1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultingSession2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultingSession3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultingSession4DataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}