
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
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.chkIsImportant = new System.Windows.Forms.CheckBox();
            this.chkIsComplete = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grpBxCalendar = new System.Windows.Forms.GroupBox();
            this.lblTaskStart = new System.Windows.Forms.Label();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.lblTaskRequests = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBxCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(176, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // chkIsImportant
            // 
            this.chkIsImportant.AutoSize = true;
            this.chkIsImportant.Location = new System.Drawing.Point(51, 70);
            this.chkIsImportant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.chkIsComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkIsComplete.Name = "chkIsComplete";
            this.chkIsComplete.Size = new System.Drawing.Size(70, 17);
            this.chkIsComplete.TabIndex = 3;
            this.chkIsComplete.Text = "Complete";
            this.chkIsComplete.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 21);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // grpBxCalendar
            // 
            this.grpBxCalendar.Controls.Add(this.monthCalendar1);
            this.grpBxCalendar.Location = new System.Drawing.Point(31, 136);
            this.grpBxCalendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBxCalendar.Name = "grpBxCalendar";
            this.grpBxCalendar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBxCalendar.Size = new System.Drawing.Size(237, 199);
            this.grpBxCalendar.TabIndex = 6;
            this.grpBxCalendar.TabStop = false;
            this.grpBxCalendar.Text = "Calendar";
            // 
            // lblTaskStart
            // 
            this.lblTaskStart.AutoSize = true;
            this.lblTaskStart.Location = new System.Drawing.Point(7, 107);
            this.lblTaskStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskStart.Name = "lblTaskStart";
            this.lblTaskStart.Size = new System.Drawing.Size(85, 13);
            this.lblTaskStart.TabIndex = 7;
            this.lblTaskStart.Text = "Task Start Date:";
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.Location = new System.Drawing.Point(92, 105);
            this.txtTaskStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(176, 20);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 345);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 388);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 182);
            this.textBox2.TabIndex = 11;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 535);
            this.dataGridView1.TabIndex = 13;
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
            this.btnExit.Location = new System.Drawing.Point(805, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 643);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTaskRequests);
            this.Controls.Add(this.txtTaskStart);
            this.Controls.Add(this.lblTaskStart);
            this.Controls.Add(this.grpBxCalendar);
            this.Controls.Add(this.chkIsComplete);
            this.Controls.Add(this.chkIsImportant);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmToDo";
            this.Text = "To-Do List";
            this.grpBxCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblTaskStart;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.Label lblTaskRequests;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}