using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritedControls
{
    public class DBTexBox : TextBox
    {

        public DBTexBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DBTexBox
            // 
            this.Enter += new System.EventHandler(this.DBTexBox_Enter);
            this.ResumeLayout(false);

        }

        private void DBTexBox_Enter(object sender, EventArgs e)
        {

        }


        private String _CampoDB;

        public String CampoDB
        {
            get { return _CampoDB; }
            set { _CampoDB = value; }
        }


    }
}
