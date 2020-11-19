namespace Processes_and_procedures
{
    partial class frmViewSteps
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
            this.stepNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procedure_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step_Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processesAndProcedures_DataSet1 = new Processes_and_procedures.ProcessesAndProcedures_DataSet();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnUpdateStep = new System.Windows.Forms.Button();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStepNumber = new System.Windows.Forms.Label();
            this.txtStepNumber = new System.Windows.Forms.TextBox();
            this.txtStepText = new System.Windows.Forms.TextBox();
            this.lblStepText = new System.Windows.Forms.Label();
            this.txtStepCommand = new System.Windows.Forms.TextBox();
            this.stepsTableAdapter = new Processes_and_procedures.ProcessesAndProcedures_DataSetTableAdapters.StepsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepNumberDataGridViewTextBoxColumn,
            this.stepTextDataGridViewTextBoxColumn,
            this.Procedure_ID,
            this.dataGridViewTextBoxColumn1,
            this.Step_Command});
            this.dataGridView1.DataSource = this.stepsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(145, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stepNumberDataGridViewTextBoxColumn
            // 
            this.stepNumberDataGridViewTextBoxColumn.DataPropertyName = "Step_Number";
            this.stepNumberDataGridViewTextBoxColumn.HeaderText = "Step_Number";
            this.stepNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stepNumberDataGridViewTextBoxColumn.Name = "stepNumberDataGridViewTextBoxColumn";
            this.stepNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // stepTextDataGridViewTextBoxColumn
            // 
            this.stepTextDataGridViewTextBoxColumn.DataPropertyName = "Step_Text";
            this.stepTextDataGridViewTextBoxColumn.HeaderText = "Step_Text";
            this.stepTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stepTextDataGridViewTextBoxColumn.Name = "stepTextDataGridViewTextBoxColumn";
            this.stepTextDataGridViewTextBoxColumn.Width = 125;
            // 
            // Procedure_ID
            // 
            this.Procedure_ID.DataPropertyName = "Procedure_ID";
            this.Procedure_ID.HeaderText = "Procedure_ID";
            this.Procedure_ID.MinimumWidth = 6;
            this.Procedure_ID.Name = "Procedure_ID";
            this.Procedure_ID.Visible = false;
            this.Procedure_ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Step_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Step_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Step_Command
            // 
            this.Step_Command.DataPropertyName = "Step_Command";
            this.Step_Command.HeaderText = "Step_Command";
            this.Step_Command.MinimumWidth = 6;
            this.Step_Command.Name = "Step_Command";
            this.Step_Command.Width = 125;
            // 
            // stepsBindingSource
            // 
            this.stepsBindingSource.DataMember = "Steps";
            this.stepsBindingSource.DataSource = this.processesAndProcedures_DataSet1;
            // 
            // processesAndProcedures_DataSet1
            // 
            this.processesAndProcedures_DataSet1.DataSetName = "ProcessesAndProcedures_DataSet";
            this.processesAndProcedures_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(38, 71);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(101, 37);
            this.btnAddStep.TabIndex = 1;
            this.btnAddStep.Text = "Add Step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnUpdateStep
            // 
            this.btnUpdateStep.Location = new System.Drawing.Point(38, 128);
            this.btnUpdateStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateStep.Name = "btnUpdateStep";
            this.btnUpdateStep.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateStep.TabIndex = 2;
            this.btnUpdateStep.Text = "Update Step";
            this.btnUpdateStep.UseVisualStyleBackColor = true;
            this.btnUpdateStep.Click += new System.EventHandler(this.btnUpdateStep_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.Location = new System.Drawing.Point(38, 182);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(101, 37);
            this.btnDeleteStep.TabIndex = 3;
            this.btnDeleteStep.Text = "Delete Step";
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.btnDeleteStep_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(38, 312);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepNumber.Location = new System.Drawing.Point(9, 19);
            this.lblStepNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(95, 17);
            this.lblStepNumber.TabIndex = 6;
            this.lblStepNumber.Text = "Step Number:";
            // 
            // txtStepNumber
            // 
            this.txtStepNumber.Location = new System.Drawing.Point(110, 19);
            this.txtStepNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStepNumber.Name = "txtStepNumber";
            this.txtStepNumber.Size = new System.Drawing.Size(129, 20);
            this.txtStepNumber.TabIndex = 7;
            // 
            // txtStepText
            // 
            this.txtStepText.Location = new System.Drawing.Point(338, 19);
            this.txtStepText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStepText.Multiline = true;
            this.txtStepText.Name = "txtStepText";
            this.txtStepText.Size = new System.Drawing.Size(392, 48);
            this.txtStepText.TabIndex = 8;
            // 
            // lblStepText
            // 
            this.lblStepText.AutoSize = true;
            this.lblStepText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepText.Location = new System.Drawing.Point(262, 20);
            this.lblStepText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(72, 17);
            this.lblStepText.TabIndex = 9;
            this.lblStepText.Text = "Step Text:";
            // 
            // txtStepCommand
            // 
            this.txtStepCommand.Location = new System.Drawing.Point(789, 20);
            this.txtStepCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStepCommand.Multiline = true;
            this.txtStepCommand.Name = "txtStepCommand";
            this.txtStepCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStepCommand.Size = new System.Drawing.Size(441, 442);
            this.txtStepCommand.TabIndex = 11;
            this.txtStepCommand.Text = "Enter step command here...";
            // 
            // stepsTableAdapter
            // 
            this.stepsTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 624);
            this.Controls.Add(this.txtStepCommand);
            this.Controls.Add(this.lblStepText);
            this.Controls.Add(this.txtStepText);
            this.Controls.Add(this.txtStepNumber);
            this.Controls.Add(this.lblStepNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteStep);
            this.Controls.Add(this.btnUpdateStep);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewSteps";
            this.Text = "frmViewSteps";
            this.Load += new System.EventHandler(this.frmViewSteps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProcessesAndProcedures_DataSet processesAndProcedures_DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stepsBindingSource;
        private ProcessesAndProcedures_DataSetTableAdapters.StepsTableAdapter stepsTableAdapter;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Button btnUpdateStep;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStepNumber;
        private System.Windows.Forms.TextBox txtStepNumber;
        private System.Windows.Forms.TextBox txtStepText;
        private System.Windows.Forms.Label lblStepText;
        private System.Windows.Forms.TextBox txtStepCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procedure_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step_Command;
    }
}