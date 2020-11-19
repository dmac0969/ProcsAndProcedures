namespace Processes_and_procedures
{
    partial class frmProcessesAndProcedures
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.procedureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processesAndProcedures_DataSet = new Processes_and_procedures.ProcessesAndProcedures_DataSet();
            this.processesAndProceduresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceduresTableAdapter = new Processes_and_procedures.ProcessesAndProcedures_DataSetTableAdapters.ProceduresTableAdapter();
            this.btnCreateProcedure = new System.Windows.Forms.Button();
            this.btnViewProcedure = new System.Windows.Forms.Button();
            this.btnDeleteProcedure = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProceduresDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedureIDDataGridViewTextBoxColumn,
            this.procedureNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proceduresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(211, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // procedureIDDataGridViewTextBoxColumn
            // 
            this.procedureIDDataGridViewTextBoxColumn.DataPropertyName = "Procedure_ID";
            this.procedureIDDataGridViewTextBoxColumn.HeaderText = "Procedure_ID";
            this.procedureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procedureIDDataGridViewTextBoxColumn.Name = "procedureIDDataGridViewTextBoxColumn";
            this.procedureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.procedureIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // procedureNameDataGridViewTextBoxColumn
            // 
            this.procedureNameDataGridViewTextBoxColumn.DataPropertyName = "Procedure_Name";
            this.procedureNameDataGridViewTextBoxColumn.HeaderText = "Procedure_Name";
            this.procedureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procedureNameDataGridViewTextBoxColumn.Name = "procedureNameDataGridViewTextBoxColumn";
            this.procedureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // proceduresBindingSource
            // 
            this.proceduresBindingSource.DataMember = "Procedures";
            this.proceduresBindingSource.DataSource = this.processesAndProcedures_DataSet;
            // 
            // processesAndProcedures_DataSet
            // 
            this.processesAndProcedures_DataSet.DataSetName = "ProcessesAndProcedures_DataSet";
            this.processesAndProcedures_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processesAndProceduresDataSetBindingSource
            // 
            this.processesAndProceduresDataSetBindingSource.DataSource = this.processesAndProcedures_DataSet;
            this.processesAndProceduresDataSetBindingSource.Position = 0;
            // 
            // proceduresTableAdapter
            // 
            this.proceduresTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateProcedure
            // 
            this.btnCreateProcedure.Location = new System.Drawing.Point(34, 52);
            this.btnCreateProcedure.Name = "btnCreateProcedure";
            this.btnCreateProcedure.Size = new System.Drawing.Size(151, 45);
            this.btnCreateProcedure.TabIndex = 1;
            this.btnCreateProcedure.Text = "Create Procedure";
            this.btnCreateProcedure.UseVisualStyleBackColor = true;
            this.btnCreateProcedure.Click += new System.EventHandler(this.btnCreateProcedure_Click);
            // 
            // btnViewProcedure
            // 
            this.btnViewProcedure.Location = new System.Drawing.Point(34, 141);
            this.btnViewProcedure.Name = "btnViewProcedure";
            this.btnViewProcedure.Size = new System.Drawing.Size(151, 45);
            this.btnViewProcedure.TabIndex = 2;
            this.btnViewProcedure.Text = "View Procedure";
            this.btnViewProcedure.UseVisualStyleBackColor = true;
            this.btnViewProcedure.Click += new System.EventHandler(this.btnViewProcedure_Click);
            // 
            // btnDeleteProcedure
            // 
            this.btnDeleteProcedure.Location = new System.Drawing.Point(34, 234);
            this.btnDeleteProcedure.Name = "btnDeleteProcedure";
            this.btnDeleteProcedure.Size = new System.Drawing.Size(151, 45);
            this.btnDeleteProcedure.TabIndex = 3;
            this.btnDeleteProcedure.Text = "Delete Procedure";
            this.btnDeleteProcedure.UseVisualStyleBackColor = true;
            this.btnDeleteProcedure.Click += new System.EventHandler(this.btnDeleteProcedure_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(34, 318);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmProcessesAndProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteProcedure);
            this.Controls.Add(this.btnViewProcedure);
            this.Controls.Add(this.btnCreateProcedure);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProcessesAndProcedures";
            this.Text = "Processes and Procedures";
            this.Load += new System.EventHandler(this.frmProcessesAndProcedures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProceduresDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource processesAndProceduresDataSetBindingSource;
        private ProcessesAndProcedures_DataSet processesAndProcedures_DataSet;
        private System.Windows.Forms.BindingSource proceduresBindingSource;
        private ProcessesAndProcedures_DataSetTableAdapters.ProceduresTableAdapter proceduresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreateProcedure;
        private System.Windows.Forms.Button btnViewProcedure;
        private System.Windows.Forms.Button btnDeleteProcedure;
        private System.Windows.Forms.Button btnRefresh;
    }
}

