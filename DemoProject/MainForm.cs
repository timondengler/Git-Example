using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        private Random rnd = new Random();
        int Counter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }



        private void btnCounter_Click(object sender, EventArgs e)
        {
            Counter++;
            lblCounter.Text = ""+ Counter;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            btnColor.BackColor = randomColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimon_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }
    }
}
