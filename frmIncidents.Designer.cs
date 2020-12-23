
namespace Processes_and_procedures
{
    partial class frmIncidents
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
            this.lblIncID = new System.Windows.Forms.Label();
            this.txtIncID = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grpSubmitDate = new System.Windows.Forms.GroupBox();
            this.txtSubmitDate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.processesAndProcedures_DataSet = new Processes_and_procedures.ProcessesAndProcedures_DataSet();
            this.processesAndProceduresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new Processes_and_procedures.ProcessesAndProcedures_DataSetTableAdapters.IncidentsTableAdapter();
            this.incidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSubmitDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProceduresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncID
            // 
            this.lblIncID.AutoSize = true;
            this.lblIncID.Location = new System.Drawing.Point(31, 36);
            this.lblIncID.Name = "lblIncID";
            this.lblIncID.Size = new System.Drawing.Size(78, 17);
            this.lblIncID.TabIndex = 0;
            this.lblIncID.Text = "Incident ID:";
            // 
            // txtIncID
            // 
            this.txtIncID.Location = new System.Drawing.Point(115, 36);
            this.txtIncID.Name = "txtIncID";
            this.txtIncID.Size = new System.Drawing.Size(200, 22);
            this.txtIncID.TabIndex = 1;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(59, 73);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(50, 17);
            this.lblActive.TabIndex = 2;
            this.lblActive.Text = "Active:";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(116, 74);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 3;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Location = new System.Drawing.Point(31, 110);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(78, 17);
            this.lblProcedure.TabIndex = 4;
            this.lblProcedure.Text = "Procedure:";
            // 
            // txtProcedure
            // 
            this.txtProcedure.Location = new System.Drawing.Point(116, 107);
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(199, 22);
            this.txtProcedure.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(26, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 145);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(199, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 70);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // grpSubmitDate
            // 
            this.grpSubmitDate.Controls.Add(this.txtSubmitDate);
            this.grpSubmitDate.Controls.Add(this.monthCalendar1);
            this.grpSubmitDate.Location = new System.Drawing.Point(12, 187);
            this.grpSubmitDate.Name = "grpSubmitDate";
            this.grpSubmitDate.Size = new System.Drawing.Size(303, 300);
            this.grpSubmitDate.TabIndex = 9;
            this.grpSubmitDate.TabStop = false;
            this.grpSubmitDate.Text = "Submit Date";
            // 
            // txtSubmitDate
            // 
            this.txtSubmitDate.Location = new System.Drawing.Point(22, 37);
            this.txtSubmitDate.Name = "txtSubmitDate";
            this.txtSubmitDate.Size = new System.Drawing.Size(262, 22);
            this.txtSubmitDate.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 510);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 209);
            this.textBox1.TabIndex = 10;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(26, 490);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incidentIDDataGridViewTextBoxColumn,
            this.incidentNumberDataGridViewTextBoxColumn,
            this.procedureIDDataGridViewTextBoxColumn,
            this.incidentDescriptionDataGridViewTextBoxColumn,
            this.incidentDateDataGridViewTextBoxColumn,
            this.incidentNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incidentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(338, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 680);
            this.dataGridView1.TabIndex = 12;
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
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.processesAndProceduresDataSetBindingSource;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // incidentIDDataGridViewTextBoxColumn
            // 
            this.incidentIDDataGridViewTextBoxColumn.DataPropertyName = "Incident_ID";
            this.incidentIDDataGridViewTextBoxColumn.HeaderText = "Incident_ID";
            this.incidentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentIDDataGridViewTextBoxColumn.Name = "incidentIDDataGridViewTextBoxColumn";
            this.incidentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.incidentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // incidentNumberDataGridViewTextBoxColumn
            // 
            this.incidentNumberDataGridViewTextBoxColumn.DataPropertyName = "Incident_Number";
            this.incidentNumberDataGridViewTextBoxColumn.HeaderText = "Incident_Number";
            this.incidentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentNumberDataGridViewTextBoxColumn.Name = "incidentNumberDataGridViewTextBoxColumn";
            this.incidentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // procedureIDDataGridViewTextBoxColumn
            // 
            this.procedureIDDataGridViewTextBoxColumn.DataPropertyName = "Procedure_ID";
            this.procedureIDDataGridViewTextBoxColumn.HeaderText = "Procedure_ID";
            this.procedureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procedureIDDataGridViewTextBoxColumn.Name = "procedureIDDataGridViewTextBoxColumn";
            this.procedureIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // incidentDescriptionDataGridViewTextBoxColumn
            // 
            this.incidentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Incident_Description";
            this.incidentDescriptionDataGridViewTextBoxColumn.HeaderText = "Incident_Description";
            this.incidentDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentDescriptionDataGridViewTextBoxColumn.Name = "incidentDescriptionDataGridViewTextBoxColumn";
            this.incidentDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // incidentDateDataGridViewTextBoxColumn
            // 
            this.incidentDateDataGridViewTextBoxColumn.DataPropertyName = "Incident_Date";
            this.incidentDateDataGridViewTextBoxColumn.HeaderText = "Incident_Date";
            this.incidentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentDateDataGridViewTextBoxColumn.Name = "incidentDateDataGridViewTextBoxColumn";
            this.incidentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // incidentNotesDataGridViewTextBoxColumn
            // 
            this.incidentNotesDataGridViewTextBoxColumn.DataPropertyName = "Incident_Notes";
            this.incidentNotesDataGridViewTextBoxColumn.HeaderText = "Incident_Notes";
            this.incidentNotesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incidentNotesDataGridViewTextBoxColumn.Name = "incidentNotesDataGridViewTextBoxColumn";
            this.incidentNotesDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpSubmitDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtProcedure);
            this.Controls.Add(this.lblProcedure);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.txtIncID);
            this.Controls.Add(this.lblIncID);
            this.Name = "frmIncidents";
            this.Text = "Incident Repository";
            this.Load += new System.EventHandler(this.frmIncidents_Load);
            this.grpSubmitDate.ResumeLayout(false);
            this.grpSubmitDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProceduresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncID;
        private System.Windows.Forms.TextBox txtIncID;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox grpSubmitDate;
        private System.Windows.Forms.TextBox txtSubmitDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource processesAndProceduresDataSetBindingSource;
        private ProcessesAndProcedures_DataSet processesAndProcedures_DataSet;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private ProcessesAndProcedures_DataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentNotesDataGridViewTextBoxColumn;
    }
}