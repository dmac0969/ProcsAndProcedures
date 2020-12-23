
namespace Processes_and_procedures
{
    partial class frmToDo
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
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.chkIsImportant = new System.Windows.Forms.CheckBox();
            this.chkIsComplete = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grpBxCalendar = new System.Windows.Forms.GroupBox();
            this.lblTaskDue = new System.Windows.Forms.Label();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.lblTaskRequests = new System.Windows.Forms.Label();
            this.txtAssocReq = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processesAndProcedures_DataSet = new Processes_and_procedures.ProcessesAndProcedures_DataSet();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toDo_ListTableAdapter = new Processes_and_procedures.ProcessesAndProcedures_DataSetTableAdapters.ToDo_ListTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskRequestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(10, 30);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(65, 13);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(92, 30);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(187, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // chkIsImportant
            // 
            this.chkIsImportant.AutoSize = true;
            this.chkIsImportant.Location = new System.Drawing.Point(51, 70);
            this.chkIsImportant.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsImportant.Name = "chkIsImportant";
            this.chkIsImportant.Size = new System.Drawing.Size(70, 17);
            this.chkIsImportant.TabIndex = 2;
            this.chkIsImportant.Text = "Important";
            this.chkIsImportant.UseVisualStyleBackColor = true;
            // 
            // chkIsComplete
            // 
            this.chkIsComplete.AutoSize = true;
            this.chkIsComplete.Location = new System.Drawing.Point(144, 70);
            this.chkIsComplete.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsComplete.Name = "chkIsComplete";
            this.chkIsComplete.Size = new System.Drawing.Size(70, 17);
            this.chkIsComplete.TabIndex = 3;
            this.chkIsComplete.Text = "Complete";
            this.chkIsComplete.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 21);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // grpBxCalendar
            // 
            this.grpBxCalendar.Controls.Add(this.monthCalendar1);
            this.grpBxCalendar.Location = new System.Drawing.Point(31, 136);
            this.grpBxCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxCalendar.Name = "grpBxCalendar";
            this.grpBxCalendar.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxCalendar.Size = new System.Drawing.Size(248, 199);
            this.grpBxCalendar.TabIndex = 6;
            this.grpBxCalendar.TabStop = false;
            this.grpBxCalendar.Text = "Calendar";
            // 
            // lblTaskDue
            // 
            this.lblTaskDue.AutoSize = true;
            this.lblTaskDue.Location = new System.Drawing.Point(7, 107);
            this.lblTaskDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskDue.Name = "lblTaskDue";
            this.lblTaskDue.Size = new System.Drawing.Size(83, 13);
            this.lblTaskDue.TabIndex = 7;
            this.lblTaskDue.Text = "Task Due Date:";
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.Location = new System.Drawing.Point(92, 107);
            this.txtTaskStart.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(187, 20);
            this.txtTaskStart.TabIndex = 8;
            // 
            // lblTaskRequests
            // 
            this.lblTaskRequests.AutoSize = true;
            this.lblTaskRequests.Location = new System.Drawing.Point(10, 348);
            this.lblTaskRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskRequests.Name = "lblTaskRequests";
            this.lblTaskRequests.Size = new System.Drawing.Size(110, 13);
            this.lblTaskRequests.TabIndex = 9;
            this.lblTaskRequests.Text = "Associated Requests:";
            // 
            // txtAssocReq
            // 
            this.txtAssocReq.Location = new System.Drawing.Point(124, 345);
            this.txtAssocReq.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssocReq.Name = "txtAssocReq";
            this.txtAssocReq.Size = new System.Drawing.Size(155, 20);
            this.txtAssocReq.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 388);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 177);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 371);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Task Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskNameDataGridViewTextBoxColumn,
            this.importantDataGridViewCheckBoxColumn,
            this.isCompleteDataGridViewCheckBoxColumn,
            this.taskStartDateDataGridViewTextBoxColumn,
            this.taskRequestsDataGridViewTextBoxColumn,
            this.taskDescriptionDataGridViewTextBoxColumn,
            this.ToDo_ID});
            this.dataGridView1.DataSource = this.toDoListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 535);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toDoListBindingSource
            // 
            this.toDoListBindingSource.DataMember = "ToDo_List";
            this.toDoListBindingSource.DataSource = this.processesAndProcedures_DataSet;
            // 
            // processesAndProcedures_DataSet
            // 
            this.processesAndProcedures_DataSet.DataSetName = "ProcessesAndProcedures_DataSet";
            this.processesAndProcedures_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 584);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 35);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(933, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // toDo_ListTableAdapter
            // 
            this.toDo_ListTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(293, 584);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 35);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "Task_Name";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Task Name";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // importantDataGridViewCheckBoxColumn
            // 
            this.importantDataGridViewCheckBoxColumn.DataPropertyName = "Important";
            this.importantDataGridViewCheckBoxColumn.HeaderText = "Important";
            this.importantDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.importantDataGridViewCheckBoxColumn.Name = "importantDataGridViewCheckBoxColumn";
            this.importantDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isCompleteDataGridViewCheckBoxColumn
            // 
            this.isCompleteDataGridViewCheckBoxColumn.DataPropertyName = "IsComplete";
            this.isCompleteDataGridViewCheckBoxColumn.HeaderText = "Complete";
            this.isCompleteDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isCompleteDataGridViewCheckBoxColumn.Name = "isCompleteDataGridViewCheckBoxColumn";
            this.isCompleteDataGridViewCheckBoxColumn.Width = 125;
            // 
            // taskStartDateDataGridViewTextBoxColumn
            // 
            this.taskStartDateDataGridViewTextBoxColumn.DataPropertyName = "Task_Start_Date";
            this.taskStartDateDataGridViewTextBoxColumn.HeaderText = "Task Due Date";
            this.taskStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskStartDateDataGridViewTextBoxColumn.Name = "taskStartDateDataGridViewTextBoxColumn";
            this.taskStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskRequestsDataGridViewTextBoxColumn
            // 
            this.taskRequestsDataGridViewTextBoxColumn.DataPropertyName = "Task_Requests";
            this.taskRequestsDataGridViewTextBoxColumn.HeaderText = "Task Requests";
            this.taskRequestsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskRequestsDataGridViewTextBoxColumn.Name = "taskRequestsDataGridViewTextBoxColumn";
            this.taskRequestsDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskDescriptionDataGridViewTextBoxColumn
            // 
            this.taskDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Task_Description";
            this.taskDescriptionDataGridViewTextBoxColumn.HeaderText = "Task Description";
            this.taskDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskDescriptionDataGridViewTextBoxColumn.Name = "taskDescriptionDataGridViewTextBoxColumn";
            this.taskDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ToDo_ID
            // 
            this.ToDo_ID.DataPropertyName = "ToDo_ID";
            this.ToDo_ID.HeaderText = "ToDo_ID";
            this.ToDo_ID.Name = "ToDo_ID";
            this.ToDo_ID.ReadOnly = true;
            this.ToDo_ID.Visible = false;
            // 
            // frmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 639);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAssocReq);
            this.Controls.Add(this.lblTaskRequests);
            this.Controls.Add(this.txtTaskStart);
            this.Controls.Add(this.lblTaskDue);
            this.Controls.Add(this.grpBxCalendar);
            this.Controls.Add(this.chkIsComplete);
            this.Controls.Add(this.chkIsImportant);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmToDo";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.frmToDo_Load);
            this.grpBxCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.CheckBox chkIsImportant;
        private System.Windows.Forms.CheckBox chkIsComplete;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox grpBxCalendar;
        private System.Windows.Forms.Label lblTaskDue;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.Label lblTaskRequests;
        private System.Windows.Forms.TextBox txtAssocReq;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private ProcessesAndProcedures_DataSet processesAndProcedures_DataSet;
        private System.Windows.Forms.BindingSource toDoListBindingSource;
        private ProcessesAndProcedures_DataSetTableAdapters.ToDo_ListTableAdapter toDo_ListTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn importantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskRequestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDo_ID;
    }
}