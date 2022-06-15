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
    public partial class UsuarisORM : Form
    {
        public UsuarisORM()
        {
            InitializeComponent();
        }

        private void UsuarisORM_Load(object sender, EventArgs e)
        {
            carregardades();
        }

        SecureCoreEntities db; 
        List<User> usuaris;
        bool esnou = false;

        private void carregardades()
        {

            db = new SecureCoreEntities();

            usuaris = db.Users.ToList();

            dtgUsuaris.DataSource = usuaris;

            ferbindings();

        }

        private void ferbindings()
        {

            foreach (Custom_Inherited_Controls.SWTextBox item in this.Controls.OfType<Custom_Inherited_Controls.SWTextBox>())
            {

                item.DataBindings.Clear();

                item.DataBindings.Add("text", usuaris, item.CampoDB);
            }

        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {

            if (esnou)
            {

                User usuario = new User()
                {
                    CodeUser = txtboxCodeUser.Text,
                    UserName = txtboxUsername.Text,
                    Login = txtboxLogin.Text,
                    Password = txtPassword.Text,
                    idUserRank = Int32.Parse(txtboxIdUserRank.Text),
                    idUserCategory = Int32.Parse(txtboxIdUserCategory.Text),
                    Photo = txtboxPhoto.Text,
                    idPlanet = Int32.Parse(txtBoxIdPlanet.Text),
                    idSpecie = Int32.Parse(txtBoxIdPlanet.Text)
                };

                db.Users.Add(usuario);

            }

            esnou = false;
            db.SaveChanges();

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
        }

        private void dtgUsuaris_KeyDown(object sender, KeyEventArgs e)
        {
            db = new SecureCoreEntities();

            if (e.KeyCode == Keys.Delete && dtgUsuaris.SelectedRows.Count == 1)
            {
                e.Handled = true;
                int valor = Int32.Parse(txtboxIdUser.Text);
                var proDel = db.Users.FirstOrDefault(x => x.idUser == valor);
                db.Users.Remove(proDel);
                db.SaveChanges();
            }

            carregardades();
        }
    }
}