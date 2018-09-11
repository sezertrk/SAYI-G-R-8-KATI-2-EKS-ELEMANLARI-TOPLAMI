using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAYI_GİR_8_KATI_2_EKSİĞİ_ELEMANLARI_TOPLAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 ilk = int.Parse(textBox1.Text);
            Int64 son = (ilk * 8) - 2;

            Int64 t = 0;


            for (Int64 i = ilk; i <= son; i++)
            {
                t = t + i;
            }
            textBox2 .Text = (t.ToString ());

        }
    }
}
