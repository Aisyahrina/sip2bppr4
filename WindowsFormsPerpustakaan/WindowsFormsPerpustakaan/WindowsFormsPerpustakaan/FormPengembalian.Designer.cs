
namespace WindowsFormsPerpustakaan
{
    partial class FormPengembalian
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
            this.groupBoxPeminjaman = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNomorPengembalian = new System.Windows.Forms.Label();
            this.labelTanggalPengembalian = new System.Windows.Forms.Label();
            this.labelId_Pengembalian = new System.Windows.Forms.Label();
            this.labelPeminjaman = new System.Windows.Forms.Label();
            this.groupBoxPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPeminjaman
            // 
            this.groupBoxPeminjaman.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPeminjaman.Controls.Add(this.buttonDelete);
            this.groupBoxPeminjaman.Controls.Add(this.buttonUpdate);
            this.groupBoxPeminjaman.Controls.Add(this.buttonSimpan);
            this.groupBoxPeminjaman.Controls.Add(this.dataGridView1);
            this.groupBoxPeminjaman.Controls.Add(this.textBox3);
            this.groupBoxPeminjaman.Controls.Add(this.textBox2);
            this.groupBoxPeminjaman.Controls.Add(this.textBox1);
            this.groupBoxPeminjaman.Controls.Add(this.labelNomorPengembalian);
            this.groupBoxPeminjaman.Controls.Add(this.labelTanggalPengembalian);
            this.groupBoxPeminjaman.Controls.Add(this.labelId_Pengembalian);
            this.groupBoxPeminjaman.Location = new System.Drawing.Point(25, 67);
            this.groupBoxPeminjaman.Name = "groupBoxPeminjaman";
            this.groupBoxPeminjaman.Size = new System.Drawing.Size(850, 366);
            this.groupBoxPeminjaman.TabIndex = 4;
            this.groupBoxPeminjaman.TabStop = false;
            this.groupBoxPeminjaman.Text = "Data Pengembalian";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(174, 123);
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
            this.buttonUpdate.Location = new System.Drawing.Point(93, 123);
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
            this.buttonSimpan.Location = new System.Drawing.Point(12, 123);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 32);
            this.buttonSimpan.TabIndex = 12;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 191);
            this.dataGridView1.TabIndex = 8;
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
            // labelNomorPengembalian
            // 
            this.labelNomorPengembalian.AutoSize = true;
            this.labelNomorPengembalian.Location = new System.Drawing.Point(7, 91);
            this.labelNomorPengembalian.Name = "labelNomorPengembalian";
            this.labelNomorPengembalian.Size = new System.Drawing.Size(108, 13);
            this.labelNomorPengembalian.TabIndex = 2;
            this.labelNomorPengembalian.Text = "Nomor Pengembalian";
            // 
            // labelTanggalPengembalian
            // 
            this.labelTanggalPengembalian.AutoSize = true;
            this.labelTanggalPengembalian.Location = new System.Drawing.Point(7, 63);
            this.labelTanggalPengembalian.Name = "labelTanggalPengembalian";
            this.labelTanggalPengembalian.Size = new System.Drawing.Size(116, 13);
            this.labelTanggalPengembalian.TabIndex = 1;
            this.labelTanggalPengembalian.Text = "Tanggal Pengembalian";
            // 
            // labelId_Pengembalian
            // 
            this.labelId_Pengembalian.AutoSize = true;
            this.labelId_Pengembalian.Location = new System.Drawing.Point(7, 34);
            this.labelId_Pengembalian.Name = "labelId_Pengembalian";
            this.labelId_Pengembalian.Size = new System.Drawing.Size(89, 13);
            this.labelId_Pengembalian.TabIndex = 0;
            this.labelId_Pengembalian.Text = "Id_Pengembalian";
            // 
            // labelPeminjaman
            // 
            this.labelPeminjaman.AutoSize = true;
            this.labelPeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjaman.Location = new System.Drawing.Point(321, 32);
            this.labelPeminjaman.Name = "labelPeminjaman";
            this.labelPeminjaman.Size = new System.Drawing.Size(243, 18);
            this.labelPeminjaman.TabIndex = 5;
            this.labelPeminjaman.Text = "ENTRY DATA PENGEMBALIAN";
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 441);
            this.Controls.Add(this.labelPeminjaman);
            this.Controls.Add(this.groupBoxPeminjaman);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPengembalian";
            this.Text = "FormPengembalian";
            this.groupBoxPeminjaman.ResumeLayout(false);
            this.groupBoxPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeminjaman;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNomorPengembalian;
        private System.Windows.Forms.Label labelTanggalPengembalian;
        private System.Windows.Forms.Label labelId_Pengembalian;
        private System.Windows.Forms.Label labelPeminjaman;
    }
}