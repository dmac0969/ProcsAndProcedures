namespace Processes_and_procedures
{
    partial class frmCreateProcedure
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
            this.lblCreateProcedure = new System.Windows.Forms.Label();
            this.txtCreateProcedure = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.processesAndProcedures_DataSet1 = new Processes_and_procedures.ProcessesAndProcedures_DataSet();
            this.proceduresTableAdapter1 = new Processes_and_procedures.ProcessesAndProcedures_DataSetTableAdapters.ProceduresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateProcedure
            // 
            this.lblCreateProcedure.AutoSize = true;
            this.lblCreateProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateProcedure.Location = new System.Drawing.Point(12, 26);
            this.lblCreateProcedure.Name = "lblCreateProcedure";
            this.lblCreateProcedure.Size = new System.Drawing.Size(146, 20);
            this.lblCreateProcedure.TabIndex = 0;
            this.lblCreateProcedure.Text = "Create Procedure:";
            // 
            // txtCreateProcedure
            // 
            this.txtCreateProcedure.Location = new System.Drawing.Point(218, 26);
            this.txtCreateProcedure.Name = "txtCreateProcedure";
            this.txtCreateProcedure.Size = new System.Drawing.Size(412, 22);
            this.txtCreateProcedure.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(304, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // processesAndProcedures_DataSet1
            // 
            this.processesAndProcedures_DataSet1.DataSetName = "ProcessesAndProcedures_DataSet";
            this.processesAndProcedures_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proceduresTableAdapter1
            // 
            this.proceduresTableAdapter1.ClearBeforeFill = true;
            // 
            // frmCreateProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 152);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCreateProcedure);
            this.Controls.Add(this.lblCreateProcedure);
            this.Name = "frmCreateProcedure";
            this.Text = "Create Procedure";
            ((System.ComponentModel.ISupportInitialize)(this.processesAndProcedures_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateProcedure;
        private System.Windows.Forms.TextBox txtCreateProcedure;
        private System.Windows.Forms.Button btnSubmit;
        private ProcessesAndProcedures_DataSet processesAndProcedures_DataSet1;
        private ProcessesAndProcedures_DataSetTableAdapters.ProceduresTableAdapter proceduresTableAdapter1;
    }
}