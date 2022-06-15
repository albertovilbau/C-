using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmList
{
    public partial class CategoriesUsuaris : Form
    {
        public CategoriesUsuaris()
        {
            InitializeComponent();
        }

        private void CategoriesUsuaris_Load(object sender, EventArgs e)
        {
            carregardades();
        }

        SecureCoreEntities db;
        List<UserCategory> categories;
        bool esnou = false;

        private void carregardades()
        {

            db = new SecureCoreEntities();

            categories = db.UserCategories.ToList();

            dtgCategoriesUsuaris.DataSource = categories;

            ferbindings();

        }

        private void ferbindings()
        {
            foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
            {

                item.DataBindings.Clear();

                item.DataBindings.Add("text", categories, item.CampoDB);
            }
        }


        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (esnou)
            {
                UserCategory categoria = new UserCategory()
                {
                    CodeCategory = txtboxCodeCategory.Text,
                    DescCategory = txtboxDescCategory.Text,
                    AccessLevel = Int32.Parse(txtboxAccesLevel.Text)
                };

                db.UserCategories.Add(categoria);
                txtboxIDuserCategory.Enabled = true;
            }

            db.SaveChanges();
            esnou = false;
            carregardades();
            
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            esnou = true;

            foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
            {
                item.DataBindings.Clear();
                item.Text = "";
            }

            txtboxIDuserCategory.Enabled = false;

        }

        private void dtgCategoriesUsuaris_KeyDown(object sender, KeyEventArgs e)
        {
            db = new SecureCoreEntities();
            
            if (e.KeyCode == Keys.Delete && dtgCategoriesUsuaris.SelectedRows.Count == 1)
            {
                e.Handled = true;
                int valor = Int32.Parse(txtboxIDuserCategory.Text);
                var proDel = db.UserCategories.FirstOrDefault(x => x.idUserCategory == valor);
                db.UserCategories.Remove(proDel);
                db.SaveChanges();
            }

            carregardades();

        }
    }
}
