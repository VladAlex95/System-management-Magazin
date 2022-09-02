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
    public partial class ProdusForm : Form
    {
        ConectareDB dBCon = new ConectareDB();
        DGVPrinter printer = new DGVPrinter();
        public ProdusForm()
        {
            InitializeComponent();
        }

        private void button__categorie_Click(object sender, EventArgs e)
        {
            CategorieForm category = new CategorieForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();


        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM CatProd";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
             adapter.Fill(table);
            
            comboBox__categorie.DataSource = table;
           comboBox__categorie.ValueMember = "CatNume";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "CatNume";
        }

        private void getTable()
        {
            //string selectQuerry = "SELECT * FROM Produs";
            string selectQuerry = "SELECT ProdId,ProdNume as Nume,ProdPret as Pret,ProdCant as Cantitate,ProdCat as Categorie FROM Produs";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_produs.DataSource = table;
            dataGridView_produs.Columns["ProdId"].Visible = false;
        }

        private void Sterge()
        {
            TextBox_id.Clear();
            TextBox_nume.Clear();
            TextBox_pret.Clear();
            TextBox_cant.Clear();
            comboBox__categorie.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Produs (ProdNume,ProdPret,ProdCant,ProdCat) VALUES('" + TextBox_nume.Text + "', +'" + float.Parse(TextBox_pret.Text) + "', +'" + float.Parse(TextBox_cant.Text) + "', +'" + comboBox__categorie.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Produs adaugat cu succes", "Adauga informatii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                Sterge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_nume.Text == "" || TextBox_pret.Text == "" || TextBox_cant.Text == "")
                {
                    MessageBox.Show("Lipsesc informatii", "Lipsesc informatii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Produs SET ProdNume='" + TextBox_nume.Text + "',ProdPret=" + TextBox_pret.Text + ",ProdCant=" + TextBox_cant.Text + ",ProdCat='" + comboBox__categorie.Text + "'WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produs actualizat cu succes", "Inr updatata", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

     

        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_produs.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_nume.Text = dataGridView_produs.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_pret.Text = dataGridView_produs.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_cant.Text = dataGridView_produs.SelectedRows[0].Cells[3].Value.ToString();
            comboBox__categorie.SelectedValue = dataGridView_produs.SelectedRows[0].Cells[4].Value.ToString();
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
                    string deleteQuery = "DELETE FROM Produs WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produs sters cu succes", "art sters", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdId ,ProdNume as Nume,ProdPret as Pret,ProdCant as Cantitate,ProdCat as Categorie FROM Produs WHERE ProdCat='" + comboBox_search.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_produs.DataSource = table;
            dataGridView_produs.Columns["ProdId"].Visible = false;
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

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVanzator_Click(object sender, EventArgs e)
        {
           VanzatorForm vanzator = new VanzatorForm();
            vanzator.Show();
            this.Hide();
        }

        private void button_vanzator_Click(object sender, EventArgs e)
        {
            VanzariForm selling = new VanzariForm();
            selling.Show();
            this.Hide();
        }

        private void listaprod_Click(object sender, EventArgs e)
        {
            //We need DGVPrinter helper For PDF file
            printer.Title = "MAGAZIN Lista Produse";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MAGAZIN Alex";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_produs);
        }

        private void dataGridView_produs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
