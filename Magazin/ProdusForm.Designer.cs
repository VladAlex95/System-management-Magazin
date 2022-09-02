using System.Windows.Forms;
namespace Management_magazin
{
    partial class ProdusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaprod = new System.Windows.Forms.Button();
            this.dataGridView_produs = new System.Windows.Forms.DataGridView();
            this.etProd = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.button_sterge = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_adauga = new System.Windows.Forms.Button();
            this.comboBox__categorie = new System.Windows.Forms.ComboBox();
            this.TextBox_pret = new System.Windows.Forms.TextBox();
            this.etCategorie = new System.Windows.Forms.Label();
            this.etPret = new System.Windows.Forms.Label();
            this.TextBox_cant = new System.Windows.Forms.TextBox();
            this.etCantitate = new System.Windows.Forms.Label();
            this.TextBox_nume = new System.Windows.Forms.TextBox();
            this.etNume = new System.Windows.Forms.Label();
            this.TextBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.buttonVanzator = new System.Windows.Forms.Button();
            this.button__categorie = new System.Windows.Forms.Button();
            this.button_vanzator = new System.Windows.Forms.Button();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.listaprod);
            this.panel1.Controls.Add(this.dataGridView_produs);
            this.panel1.Controls.Add(this.etProd);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.comboBox_search);
            this.panel1.Controls.Add(this.button_sterge);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_adauga);
            this.panel1.Controls.Add(this.comboBox__categorie);
            this.panel1.Controls.Add(this.TextBox_pret);
            this.panel1.Controls.Add(this.etCategorie);
            this.panel1.Controls.Add(this.etPret);
            this.panel1.Controls.Add(this.TextBox_cant);
            this.panel1.Controls.Add(this.etCantitate);
            this.panel1.Controls.Add(this.TextBox_nume);
            this.panel1.Controls.Add(this.etNume);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 608);
            this.panel1.TabIndex = 0;
            // 
            // listaprod
            // 
            this.listaprod.FlatAppearance.BorderSize = 0;
            this.listaprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaprod.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaprod.ForeColor = System.Drawing.Color.White;
            this.listaprod.Location = new System.Drawing.Point(88, 469);
            this.listaprod.Name = "listaprod";
            this.listaprod.Size = new System.Drawing.Size(143, 52);
            this.listaprod.TabIndex = 17;
            this.listaprod.Text = "ListareProduse";
            this.listaprod.UseVisualStyleBackColor = true;
            this.listaprod.Click += new System.EventHandler(this.listaprod_Click);
            // 
            // dataGridView_produs
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_produs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_produs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_produs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_produs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_produs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_produs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_produs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_produs.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_produs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_produs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_produs.EnableHeadersVisualStyles = false;
            this.dataGridView_produs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_produs.Location = new System.Drawing.Point(345, 102);
            this.dataGridView_produs.Name = "dataGridView_produs";
            this.dataGridView_produs.RowHeadersVisible = false;
            this.dataGridView_produs.RowHeadersWidth = 51;
            this.dataGridView_produs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_produs.Size = new System.Drawing.Size(571, 491);
            this.dataGridView_produs.TabIndex = 16;
            this.dataGridView_produs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produs_CellContentClick);
            this.dataGridView_produs.Click += new System.EventHandler(this.dataGridView_product_Click_1);
            // 
            // etProd
            // 
            this.etProd.AutoSize = true;
            this.etProd.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etProd.ForeColor = System.Drawing.Color.White;
            this.etProd.Location = new System.Drawing.Point(338, 0);
            this.etProd.Name = "etProd";
            this.etProd.Size = new System.Drawing.Size(390, 49);
            this.etProd.TabIndex = 15;
            this.etProd.Text = "ADMINISTRARE PRODUS";
            // 
            // button_Refresh
            // 
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_Refresh.Location = new System.Drawing.Point(743, 49);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(183, 44);
            this.button_Refresh.TabIndex = 14;
            this.button_Refresh.Text = "Improspatare";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox_search
            // 
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(519, 56);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(200, 37);
            this.comboBox_search.TabIndex = 13;
            this.comboBox_search.Text = "Select Categorie";
            this.comboBox_search.SelectionChangeCommitted += new System.EventHandler(this.comboBox_search_SelectionChangeCommitted);
            // 
            // button_sterge
            // 
            this.button_sterge.FlatAppearance.BorderSize = 0;
            this.button_sterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sterge.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sterge.ForeColor = System.Drawing.Color.White;
            this.button_sterge.Location = new System.Drawing.Point(251, 354);
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.Size = new System.Drawing.Size(88, 52);
            this.button_sterge.TabIndex = 11;
            this.button_sterge.Text = "Sterge";
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(101, 354);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(144, 52);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Actualizare";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_adauga
            // 
            this.button_adauga.FlatAppearance.BorderSize = 0;
            this.button_adauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adauga.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adauga.ForeColor = System.Drawing.Color.White;
            this.button_adauga.Location = new System.Drawing.Point(7, 354);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(88, 52);
            this.button_adauga.TabIndex = 11;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox__categorie
            // 
            this.comboBox__categorie.FormattingEnabled = true;
            this.comboBox__categorie.Location = new System.Drawing.Point(129, 286);
            this.comboBox__categorie.Name = "comboBox__categorie";
            this.comboBox__categorie.Size = new System.Drawing.Size(200, 37);
            this.comboBox__categorie.TabIndex = 10;
            this.comboBox__categorie.Text = "Select Categorie";
            // 
            // TextBox_pret
            // 
            this.TextBox_pret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pret.ForeColor = System.Drawing.Color.Black;
            this.TextBox_pret.Location = new System.Drawing.Point(128, 190);
            this.TextBox_pret.Name = "TextBox_pret";
            this.TextBox_pret.Size = new System.Drawing.Size(200, 27);
            this.TextBox_pret.TabIndex = 9;
            // 
            // etCategorie
            // 
            this.etCategorie.AutoSize = true;
            this.etCategorie.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCategorie.ForeColor = System.Drawing.Color.White;
            this.etCategorie.Location = new System.Drawing.Point(37, 282);
            this.etCategorie.Name = "etCategorie";
            this.etCategorie.Size = new System.Drawing.Size(111, 35);
            this.etCategorie.TabIndex = 8;
            this.etCategorie.Text = "Categorie";
            // 
            // etPret
            // 
            this.etPret.AutoSize = true;
            this.etPret.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPret.ForeColor = System.Drawing.Color.White;
            this.etPret.Location = new System.Drawing.Point(38, 194);
            this.etPret.Name = "etPret";
            this.etPret.Size = new System.Drawing.Size(57, 35);
            this.etPret.TabIndex = 6;
            this.etPret.Text = "Pret";
            // 
            // TextBox_cant
            // 
            this.TextBox_cant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_cant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_cant.ForeColor = System.Drawing.Color.Black;
            this.TextBox_cant.Location = new System.Drawing.Point(128, 234);
            this.TextBox_cant.Name = "TextBox_cant";
            this.TextBox_cant.Size = new System.Drawing.Size(200, 27);
            this.TextBox_cant.TabIndex = 5;
            // 
            // etCantitate
            // 
            this.etCantitate.AutoSize = true;
            this.etCantitate.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCantitate.ForeColor = System.Drawing.Color.White;
            this.etCantitate.Location = new System.Drawing.Point(38, 238);
            this.etCantitate.Name = "etCantitate";
            this.etCantitate.Size = new System.Drawing.Size(107, 35);
            this.etCantitate.TabIndex = 4;
            this.etCantitate.Text = "Cantitate";
            // 
            // TextBox_nume
            // 
            this.TextBox_nume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_nume.ForeColor = System.Drawing.Color.Black;
            this.TextBox_nume.Location = new System.Drawing.Point(128, 146);
            this.TextBox_nume.Name = "TextBox_nume";
            this.TextBox_nume.Size = new System.Drawing.Size(200, 27);
            this.TextBox_nume.TabIndex = 3;
            // 
            // etNume
            // 
            this.etNume.AutoSize = true;
            this.etNume.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNume.ForeColor = System.Drawing.Color.White;
            this.etNume.Location = new System.Drawing.Point(38, 150);
            this.etNume.Name = "etNume";
            this.etNume.Size = new System.Drawing.Size(75, 35);
            this.etNume.TabIndex = 2;
            this.etNume.Text = "Nume";
            // 
            // TextBox_id
            // 
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.Location = new System.Drawing.Point(128, 102);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.Size = new System.Drawing.Size(200, 27);
            this.TextBox_id.TabIndex = 1;
            this.TextBox_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.exitLabel.Location = new System.Drawing.Point(1074, -5);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(38, 41);
            this.exitLabel.TabIndex = 7;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // buttonVanzator
            // 
            this.buttonVanzator.FlatAppearance.BorderSize = 0;
            this.buttonVanzator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVanzator.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVanzator.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonVanzator.Location = new System.Drawing.Point(20, 35);
            this.buttonVanzator.Name = "buttonVanzator";
            this.buttonVanzator.Size = new System.Drawing.Size(121, 52);
            this.buttonVanzator.TabIndex = 12;
            this.buttonVanzator.Text = "Vanzator";
            this.buttonVanzator.UseVisualStyleBackColor = true;
            this.buttonVanzator.Click += new System.EventHandler(this.buttonVanzator_Click);
            // 
            // button__categorie
            // 
            this.button__categorie.FlatAppearance.BorderSize = 0;
            this.button__categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__categorie.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button__categorie.ForeColor = System.Drawing.Color.Goldenrod;
            this.button__categorie.Location = new System.Drawing.Point(20, 114);
            this.button__categorie.Name = "button__categorie";
            this.button__categorie.Size = new System.Drawing.Size(121, 52);
            this.button__categorie.TabIndex = 12;
            this.button__categorie.Text = "Categorie";
            this.button__categorie.UseVisualStyleBackColor = true;
            this.button__categorie.Click += new System.EventHandler(this.button__categorie_Click);
            // 
            // button_vanzator
            // 
            this.button_vanzator.FlatAppearance.BorderSize = 0;
            this.button_vanzator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vanzator.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vanzator.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_vanzator.Location = new System.Drawing.Point(20, 193);
            this.button_vanzator.Name = "button_vanzator";
            this.button_vanzator.Size = new System.Drawing.Size(121, 52);
            this.button_vanzator.TabIndex = 12;
            this.button_vanzator.Text = "Vanzari";
            this.button_vanzator.UseVisualStyleBackColor = true;
            this.button_vanzator.Click += new System.EventHandler(this.button_vanzator_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(32, 603);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(118, 41);
            this.label_logout.TabIndex = 20;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // ProdusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_vanzator);
            this.Controls.Add(this.button__categorie);
            this.Controls.Add(this.buttonVanzator);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProdusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdusForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private  System.Windows.Forms.TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label etCategorie;
        private System.Windows.Forms.Label etPret;
        private System.Windows.Forms.TextBox TextBox_cant;
        private System.Windows.Forms.Label etCantitate;
        private System.Windows.Forms.TextBox TextBox_nume;
        private System.Windows.Forms.Label etNume;
        private System.Windows.Forms.ComboBox comboBox__categorie;
        private  System.Windows.Forms.TextBox TextBox_pret;
        private System.Windows.Forms.Button button_adauga;
        private System.Windows.Forms.Label etProd;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.Button button_sterge;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button buttonVanzator;
        private System.Windows.Forms.Button button__categorie;
        private System.Windows.Forms.Button button_vanzator;
        private System.Windows.Forms.DataGridView dataGridView_produs;
        private System.Windows.Forms.Label label_logout;
        private Button listaprod;
    }
}