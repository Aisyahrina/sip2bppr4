
namespace WindowsFormsPerpustakaan
{
    partial class FormKelolaAnggota
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
            this.labelAnggota = new System.Windows.Forms.Label();
            this.groupBoxAnggota = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.labelNamaAnggota = new System.Windows.Forms.Label();
            this.labelKodeAnggota = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAnggota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAnggota
            // 
            this.labelAnggota.AutoSize = true;
            this.labelAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnggota.Location = new System.Drawing.Point(359, 20);
            this.labelAnggota.Name = "labelAnggota";
            this.labelAnggota.Size = new System.Drawing.Size(196, 18);
            this.labelAnggota.TabIndex = 0;
            this.labelAnggota.Text = "ENTRY DATA ANGGOTA";
            // 
            // groupBoxAnggota
            // 
            this.groupBoxAnggota.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAnggota.Controls.Add(this.buttonDelete);
            this.groupBoxAnggota.Controls.Add(this.buttonUpdate);
            this.groupBoxAnggota.Controls.Add(this.buttonSimpan);
            this.groupBoxAnggota.Controls.Add(this.dataGridView1);
            this.groupBoxAnggota.Controls.Add(this.textBox4);
            this.groupBoxAnggota.Controls.Add(this.textBox3);
            this.groupBoxAnggota.Controls.Add(this.textBox2);
            this.groupBoxAnggota.Controls.Add(this.textBox1);
            this.groupBoxAnggota.Controls.Add(this.labelAlamat);
            this.groupBoxAnggota.Controls.Add(this.labelKelas);
            this.groupBoxAnggota.Controls.Add(this.labelNamaAnggota);
            this.groupBoxAnggota.Controls.Add(this.labelKodeAnggota);
            this.groupBoxAnggota.Location = new System.Drawing.Point(24, 51);
            this.groupBoxAnggota.Name = "groupBoxAnggota";
            this.groupBoxAnggota.Size = new System.Drawing.Size(850, 366);
            this.groupBoxAnggota.TabIndex = 1;
            this.groupBoxAnggota.TabStop = false;
            this.groupBoxAnggota.Text = "Data Anggota";
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
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(9, 117);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(82, 13);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat Anggota";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Location = new System.Drawing.Point(7, 91);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(33, 13);
            this.labelKelas.TabIndex = 2;
            this.labelKelas.Text = "Kelas";
            // 
            // labelNamaAnggota
            // 
            this.labelNamaAnggota.AutoSize = true;
            this.labelNamaAnggota.Location = new System.Drawing.Point(7, 63);
            this.labelNamaAnggota.Name = "labelNamaAnggota";
            this.labelNamaAnggota.Size = new System.Drawing.Size(78, 13);
            this.labelNamaAnggota.TabIndex = 1;
            this.labelNamaAnggota.Text = "Nama Anggota";
            // 
            // labelKodeAnggota
            // 
            this.labelKodeAnggota.AutoSize = true;
            this.labelKodeAnggota.Location = new System.Drawing.Point(7, 34);
            this.labelKodeAnggota.Name = "labelKodeAnggota";
            this.labelKodeAnggota.Size = new System.Drawing.Size(75, 13);
            this.labelKodeAnggota.TabIndex = 0;
            this.labelKodeAnggota.Text = "Kode Anggota";
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
            // FormKelolaAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 441);
            this.Controls.Add(this.groupBoxAnggota);
            this.Controls.Add(this.labelAnggota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaAnggota";
            this.Text = "FormKelolaAnggota";
            this.groupBoxAnggota.ResumeLayout(false);
            this.groupBoxAnggota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnggota;
        private System.Windows.Forms.GroupBox groupBoxAnggota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.Label labelNamaAnggota;
        private System.Windows.Forms.Label labelKodeAnggota;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}