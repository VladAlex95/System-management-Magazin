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
    public partial class CategorieForm : Form
    {
        ConectareDB dBCon = new ConectareDB();
        DGVPrinter printer = new DGVPrinter();
        public CategorieForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT CatId , CatNume as Nume,CatDescriere as Descriere FROM CatProd";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_categorie.DataSource = table;
            DataGridView_categorie.Columns["CatId"].Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO CatProd VALUES( '" + TextBox_nume.Text + "', +'" + TextBox_descriere.Text + "')";

                SqlCommand command = new SqlCommand(insertQuery,dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Categorie adaugata cu succes","Adauga inf",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                Sterge();

            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategorieForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_nume.Text == "" || TextBox_descriere.Text == "")
                {
                    MessageBox.Show("Lipsesc informatii", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE CatProd SET CatNume='" + TextBox_nume.Text + "', CatDescriere='" + TextBox_descriere.Text + "'WHERE CatId=" + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Categorie actualizata cu succes", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DataGridView__categorie_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = DataGridView_categorie.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_nume.Text= DataGridView_categorie.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_descriere.Text= DataGridView_categorie.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Sterge()
        {
            TextBox_id.Clear();
            TextBox_nume.Clear();
            TextBox_descriere.Clear();
        }

        private void button_sterge_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM CatProd WHERE CatId=" + TextBox_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Categorie stearsa cu succes", "sterce informatia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                Sterge();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Red;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Goldenrod;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Goldenrod;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_produs_Click(object sender, EventArgs e)
        {
            ProdusForm product = new ProdusForm();
            product.Show();
            this.Hide();
        }

        private void buttonVanzator_Click(object sender, EventArgs e)
        {
            VanzatorForm vanzatori = new VanzatorForm();
            vanzatori.Show();
            this.Hide();
        }

        private void button_vanzator_Click(object sender, EventArgs e)
        {
            VanzariForm vanzari = new VanzariForm();
            vanzari.Show();
            this.Hide();
        }

        private void listeazacat_Click(object sender, EventArgs e)
        {
            printer.Title = "MAGAZIN Lista Categorii";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MAGAZIN Alex";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_categorie);
        }
    }
}
