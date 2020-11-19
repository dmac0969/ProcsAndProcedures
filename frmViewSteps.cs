using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Processes_and_procedures
{
    public partial class frmViewSteps : Form
    {
        private int procID;

        private static SqlConnection con =
            new SqlConnection("Data Source=NLHOSL--3SQGXT2\\SQLEXPRESS;" +
                              "Initial Catalog=HowTo;Integrated Security=True");

        private SqlCommand cmd =
            new SqlCommand(null, con);

        public frmViewSteps(String procedureName, int procedure_ID)
        {
            InitializeComponent();
            Text = procedureName + " Procedure";
            procID = procedure_ID;
        }

        internal void LoadProcedures(int ProcedureID)
        {
            String query = "SELECT Step_ID, Procedure_ID, Step_Number, Step_Text, Step_Command FROM dbo.Steps WHERE Procedure_ID = " + ProcedureID;

            DataSet ds1 = new DataSet();

            // Create new table adapter with the data from the specified query
            SqlDataAdapter daSteps
                = new SqlDataAdapter(query, con);

            // Populate the data adapter with the appropriate schema information
            daSteps.FillSchema(ds1, SchemaType.Source, "Steps");
            daSteps.Fill(ds1, "Steps");

            DataTable tblSteps;
            tblSteps = ds1.Tables["Steps"];

            dataGridView1.DataSource = tblSteps;
        }

        internal void refreshTable()
        {
            DataSet ds1 = new DataSet();

            String query = "SELECT Step_ID, Procedure_ID, Step_Number, Step_Text, Step_Command FROM dbo.Steps WHERE Procedure_ID = " + procID;

            // Create new table adapter with the data from the specified query
            SqlDataAdapter daSteps
                = new SqlDataAdapter(query, con);

            // Populate the data adapter with the appropriate schema information
            daSteps.FillSchema(ds1, SchemaType.Source, "Steps");
            daSteps.Fill(ds1, "Steps");

            DataTable tblSteps;
            tblSteps = ds1.Tables["Steps"];

            dataGridView1.DataSource = tblSteps;


        }

        private void frmViewSteps_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(null, con);
            
            SqlParameter procIdParam = new SqlParameter("@Procedure_ID", SqlDbType.Int, 0);
            SqlParameter stepNumParam = new SqlParameter("@Step_Number", SqlDbType.Int, 0);
            SqlParameter stepTxtParam = new SqlParameter("@Step_Text", SqlDbType.Text, 1000);
            SqlParameter stepCmdParam = new SqlParameter("@Step_Command", SqlDbType.Text, 10000);
            

            if (txtStepCommand.Text.Length > 0)
            {
                cmd.CommandText = "INSERT INTO Steps (Procedure_ID, Step_Number, Step_Text, Step_Command) " +
                                  "VALUES(@Procedure_ID, @Step_Number, @Step_Text, @Step_Command)";


                stepCmdParam.Value = txtStepCommand.Text;
                cmd.Parameters.Add(stepCmdParam);

            }
            else
            {
                cmd.CommandText = "INSERT INTO Steps (Procedure_ID, Step_Number, Step_Text) " +
                                  "VALUES(@Procedure_ID, @Step_Number, @Step_Text)";



            }

            procIdParam.Value = procID;
            stepNumParam.Value = Int32.Parse(txtStepNumber.Text);
            stepTxtParam.Value = txtStepText.Text;

            cmd.Parameters.Add(procIdParam);
            cmd.Parameters.Add(stepNumParam);
            cmd.Parameters.Add(stepTxtParam);

            con.Open();

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            con.Close();

            refreshTable();

            txtStepNumber.Text = null;
            txtStepText.Text = null;
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(null, con);
                cmd.CommandText = "DELETE FROM dbo.Steps WHERE Step_ID = @Step_ID";

                SqlParameter cmdTxtParam = new SqlParameter("@Step_ID", SqlDbType.Int, 0);
                cmdTxtParam.Value = dataGridView1.CurrentRow.Cells[3].Value;

                cmd.Parameters.Add(cmdTxtParam);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                refreshTable();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Unable to delete row.");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStepNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtStepText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStepCommand.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdateStep_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(null, con);
            SqlParameter stepNumParam = new SqlParameter("@Step_Number" , SqlDbType.Int , 0);
            SqlParameter stepIDParam  = new SqlParameter("@Step_ID"     , SqlDbType.Int , 0);
            SqlParameter stepTxtParam = new SqlParameter("@Step_Text"   , SqlDbType.Text, 1000);
            SqlParameter stepCmdParam = new SqlParameter("@Step_Command", SqlDbType.Text, 10000);

            cmd.CommandText = "UPDATE dbo.Steps SET Step_Number   = @Step_Number,  " +
                                                  " Step_Text     = @Step_Text,    " +
                                                  " Step_Command  = @Step_Command  " +
                                                  " WHERE Step_ID = @Step_ID       ";

            stepNumParam.Value = txtStepNumber.Text;
            stepIDParam.Value = dataGridView1.CurrentRow.Cells[3].Value;
            stepTxtParam.Value = txtStepText.Text;
            stepCmdParam.Value = txtStepCommand.Text;

            cmd.Parameters.Add(stepNumParam);
            cmd.Parameters.Add(stepIDParam);
            cmd.Parameters.Add(stepTxtParam);
            cmd.Parameters.Add(stepCmdParam);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            refreshTable();
        }
    }
}
