
namespace Management_magazin
{
    partial class VanzatorForm
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
            this.label_logout = new System.Windows.Forms.Label();
            this.dataGridViewVanzator = new System.Windows.Forms.DataGridView();
            this.etVanzator = new System.Windows.Forms.Label();
            this.button_sterge = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_adauga = new System.Windows.Forms.Button();
            this.TextBox_varsta = new System.Windows.Forms.TextBox();
            this.button_Produs = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listeaza_vanz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_parola = new System.Windows.Forms.TextBox();
            this.etPass = new System.Windows.Forms.Label();
            this.TextBox_tel = new System.Windows.Forms.TextBox();
            this.etTel = new System.Windows.Forms.Label();
            this.TextBox_nume = new System.Windows.Forms.TextBox();
            this.etNume = new System.Windows.Forms.Label();
            this.TextBox_id = new System.Windows.Forms.TextBox();
            this.etichetaID = new System.Windows.Forms.Label();
            this.button_vanzari = new System.Windows.Forms.Button();
            this.button__categorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVanzator)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(27, 753);
            this.label_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(118, 41);
            this.label_logout.TabIndex = 26;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // dataGridViewVanzator
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewVanzator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVanzator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVanzator.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVanzator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVanzator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewVanzator.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVanzator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewVanzator.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVanzator.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVanzator.EnableHeadersVisualStyles = false;
            this.dataGridViewVanzator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewVanzator.Location = new System.Drawing.Point(460, 126);
            this.dataGridViewVanzator.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVanzator.Name = "dataGridViewVanzator";
            this.dataGridViewVanzator.RowHeadersVisible = false;
            this.dataGridViewVanzator.RowHeadersWidth = 51;
            this.dataGridViewVanzator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVanzator.Size = new System.Drawing.Size(761, 604);
            this.dataGridViewVanzator.TabIndex = 16;
            this.dataGridViewVanzator.Click += new System.EventHandler(this.dataGridViewVanzator_Click);
            // 
            // etVanzator
            // 
            this.etVanzator.AutoSize = true;
            this.etVanzator.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etVanzator.ForeColor = System.Drawing.Color.White;
            this.etVanzator.Location = new System.Drawing.Point(477, 0);
            this.etVanzator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etVanzator.Name = "etVanzator";
            this.etVanzator.Size = new System.Drawing.Size(367, 49);
            this.etVanzator.TabIndex = 15;
            this.etVanzator.Text = " Administrare Vanzatori";
            // 
            // button_sterge
            // 
            this.button_sterge.FlatAppearance.BorderSize = 0;
            this.button_sterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sterge.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sterge.ForeColor = System.Drawing.Color.White;
            this.button_sterge.Location = new System.Drawing.Point(317, 421);
            this.button_sterge.Margin = new System.Windows.Forms.Padding(4);
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.Size = new System.Drawing.Size(117, 64);
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
            this.button_update.Location = new System.Drawing.Point(171, 431);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(163, 44);
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
            this.button_adauga.Location = new System.Drawing.Point(45, 421);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(4);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(117, 64);
            this.button_adauga.TabIndex = 11;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_add_Click);
            // 
            // TextBox_varsta
            // 
            this.TextBox_varsta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_varsta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_varsta.ForeColor = System.Drawing.Color.Black;
            this.TextBox_varsta.Location = new System.Drawing.Point(171, 234);
            this.TextBox_varsta.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_varsta.Name = "TextBox_varsta";
            this.TextBox_varsta.Size = new System.Drawing.Size(265, 27);
            this.TextBox_varsta.TabIndex = 9;
            // 
            // button_Produs
            // 
            this.button_Produs.FlatAppearance.BorderSize = 0;
            this.button_Produs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Produs.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Produs.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_Produs.Location = new System.Drawing.Point(11, 54);
            this.button_Produs.Margin = new System.Windows.Forms.Padding(4);
            this.button_Produs.Name = "button_Produs";
            this.button_Produs.Size = new System.Drawing.Size(161, 64);
            this.button_Produs.TabIndex = 23;
            this.button_Produs.Text = "Produs";
            this.button_Produs.UseVisualStyleBackColor = true;
            this.button_Produs.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.exitLabel.Location = new System.Drawing.Point(1416, 5);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(38, 41);
            this.exitLabel.TabIndex = 22;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.listeaza_vanz);
            this.panel1.Controls.Add(this.dataGridViewVanzator);
            this.panel1.Controls.Add(this.etVanzator);
            this.panel1.Controls.Add(this.button_sterge);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_adauga);
            this.panel1.Controls.Add(this.TextBox_varsta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_parola);
            this.panel1.Controls.Add(this.etPass);
            this.panel1.Controls.Add(this.TextBox_tel);
            this.panel1.Controls.Add(this.etTel);
            this.panel1.Controls.Add(this.TextBox_nume);
            this.panel1.Controls.Add(this.etNume);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.etichetaID);
            this.panel1.Location = new System.Drawing.Point(196, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 748);
            this.panel1.TabIndex = 21;
            // 
            // listeaza_vanz
            // 
            this.listeaza_vanz.FlatAppearance.BorderSize = 0;
            this.listeaza_vanz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeaza_vanz.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeaza_vanz.ForeColor = System.Drawing.Color.White;
            this.listeaza_vanz.Location = new System.Drawing.Point(100, 585);
            this.listeaza_vanz.Margin = new System.Windows.Forms.Padding(4);
            this.listeaza_vanz.Name = "listeaza_vanz";
            this.listeaza_vanz.Size = new System.Drawing.Size(219, 64);
            this.listeaza_vanz.TabIndex = 22;
            this.listeaza_vanz.Text = "ListeazaVanzatori";
            this.listeaza_vanz.UseVisualStyleBackColor = true;
            this.listeaza_vanz.Click += new System.EventHandler(this.listeaza_vanz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Varsta";
            // 
            // TextBox_parola
            // 
            this.TextBox_parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_parola.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_parola.ForeColor = System.Drawing.Color.Black;
            this.TextBox_parola.Location = new System.Drawing.Point(171, 342);
            this.TextBox_parola.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_parola.Name = "TextBox_parola";
            this.TextBox_parola.Size = new System.Drawing.Size(265, 27);
            this.TextBox_parola.TabIndex = 5;
            this.TextBox_parola.UseSystemPasswordChar = true;
            // 
            // etPass
            // 
            this.etPass.AutoSize = true;
            this.etPass.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPass.ForeColor = System.Drawing.Color.White;
            this.etPass.Location = new System.Drawing.Point(48, 347);
            this.etPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etPass.Name = "etPass";
            this.etPass.Size = new System.Drawing.Size(80, 35);
            this.etPass.TabIndex = 4;
            this.etPass.Text = "Parola";
            // 
            // TextBox_tel
            // 
            this.TextBox_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_tel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_tel.ForeColor = System.Drawing.Color.Black;
            this.TextBox_tel.Location = new System.Drawing.Point(171, 288);
            this.TextBox_tel.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_tel.Name = "TextBox_tel";
            this.TextBox_tel.Size = new System.Drawing.Size(265, 27);
            this.TextBox_tel.TabIndex = 5;
            // 
            // etTel
            // 
            this.etTel.AutoSize = true;
            this.etTel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTel.ForeColor = System.Drawing.Color.White;
            this.etTel.Location = new System.Drawing.Point(51, 293);
            this.etTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etTel.Name = "etTel";
            this.etTel.Size = new System.Drawing.Size(89, 35);
            this.etTel.TabIndex = 4;
            this.etTel.Text = "Telefon";
            // 
            // TextBox_nume
            // 
            this.TextBox_nume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_nume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_nume.ForeColor = System.Drawing.Color.Black;
            this.TextBox_nume.Location = new System.Drawing.Point(171, 180);
            this.TextBox_nume.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_nume.Name = "TextBox_nume";
            this.TextBox_nume.Size = new System.Drawing.Size(265, 27);
            this.TextBox_nume.TabIndex = 3;
            // 
            // etNume
            // 
            this.etNume.AutoSize = true;
            this.etNume.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNume.ForeColor = System.Drawing.Color.White;
            this.etNume.Location = new System.Drawing.Point(51, 185);
            this.etNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.TextBox_id.Location = new System.Drawing.Point(171, 126);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.Size = new System.Drawing.Size(265, 27);
            this.TextBox_id.TabIndex = 1;
            this.TextBox_id.Visible = false;
            // 
            // etichetaID
            // 
            this.etichetaID.AutoSize = true;
            this.etichetaID.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etichetaID.ForeColor = System.Drawing.Color.White;
            this.etichetaID.Location = new System.Drawing.Point(51, 130);
            this.etichetaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etichetaID.Name = "etichetaID";
            this.etichetaID.Size = new System.Drawing.Size(39, 35);
            this.etichetaID.TabIndex = 0;
            this.etichetaID.Text = "ID";
            this.etichetaID.Visible = false;
            // 
            // button_vanzari
            // 
            this.button_vanzari.FlatAppearance.BorderSize = 0;
            this.button_vanzari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vanzari.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vanzari.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_vanzari.Location = new System.Drawing.Point(11, 249);
            this.button_vanzari.Margin = new System.Windows.Forms.Padding(4);
            this.button_vanzari.Name = "button_vanzari";
            this.button_vanzari.Size = new System.Drawing.Size(161, 64);
            this.button_vanzari.TabIndex = 24;
            this.button_vanzari.Text = "Vanzari";
            this.button_vanzari.UseVisualStyleBackColor = true;
            this.button_vanzari.Click += new System.EventHandler(this.button_vanzator_Click);
            // 
            // button__categorie
            // 
            this.button__categorie.FlatAppearance.BorderSize = 0;
            this.button__categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__categorie.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button__categorie.ForeColor = System.Drawing.Color.Goldenrod;
            this.button__categorie.Location = new System.Drawing.Point(11, 151);
            this.button__categorie.Margin = new System.Windows.Forms.Padding(4);
            this.button__categorie.Name = "button__categorie";
            this.button__categorie.Size = new System.Drawing.Size(161, 64);
            this.button__categorie.TabIndex = 25;
            this.button__categorie.Text = "Categorie";
            this.button__categorie.UseVisualStyleBackColor = true;
            this.button__categorie.Click += new System.EventHandler(this.button_categorie_Click);
            // 
            // VanzatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 800);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_Produs);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_vanzari);
            this.Controls.Add(this.button__categorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VanzatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VanzatorForm";
            this.Load += new System.EventHandler(this.VanzatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVanzator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.DataGridView dataGridViewVanzator;
        private System.Windows.Forms.Label etVanzator;
        private System.Windows.Forms.Button button_sterge;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_adauga;
        private System.Windows.Forms.TextBox TextBox_varsta;
        private System.Windows.Forms.Button button_Produs;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_tel;
        private System.Windows.Forms.Label etTel;
        private System.Windows.Forms.TextBox TextBox_nume;
        private System.Windows.Forms.Label etNume;
        private System.Windows.Forms.TextBox TextBox_id;
        private System.Windows.Forms.Label etichetaID;
        private System.Windows.Forms.Button button_vanzari;
        private System.Windows.Forms.Button button__categorie;
        private System.Windows.Forms.TextBox TextBox_parola;
        private System.Windows.Forms.Label etPass;
        private System.Windows.Forms.Button listeaza_vanz;
    }
}