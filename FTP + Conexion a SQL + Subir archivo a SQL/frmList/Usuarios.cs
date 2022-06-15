using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace frmList
{
    public partial class Usuarios : DBPlantilla
    {

        public Usuarios()
        {
            InitializeComponent();
            this.tabla = "Users";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"..\frmList\UserReport.rpt");
            cryRpt.RecordSelectionFormula = "{Users.idUser} =" + txtboxid.Text;
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
