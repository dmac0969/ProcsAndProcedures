using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Processes_and_procedures
{
    public partial class frmToDo : Form
    {
        private static SqlConnection con =
            new SqlConnection("Data Source=NLHOSL--3SQGXT2\\SQLEXPRESS;" +
                      "Initial Catalog=HowTo;Integrated Security=True");

        private SqlCommand cmd =
            new SqlCommand(null, con);

        public frmToDo()
        {
            InitializeComponent();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtTaskStart.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(null, con);

            // Create Parameter objects to hold the desired parameters to input into the database
            SqlParameter prmTaskName    = new SqlParameter("@TaskName",     SqlDbType.Text,     30);
            SqlParameter prmIsImportant = new SqlParameter("@IsImportant",  SqlDbType.Bit,      1);
            SqlParameter prmIsComplete  = new SqlParameter("@isComplete",   SqlDbType.Bit,      1);
            SqlParameter prmStartDate   = new SqlParameter("@StartDate",    SqlDbType.DateTime, 25);
            SqlParameter prmAssocReqs   = new SqlParameter("@TaskRequests", SqlDbType.Text,     50);
            SqlParameter prmTaskDetails = new SqlParameter("@TaskDetails",  SqlDbType.Text,     1000);

            cmd.CommandText = "INSERT INTO ToDo_List (Important, IsComplete, Task_Start_Date, Task_Name, Task_Description, Task_Requests)" +
                              "VALUES (@IsImportant, @IsComplete, @StartDate, @TaskName, @TaskDetails, @TaskRequests)";

            if(chkIsImportant.Checked == true)
            {
                prmIsImportant.Value = 1;
            }
            else
            {
                prmIsImportant.Value = 0;
            }

            if(chkIsComplete.Checked == true)
            {
                prmIsComplete.Value = 1;
            }
            else
            {
                prmIsComplete.Value = 0;
            }

            prmTaskName.Value = txtTaskName.Text;
            prmStartDate.Value = txtTaskStart.Text;
            prmAssocReqs.Value = txtAssocReq.Text;
            prmTaskDetails.Value = txtDescription.Text;

            cmd.Parameters.Add(prmTaskName);
            cmd.Parameters.Add(prmIsImportant);
            cmd.Parameters.Add(prmIsComplete);
            cmd.Parameters.Add(prmStartDate);
            cmd.Parameters.Add(prmAssocReqs);
            cmd.Parameters.Add(prmTaskDetails);

            con.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

            this.toDo_ListTableAdapter.Fill(this.processesAndProcedures_DataSet.ToDo_List);
        }

        private void frmToDo_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'processesAndProcedures_DataSet.ToDo_List' table. You can move, or remove it, as needed.
            this.toDo_ListTableAdapter.Fill(this.processesAndProcedures_DataSet.ToDo_List);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaskName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTaskStart.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAssocReq.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if(dataGridView1.CurrentRow.Cells[1].Value.ToString() == "True")
            {
                chkIsImportant.Checked = true;
            }

            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                chkIsComplete.Checked = true;
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(null, con);

            // Create Parameter objects to hold the desired parameters to input into the database
            SqlParameter prmTaskName    = new SqlParameter("@TaskName",     SqlDbType.Text,     50);
            SqlParameter prmIsImportant = new SqlParameter("@IsImportant",  SqlDbType.Bit,      0);
            SqlParameter prmIsComplete  = new SqlParameter("@IsComplete",   SqlDbType.Bit,      0);
            SqlParameter prmStartDate   = new SqlParameter("@StartDate",    SqlDbType.DateTime, 25);
            SqlParameter prmAssocReqs   = new SqlParameter("@TaskRequests", SqlDbType.Text,     50);
            SqlParameter prmTaskDetails = new SqlParameter("@TaskDetails",  SqlDbType.Text,     1000);
            SqlParameter prmTaskID      = new SqlParameter("@TaskID",       SqlDbType.Int,      0);

            cmd.CommandText = ("UPDATE ToDo_List SET Important     = @IsImportant, " +
                "                                 IsComplete       = @IsComplete, "  +
                "                                 Task_Start_Date  = @StartDate, "   +
                "                                 Task_Name        = @TaskName, "    +
                "                                 Task_Description = @TaskDetails, " +
                "                                 Task_Requests    = @TaskRequests"  +
                "               WHERE ToDo_ID = @TaskID");

            prmTaskName.Value    = txtTaskName.Text;
            prmIsImportant.Value = chkIsImportant.Checked;
            prmIsComplete.Value  = chkIsComplete.Checked;
            prmStartDate.Value   = txtTaskStart.Text;
            prmAssocReqs.Value   = txtAssocReq.Text;
            prmTaskDetails.Value = txtDescription.Text;
            prmTaskID.Value      = dataGridView1.CurrentRow.Cells[6].Value;


            cmd.Parameters.Add(prmTaskName);
            cmd.Parameters.Add(prmIsImportant);
            cmd.Parameters.Add(prmIsComplete);
            cmd.Parameters.Add(prmStartDate);
            cmd.Parameters.Add(prmAssocReqs);
            cmd.Parameters.Add(prmTaskDetails);
            cmd.Parameters.Add(prmTaskID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.toDo_ListTableAdapter.Fill(this.processesAndProcedures_DataSet.ToDo_List);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(null, con);
                cmd.CommandText = "DELETE FROM dbo.ToDo_List WHERE ToDo_ID = @TaskID";

                SqlParameter prmTaskID = new SqlParameter("@TaskID", SqlDbType.Int, 0);
                prmTaskID.Value = dataGridView1.CurrentRow.Cells[6].Value;

                cmd.Parameters.Add(prmTaskID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.toDo_ListTableAdapter.Fill(this.processesAndProcedures_DataSet.ToDo_List);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Unable to delete row.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaskName.Text = null;
            txtTaskStart.Text = null;
            txtAssocReq.Text = null;
            txtDescription.Text = null;
            chkIsComplete.Checked = false;
            chkIsImportant.Checked = false;
        }
    }
}
