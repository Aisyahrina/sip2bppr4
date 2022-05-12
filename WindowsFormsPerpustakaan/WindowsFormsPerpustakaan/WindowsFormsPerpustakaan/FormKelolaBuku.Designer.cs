
namespace WindowsFormsPerpustakaan
{
    partial class FormKelolaBuku
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
            this.labelBuku = new System.Windows.Forms.Label();
            this.groupBoxAnggota = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelThnTerbit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.labelPengarang = new System.Windows.Forms.Label();
            this.labeljdlbuku = new System.Windows.Forms.Label();
            this.labelKodeBuku = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAnggota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuku
            // 
            this.labelBuku.AutoSize = true;
            this.labelBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuku.Location = new System.Drawing.Point(356, 18);
            this.labelBuku.Name = "labelBuku";
            this.labelBuku.Size = new System.Drawing.Size(161, 18);
            this.labelBuku.TabIndex = 1;
            this.labelBuku.Text = "ENTRY DATA BUKU";
            // 
            // groupBoxAnggota
            // 
            this.groupBoxAnggota.Controls.Add(this.buttonDelete);
            this.groupBoxAnggota.Controls.Add(this.buttonUpdate);
            this.groupBoxAnggota.Controls.Add(this.buttonSimpan);
            this.groupBoxAnggota.Controls.Add(this.textBox5);
            this.groupBoxAnggota.Controls.Add(this.labelThnTerbit);
            this.groupBoxAnggota.Controls.Add(this.dataGridView1);
            this.groupBoxAnggota.Controls.Add(this.textBox4);
            this.groupBoxAnggota.Controls.Add(this.textBox3);
            this.groupBoxAnggota.Controls.Add(this.textBox2);
            this.groupBoxAnggota.Controls.Add(this.textBox1);
            this.groupBoxAnggota.Controls.Add(this.labelPenerbit);
            this.groupBoxAnggota.Controls.Add(this.labelPengarang);
            this.groupBoxAnggota.Controls.Add(this.labeljdlbuku);
            this.groupBoxAnggota.Controls.Add(this.labelKodeBuku);
            this.groupBoxAnggota.Location = new System.Drawing.Point(25, 48);
            this.groupBoxAnggota.Name = "groupBoxAnggota";
            this.groupBoxAnggota.Size = new System.Drawing.Size(851, 371);
            this.groupBoxAnggota.TabIndex = 2;
            this.groupBoxAnggota.TabStop = false;
            this.groupBoxAnggota.Text = "Data Anggota";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(692, 20);
            this.textBox5.TabIndex = 10;
            // 
            // labelThnTerbit
            // 
            this.labelThnTerbit.AutoSize = true;
            this.labelThnTerbit.Location = new System.Drawing.Point(9, 144);
            this.labelThnTerbit.Name = "labelThnTerbit";
            this.labelThnTerbit.Size = new System.Drawing.Size(68, 13);
            this.labelThnTerbit.TabIndex = 9;
            this.labelThnTerbit.Text = "Tahun Terbit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 140);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(692, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(692, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(692, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(692, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Location = new System.Drawing.Point(9, 117);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(46, 13);
            this.labelPenerbit.TabIndex = 3;
            this.labelPenerbit.Text = "Penerbit";
            // 
            // labelPengarang
            // 
            this.labelPengarang.AutoSize = true;
            this.labelPengarang.Location = new System.Drawing.Point(7, 91);
            this.labelPengarang.Name = "labelPengarang";
            this.labelPengarang.Size = new System.Drawing.Size(59, 13);
            this.labelPengarang.TabIndex = 2;
            this.labelPengarang.Text = "Pengarang";
            // 
            // labeljdlbuku
            // 
            this.labeljdlbuku.AutoSize = true;
            this.labeljdlbuku.Location = new System.Drawing.Point(7, 63);
            this.labeljdlbuku.Name = "labeljdlbuku";
            this.labeljdlbuku.Size = new System.Drawing.Size(60, 13);
            this.labeljdlbuku.TabIndex = 1;
            this.labeljdlbuku.Text = "Judul Buku";
            // 
            // labelKodeBuku
            // 
            this.labelKodeBuku.AutoSize = true;
            this.labelKodeBuku.Location = new System.Drawing.Point(7, 34);
            this.labelKodeBuku.Name = "labelKodeBuku";
            this.labelKodeBuku.Size = new System.Drawing.Size(60, 13);
            this.labelKodeBuku.TabIndex = 0;
            this.labelKodeBuku.Text = "Kode Buku";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSimpan.Location = new System.Drawing.Point(12, 178);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 32);
            this.buttonSimpan.TabIndex = 11;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdate.Location = new System.Drawing.Point(93, 178);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 32);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(174, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 32);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // FormKelolaBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 441);
            this.Controls.Add(this.groupBoxAnggota);
            this.Controls.Add(this.labelBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaBuku";
            this.Text = "FormKelolaBuku";
            this.groupBoxAnggota.ResumeLayout(false);
            this.groupBoxAnggota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuku;
        private System.Windows.Forms.GroupBox groupBoxAnggota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.Label labelPengarang;
        private System.Windows.Forms.Label labeljdlbuku;
        private System.Windows.Forms.Label labelKodeBuku;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelThnTerbit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSimpan;
    }
}