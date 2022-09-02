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
    public partial class VanzariForm : Form
    {
        ConectareDB dBCon = new ConectareDB();
        DGVPrinter printer = new DGVPrinter();
        public VanzariForm()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM CatProd";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_categorie.DataSource = table;
            comboBox_categorie.ValueMember = "CatNume";
            
        }

        private void getTable()
        {
            string selectQuerry = "SELECT ProdNume as Nume, ProdPret as Pret FROM Produs";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_produs.DataSource = table;
        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT Id,VanzatorNume as Nume,DataVanzare as Data,Total FROM Vanzari";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_lista_vanzari.DataSource = table;
            DataGridView_lista_vanzari.Columns["Id"].Visible = false;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_data.Text = DateTime.Today.ToShortDateString();
            label_vanzator.Text = LoginForm.VanzatorNume;
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_nume.Text = DataGridView_produs.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_pret.Text = DataGridView_produs.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, n = 0;

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Vanzari VALUES( '" + label_vanzator.Text + "', +'" + label_data.Text + "', +'" + grandTotal.ToString() + "')";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Vanzare adaugata cu succes", "inf vanzare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (DataGridViewRow row in dataGridView_order.SelectedRows)
            {
                dataGridView_order.Rows.RemoveAt(row.Index);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVPrinter helper For PDF file
            printer.Title = "MAGAZIN Lista de Vanzari";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MAGAZIN Alex";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_lista_vanzari);
            
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox__categorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdNume as Nume, ProdPret as Pret FROM Produs WHERE ProdCat='" + comboBox_categorie.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_produs.DataSource = table;
        }

       

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_nume.Text == "" || TextBox_cantitate.Text == "")
            {
                MessageBox.Show("Lipssc informatii", "Informatie eronata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(TextBox_pret.Text) * Convert.ToInt32(TextBox_cantitate.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_nume.Text;
                addRow.Cells[2].Value = TextBox_pret.Text;
                addRow.Cells[3].Value = TextBox_cantitate.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_amount.Text = grandTotal + " LEI";
            }
        }

        private void listeazacurent_Click(object sender, EventArgs e)
        {
            DGVPrinter printer1 = new DGVPrinter();
            //We need DGVPrinter helper For PDF file
            printer1.Title = "MAGAZIN Lista de Vanzare Curenta";
            printer1.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer1.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer1.PageNumbers = true;
            printer1.PageNumberInHeader = false;
            printer1.PorportionalColumns = true;
            printer1.HeaderCellAlignment = StringAlignment.Near;
            printer1.Footer = "MAGAZIN Alex";
            printer1.FooterSpacing = 15;
            printer1.printDocument.DefaultPageSettings.Landscape = true;
            printer1.PrintDataGridView(dataGridView_order);
           
        }

        private void button_Produs_Click(object sender, EventArgs e)
        {
            ProdusForm product = new ProdusForm();
            product.Show();
            this.Hide();
        }

        private void button__categorie_Click(object sender, EventArgs e)
        {

            CategorieForm category = new CategorieForm();
            category.Show();
            this.Hide();
        }

        private void button_stlv_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView_lista_vanzari.SelectedRows)
            {
                DataGridView_lista_vanzari.Rows.RemoveAt(row.Index);
            }


        }

        private void comboBox_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_vanzari_Click(object sender, EventArgs e)
        {
            VanzatorForm vanzator = new VanzatorForm();
            vanzator.Show();
            this.Hide();
        }

        
        
    }
}
