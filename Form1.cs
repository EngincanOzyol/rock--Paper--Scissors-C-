using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskagıtmakas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deger = 0;
        int sen ;
        int bot ;
        private void button6_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            deger = rn.Next(1, 4);
            if (deger == 1)
            {
                label1.Text = "beraberlik";
            }
            else if (deger == 2)
            {
                label1.Text = "kaybettiniz";
                bot++;
                label2.Text = bot.ToString();
            }
            else if (deger == 3)
            {
                label1.Text = "kazandınız";
                sen++;
                label3.Text = bot.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rn=new Random();
            deger = rn.Next(1, 4);
            if (deger == 1)
            {
                label1.Text = "beraberlik";
            }
            else if(deger == 2)
            {
                label1.Text = "kaybettiniz";
                bot++;
                label2.Text=bot.ToString();
            }
            else if (deger == 3)
            {
                label1.Text = "kazandınız";
                sen++;
                label3.Text=bot.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            deger = rn.Next(1, 4);
            if (deger == 1)
            {
                label1.Text = "beraberlik";
            }
            else if (deger == 2)
            {
                label1.Text = "kaybettiniz";
                bot++;
                label2.Text = bot.ToString();
            }
            else if (deger == 3)
            {
                label1.Text = "kazandınız";
                sen++;
                label3.Text = bot.ToString();
            }

        }
    }
}
