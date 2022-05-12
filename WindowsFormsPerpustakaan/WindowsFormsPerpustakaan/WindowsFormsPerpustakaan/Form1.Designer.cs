
namespace WindowsFormsPerpustakaan
{
    partial class Form1
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.tabPagePengembalian = new System.Windows.Forms.TabPage();
            this.tabPagePeminjaman = new System.Windows.Forms.TabPage();
            this.tabPageBuku = new System.Windows.Forms.TabPage();
            this.tabAnggota = new System.Windows.Forms.TabPage();
            this.panelContent = new System.Windows.Forms.TabPage();
            this.tabControlAnggota = new System.Windows.Forms.TabControl();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlAnggota.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(21, 15);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1047, 29);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Sistem Informasi Peminjaman dan Pengembalian Buku Perpustakaan SMA 13 Kota Jambi";
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // tabPagePengembalian
            // 
            this.tabPagePengembalian.Location = new System.Drawing.Point(4, 26);
            this.tabPagePengembalian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePengembalian.Name = "tabPagePengembalian";
            this.tabPagePengembalian.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePengembalian.Size = new System.Drawing.Size(1203, 545);
            this.tabPagePengembalian.TabIndex = 4;
            this.tabPagePengembalian.Text = "Pengembalian";
            this.tabPagePengembalian.UseVisualStyleBackColor = true;
            this.tabPagePengembalian.Click += new System.EventHandler(this.tabPagePengembalian_Click);
            // 
            // tabPagePeminjaman
            // 
            this.tabPagePeminjaman.Location = new System.Drawing.Point(4, 26);
            this.tabPagePeminjaman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePeminjaman.Name = "tabPagePeminjaman";
            this.tabPagePeminjaman.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePeminjaman.Size = new System.Drawing.Size(1203, 545);
            this.tabPagePeminjaman.TabIndex = 3;
            this.tabPagePeminjaman.Text = "Peminjaman";
            this.tabPagePeminjaman.UseVisualStyleBackColor = true;
            this.tabPagePeminjaman.Click += new System.EventHandler(this.tabPagePeminjaman_Click);
            // 
            // tabPageBuku
            // 
            this.tabPageBuku.Location = new System.Drawing.Point(4, 26);
            this.tabPageBuku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBuku.Name = "tabPageBuku";
            this.tabPageBuku.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBuku.Size = new System.Drawing.Size(1203, 545);
            this.tabPageBuku.TabIndex = 2;
            this.tabPageBuku.Text = "Kelola Buku";
            this.tabPageBuku.UseVisualStyleBackColor = true;
            this.tabPageBuku.Click += new System.EventHandler(this.tabPageBuku_Click);
            // 
            // tabAnggota
            // 
            this.tabAnggota.Location = new System.Drawing.Point(4, 26);
            this.tabAnggota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAnggota.Name = "tabAnggota";
            this.tabAnggota.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAnggota.Size = new System.Drawing.Size(1203, 545);
            this.tabAnggota.TabIndex = 1;
            this.tabAnggota.Text = "Kelola Anggota";
            this.tabAnggota.UseVisualStyleBackColor = true;
            this.tabAnggota.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panelContent
            // 
            this.panelContent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelContent.Location = new System.Drawing.Point(4, 26);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Size = new System.Drawing.Size(1203, 545);
            this.panelContent.TabIndex = 0;
            this.panelContent.Text = "Dashboard";
            this.panelContent.UseVisualStyleBackColor = true;
            this.panelContent.Click += new System.EventHandler(this.panelContent_Click);
            // 
            // tabControlAnggota
            // 
            this.tabControlAnggota.Controls.Add(this.panelContent);
            this.tabControlAnggota.Controls.Add(this.tabAnggota);
            this.tabControlAnggota.Controls.Add(this.tabPageBuku);
            this.tabControlAnggota.Controls.Add(this.tabPagePeminjaman);
            this.tabControlAnggota.Controls.Add(this.tabPagePengembalian);
            this.tabControlAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAnggota.Location = new System.Drawing.Point(31, 52);
            this.tabControlAnggota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlAnggota.Name = "tabControlAnggota";
            this.tabControlAnggota.SelectedIndex = 0;
            this.tabControlAnggota.Size = new System.Drawing.Size(1211, 575);
            this.tabControlAnggota.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightGray;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogout.Location = new System.Drawing.Point(1169, 44);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(67, 28);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1272, 656);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControlAnggota);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlAnggota.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TabPage tabPagePengembalian;
        private System.Windows.Forms.TabPage tabPagePeminjaman;
        private System.Windows.Forms.TabPage tabPageBuku;
        private System.Windows.Forms.TabPage tabAnggota;
        private System.Windows.Forms.TabPage panelContent;
        private System.Windows.Forms.TabControl tabControlAnggota;
        private System.Windows.Forms.Button buttonLogout;
    }
}

