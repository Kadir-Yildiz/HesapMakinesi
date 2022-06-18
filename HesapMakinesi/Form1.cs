using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
            {
                txtSonuc.Clear();
            }
            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void DortIslem(object sender, EventArgs e)
        {
            optDurum= true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lblGecmis.Text = lblGecmis.Text+ " "+txtSonuc.Text+" "+yeniOpt;

            switch (opt)
            {
                case "+":
                    txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "X":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
            

        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblGecmis.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            lblGecmis.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "X":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void btnKaresi_Click(object sender, EventArgs e)
        {
            txtSonuc.Text= $"{txtSonuc.Text} x {txtSonuc.Text} = "+(Double.Parse(txtSonuc.Text)* Double.Parse(txtSonuc.Text)).ToString();

        }

        private void btnKarekoku_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = $"√{txtSonuc.Text} = "+Math.Sqrt(Double.Parse(txtSonuc.Text)).ToString();
        }

        

    }
}
