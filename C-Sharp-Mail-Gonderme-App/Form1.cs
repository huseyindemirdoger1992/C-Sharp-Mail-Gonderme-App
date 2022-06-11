using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Sharp_Mail_Gonderme_App.Models;

namespace C_Sharp_Mail_Gonderme_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            txtDosya.Text = ofd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Microsoft")
            {
                SendMail sm = new SendMail();
                sm.Microsoft(txtAdSoyad.Text,txtGondericiMail.Text,txtGondericiPass.Text,txtAlici.Text,txtBaslik.Text,txticerik.Text,txtDosya.Text);
            }
        }
    }
}
