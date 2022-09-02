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
using DGVPrinterHelper;


namespace Management_magazin
{
    public partial class VanzatorForm : Form
    {
        ConectareDB dBCon = new ConectareDB();
        DGVPrinter printer = new DGVPrinter();
        public VanzatorForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT VanzatorId,VanzatorNume as Nume,VanzatorVarsta as Varsta,Telefon,VanzatorPass as Parola FROM Vanzatori";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewVanzator.DataSource = table;
            dataGridViewVanzator.Columns["VanzatorId"].Visible = false;
        }

        private void Sterge()
        {
            TextBox_id.Clear();
            TextBox_nume.Clear();
            TextBox_varsta.Clear();
            TextBox_tel.Clear();
            TextBox_parola.Clear();
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Vanzatori VALUES( '" + TextBox_nume.Text + "', +'" + TextBox_varsta.Text + "', +'" + TextBox_tel.Text + "', +'" + TextBox_parola.Text + "')";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Vanzator adaugat cu succes", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                Sterge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VanzatorForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_nume.Text == "" || TextBox_varsta.Text == "" || TextBox_tel.Text == ""||TextBox_parola.Text=="")
                {
                    MessageBox.Show("Lipsesc informatii", "Lipsesc informatii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Vanzatori SET VanzatorNume='" + TextBox_nume.Text + "',VanzatorVarsta='" + TextBox_varsta.Text + "',Telefon='" + TextBox_tel.Text + "',Vanzatorpass='" + TextBox_parola.Text + "'WHERE VanzatorId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vanzator Actualizat cu succes", "Update informatia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    Sterge();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewVanzator_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridViewVanzator.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_nume.Text = dataGridViewVanzator.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_varsta.Text= dataGridViewVanzator.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_tel.Text= dataGridViewVanzator.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_parola.Text = dataGridViewVanzator.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Lipsesc informatii", "Lipsesc informatii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Sunteti sigur ca vreti sa stergeti inregistrarea?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    { string deleteQuery = "DELETE FROM Vanzatori WHERE VanzatorId=" + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Vanzator sters cu succes", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        Sterge();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Goldenrod;
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Red;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Goldenrod;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProdusForm product = new ProdusForm();
            product.Show();
            this.Hide();
        }

        private void button_categorie_Click(object sender, EventArgs e)
        {
            CategorieForm category = new CategorieForm();
            category.Show();
            this.Hide();
        }

        private void button_vanzator_Click(object sender, EventArgs e)
        {
            VanzariForm vanzari = new VanzariForm();
            vanzari.Show();
            this.Hide();
        }

        private void listeaza_vanz_Click(object sender, EventArgs e)
        {
            printer.Title = "MAGAZIN Lista Vanzatori";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MAGAZIN Alex";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridViewVanzator);

        }
    }
}
