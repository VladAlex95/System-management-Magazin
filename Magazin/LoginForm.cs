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

namespace Management_magazin
{
    public partial class LoginForm : Form
    {
        ConectareDB dBCon = new ConectareDB();
        public static string VanzatorNume;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Red;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Goldenrod;
        }

        private void clearLabel_MouseEnter(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.Red;
        }

        private void clearLabel_MouseLeave(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.Goldenrod;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginButon_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Va rog introduceti utilizator si parola", "Lipsa informatii", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (roleComboBox.SelectedIndex > -1)
                {
                    if (roleComboBox.SelectedItem.ToString() == "ADMIN")
                    {
                        if (usernameTextBox.Text == "Admin" && passwordTextBox.Text == "Admin123")
                        {
                            ProdusForm product = new ProdusForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Va rog introduceti utilizator si parola", "Lipsa Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM Vanzatori WHERE VanzatorNume='" + usernameTextBox.Text + "' AND VanzatorPass='" + passwordTextBox.Text + "'";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            VanzatorNume = usernameTextBox.Text;
                            VanzariForm selling = new VanzariForm();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("utilizator sau parola gresit", "Informatii gresite", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Va rog selectati rolul", "Informatii gresite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
