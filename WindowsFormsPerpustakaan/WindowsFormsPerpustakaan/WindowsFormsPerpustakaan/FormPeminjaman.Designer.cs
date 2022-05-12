
namespace WindowsFormsPerpustakaan
{
    partial class FormPeminjaman
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
            this.labelPeminjaman = new System.Windows.Forms.Label();
            this.groupBoxPeminjaman = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTanggalPeminjaman = new System.Windows.Forms.Label();
            this.labelKodeBuku = new System.Windows.Forms.Label();
            this.labelKodeAnggota = new System.Windows.Forms.Label();
            this.labelId_Peminjaman = new System.Windows.Forms.Label();
            this.groupBoxPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPeminjaman
            // 
            this.labelPeminjaman.AutoSize = true;
            this.labelPeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjaman.Location = new System.Drawing.Point(355, 25);
            this.labelPeminjaman.Name = "labelPeminjaman";
            this.labelPeminjaman.Size = new System.Drawing.Size(222, 18);
            this.labelPeminjaman.TabIndex = 2;
            this.labelPeminjaman.Text = "ENTRY DATA PEMINJAMAN";
            // 
            // groupBoxPeminjaman
            // 
            this.groupBoxPeminjaman.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPeminjaman.Controls.Add(this.buttonDelete);
            this.groupBoxPeminjaman.Controls.Add(this.buttonUpdate);
            this.groupBoxPeminjaman.Controls.Add(this.buttonSimpan);
            this.groupBoxPeminjaman.Controls.Add(this.dataGridView1);
            this.groupBoxPeminjaman.Controls.Add(this.textBox4);
            this.groupBoxPeminjaman.Controls.Add(this.textBox3);
            this.groupBoxPeminjaman.Controls.Add(this.textBox2);
            this.groupBoxPeminjaman.Controls.Add(this.textBox1);
            this.groupBoxPeminjaman.Controls.Add(this.labelTanggalPeminjaman);
            this.groupBoxPeminjaman.Controls.Add(this.labelKodeBuku);
            this.groupBoxPeminjaman.Controls.Add(this.labelKodeAnggota);
            this.groupBoxPeminjaman.Controls.Add(this.labelId_Peminjaman);
            this.groupBoxPeminjaman.Location = new System.Drawing.Point(25, 55);
            this.groupBoxPeminjaman.Name = "groupBoxPeminjaman";
            this.groupBoxPeminjaman.Size = new System.Drawing.Size(850, 366);
            this.groupBoxPeminjaman.TabIndex = 3;
            this.groupBoxPeminjaman.TabStop = false;
            this.groupBoxPeminjaman.Text = "Data Peminjaman";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(172, 154);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 32);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdate.Location = new System.Drawing.Point(91, 154);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 32);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSimpan.Location = new System.Drawing.Point(10, 154);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 32);
            this.buttonSimpan.TabIndex = 12;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 159);
            this.dataGridView1.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(691, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(691, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(691, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelTanggalPeminjaman
            // 
            this.labelTanggalPeminjaman.AutoSize = true;
            this.labelTanggalPeminjaman.Location = new System.Drawing.Point(9, 117);
            this.labelTanggalPeminjaman.Name = "labelTanggalPeminjaman";
            this.labelTanggalPeminjaman.Size = new System.Drawing.Size(106, 13);
            this.labelTanggalPeminjaman.TabIndex = 3;
            this.labelTanggalPeminjaman.Text = "Tanggal Peminjaman";
            // 
            // labelKodeBuku
            // 
            this.labelKodeBuku.AutoSize = true;
            this.labelKodeBuku.Location = new System.Drawing.Point(7, 91);
            this.labelKodeBuku.Name = "labelKodeBuku";
            this.labelKodeBuku.Size = new System.Drawing.Size(60, 13);
            this.labelKodeBuku.TabIndex = 2;
            this.labelKodeBuku.Text = "Kode Buku";
            // 
            // labelKodeAnggota
            // 
            this.labelKodeAnggota.AutoSize = true;
            this.labelKodeAnggota.Location = new System.Drawing.Point(7, 63);
            this.labelKodeAnggota.Name = "labelKodeAnggota";
            this.labelKodeAnggota.Size = new System.Drawing.Size(75, 13);
            this.labelKodeAnggota.TabIndex = 1;
            this.labelKodeAnggota.Text = "Kode Anggota";
            // 
            // labelId_Peminjaman
            // 
            this.labelId_Peminjaman.AutoSize = true;
            this.labelId_Peminjaman.Location = new System.Drawing.Point(7, 34);
            this.labelId_Peminjaman.Name = "labelId_Peminjaman";
            this.labelId_Peminjaman.Size = new System.Drawing.Size(79, 13);
            this.labelId_Peminjaman.TabIndex = 0;
            this.labelId_Peminjaman.Text = "Id_Peminjaman";
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 441);
            this.Controls.Add(this.groupBoxPeminjaman);
            this.Controls.Add(this.labelPeminjaman);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            this.groupBoxPeminjaman.ResumeLayout(false);
            this.groupBoxPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPeminjaman;
        private System.Windows.Forms.GroupBox groupBoxPeminjaman;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTanggalPeminjaman;
        private System.Windows.Forms.Label labelKodeBuku;
        private System.Windows.Forms.Label labelKodeAnggota;
        private System.Windows.Forms.Label labelId_Peminjaman;
    }
}