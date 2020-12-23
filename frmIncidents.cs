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
    public partial class frmIncidents : Form
    {
        public frmIncidents()
        {
            InitializeComponent();
        }

        private void frmIncidents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'processesAndProcedures_DataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.processesAndProcedures_DataSet.Incidents);

        }
    }
}
