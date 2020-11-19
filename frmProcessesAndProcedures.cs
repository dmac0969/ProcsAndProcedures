using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes_and_procedures
{
    public partial class frmProcessesAndProcedures : Form
    {
        public frmProcessesAndProcedures()
        {
            InitializeComponent();
        }

        private void frmProcessesAndProcedures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'processesAndProcedures_DataSet.Procedures' table. You can move, or remove it, as needed.
            this.proceduresTableAdapter.Fill(this.processesAndProcedures_DataSet.Procedures);

        }

        private void btnCreateProcedure_Click(object sender, EventArgs e)
        {
            frmCreateProcedure form1 = new frmCreateProcedure();

            form1.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.proceduresTableAdapter.Fill(this.processesAndProcedures_DataSet.Procedures);
        }

        private void btnDeleteProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the 'Delete1' ProcedureTableAdapter query.
                this.proceduresTableAdapter.DeleteProcedure(Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                // 'Refresh' the procedures table
                this.proceduresTableAdapter.Fill(this.processesAndProcedures_DataSet.Procedures);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No more columns to delete.");
            }
        }

        private void btnViewProcedure_Click(object sender, EventArgs e)
        {

            System.Data.DataRowView SelectedRowView;
            ProcessesAndProcedures_DataSet.ProceduresRow SelectedRow;

            SelectedRowView = (System.Data.DataRowView)proceduresBindingSource.Current;
            SelectedRow = (ProcessesAndProcedures_DataSet.ProceduresRow)SelectedRowView.Row;

            frmViewSteps stepsForm = new frmViewSteps(dataGridView1.CurrentRow.Cells[1].Value.ToString(), Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            stepsForm.LoadProcedures(SelectedRow.Procedure_ID);
            stepsForm.Show();
            
        }
    }
}
