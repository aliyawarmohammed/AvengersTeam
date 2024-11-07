namespace WindowsCrudApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeDbDataSet = new WindowsCrudApp.EmployeeDbDataSet();
            this.spGetEmployeeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetEmployeeDataTableAdapter = new WindowsCrudApp.EmployeeDbDataSetTableAdapters.sp_GetEmployeeDataTableAdapter();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Employee Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spGetEmployeeDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // employeeDbDataSet
            // 
            this.employeeDbDataSet.DataSetName = "EmployeeDbDataSet";
            this.employeeDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetEmployeeDataBindingSource
            // 
            this.spGetEmployeeDataBindingSource.DataMember = "sp_GetEmployeeData";
            this.spGetEmployeeDataBindingSource.DataSource = this.employeeDbDataSet;
            // 
            // sp_GetEmployeeDataTableAdapter
            // 
            this.sp_GetEmployeeDataTableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            this.empSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.Location = new System.Drawing.Point(796, 400);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 67);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 568);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeDbDataSet employeeDbDataSet;
        private System.Windows.Forms.BindingSource spGetEmployeeDataBindingSource;
        private EmployeeDbDataSetTableAdapters.sp_GetEmployeeDataTableAdapter sp_GetEmployeeDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreate;
    }
}

