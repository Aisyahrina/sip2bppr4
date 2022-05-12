using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPerpustakaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormDashboard frmdashboard = new FormDashboard();
            frmdashboard.TopLevel = false;
            frmdashboard.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(frmdashboard);
            frmdashboard.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            FormKelolaAnggota frmanggota = new FormKelolaAnggota();
            frmanggota.TopLevel = false;
            frmanggota.AutoScroll = true;
            this.tabAnggota.Controls.Clear();
            this.tabAnggota.Controls.Add(frmanggota);
            frmanggota.Show();
        }

        private void panelContent_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPageBuku_Click(object sender, EventArgs e)
        {
            FormKelolaBuku frmBuku = new FormKelolaBuku();
            frmBuku.TopLevel = false;
            frmBuku.AutoScroll = true;
            this.tabPageBuku.Controls.Clear();
            this.tabPageBuku.Controls.Add(frmBuku);
            frmBuku.Show();
        }

        private void tabPagePeminjaman_Click(object sender, EventArgs e)
        {
            FormPeminjaman frmPeminjaman = new FormPeminjaman();
            frmPeminjaman.TopLevel = false;
            frmPeminjaman.AutoScroll = true;
            this.tabPagePeminjaman.Controls.Clear();
            this.tabPagePeminjaman.Controls.Add(frmPeminjaman);
            frmPeminjaman.Show();
        }

        private void tabPagePengembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian frmPengembalian = new FormPengembalian();
            frmPengembalian.TopLevel = false;
            frmPengembalian.AutoScroll = true;
            this.tabPagePengembalian.Controls.Clear();
            this.tabPagePengembalian.Controls.Add(frmPengembalian);
            frmPengembalian.Show();
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
