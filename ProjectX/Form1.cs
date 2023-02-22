using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Bat dau he ma Vigenere
        private void Vigenere_btnMahoa_Click(object sender, EventArgs e)
        {
           if (Vigenere_txtBanro.Text.Length != 0)
            {
                int[] arc = Vigenere.chuyenmakey(Vigenere_txtKhoaBanro.Text);
                int[] dongkhoa = Vigenere.taokhoa(Vigenere_txtBanro.Text, arc);
                //string result = (arr == null) ? null : arr.Skip(1).Aggregate(arr[0].ToString(), (s, i) => s + "," + i.ToString());
                Vigenere_txtBanma.Text = Vigenere.Mahoa(Vigenere_txtBanro.Text, dongkhoa);
            }
            else
            {
                MessageBox.Show("Xin lỗi, vui lòng không được để trống ô bản rõ.");return;
            }         
        }
        private void Vigenere_btnClear_Click(object sender, EventArgs e)
        {
            Vigenere_txtBanma.Text = "";
            Vigenere_txtKhoaBanro.Text = "";
            Vigenere_txtBanro.Text = "";
            Vigenere_txtKhoaBanma.Text = "";
        }       
        private void Vigenere_btnGiaima_Click(object sender, EventArgs e)
        {
            if (Vigenere_txtKhoaBanma.Text.Length != 0) { 
            int[] arc = Vigenere.chuyenmakey(Vigenere_txtKhoaBanma.Text);
            int[] dongkhoa = Vigenere.taokhoa(Vigenere_txtBanma.Text, arc);
            //string result = (arr == null) ? null : arr.Skip(1).Aggregate(arr[0].ToString(), (s, i) => s + "," + i.ToString());
            Vigenere_txtBanro.Text = Vigenere.Giaima(Vigenere_txtBanma.Text, dongkhoa);
        }
            else
            {
                MessageBox.Show("Xin lỗi, vui lòng không được để trống ô bản mã.");return;
            }
}

        private void Vigenere_btnChonfileBanro_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                Vigenere_txtBanro.Text = file.ReadToEnd();
                file.Close();
            }
        }
    
        private void Vigenere_btnChonFileBanma_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                Vigenere_txtBanma.Text = file.ReadToEnd();
                file.Close();
            }
        }

        private void Vigenere_btnChonKhoafileBanro_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                Vigenere_txtKhoaBanro.Text = file.ReadToEnd();
                file.Close();
            }
        }

        private void Vigenere_btnChonKhoaFileBanma_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                Vigenere_txtKhoaBanma.Text = file.ReadToEnd();
                file.Close();
            }
        }
        private void Vigenere_btnLuuFileBanro_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(Vigenere_txtBanma.Text);
                file.Close();
            }
        }

        private void Vigenere_btnLuuFileBanma_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(Vigenere_txtBanma.Text);
                file.Close();
            }
        }

        #endregion

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
