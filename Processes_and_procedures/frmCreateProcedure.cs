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
    public partial class frmCreateProcedure : Form
    {
        public frmCreateProcedure()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProcessesAndProcedures_DataSet.ProceduresRow newProceduresRow;
            newProceduresRow = processesAndProcedures_DataSet1.Procedures.NewProceduresRow();
            newProceduresRow.Procedure_Name = txtCreateProcedure.Text;

            this.processesAndProcedures_DataSet1.Procedures.Rows.Add(newProceduresRow);

            this.proceduresTableAdapter1.Update(this.processesAndProcedures_DataSet1.Procedures);

            this.Close();
        }
    }
}
