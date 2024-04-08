using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace homework_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Конвертор на валути";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string selected = comboBox_currency.SelectedItem.ToString();
            txt_EUR.Text = selected;

            switch (selected)
            {
                case "BGN":
                    txt_BGN.Text = txt_amount.Text;
                    txt_EUR.Text = (int.Parse(txt_amount.Text) * 1.956).ToString();
                    txt_USD.Text = (int.Parse(txt_amount.Text) * 1.758).ToString();
                    txt_GBR.Text = (int.Parse(txt_amount.Text) * 2.313).ToString();
                    break;
                case "EUR":
                    txt_BGN.Text = (int.Parse(txt_amount.Text) * 0.511).ToString();
                    txt_EUR.Text = txt_amount.Text;
                    txt_USD.Text = (int.Parse(txt_amount.Text) * 0.883).ToString();
                    txt_GBR.Text = (int.Parse(txt_amount.Text) * 1.160).ToString();
                    break;
                case "USD":
                    txt_BGN.Text = (int.Parse(txt_amount.Text) * 0.563).ToString();
                    txt_EUR.Text = (int.Parse(txt_amount.Text) * 1.097).ToString();
                    txt_USD.Text = txt_amount.Text;
                    txt_GBR.Text = (int.Parse(txt_amount.Text) * 1.278).ToString();
                    break;
                case "GBR":
                    txt_BGN.Text = (int.Parse(txt_amount.Text) * 0.428).ToString();
                    txt_EUR.Text = (int.Parse(txt_amount.Text) * 0.834).ToString();
                    txt_USD.Text = (int.Parse(txt_amount.Text) * 0.739).ToString();
                    txt_GBR.Text = txt_amount.Text;
                    break;
                default:
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_BGN.Text = "";
            txt_EUR.Text = "";
            txt_USD.Text = "";
            txt_GBR.Text = "";
            comboBox_currency.Items.Clear();
        }
    }
}
