using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarManage.UI.Test
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl11.Dock = DockStyle.None;

            userControl21.BackColor = Color.Red;
            userControl21.Dock = DockStyle.Fill;
            userControl21.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl21.Dock = DockStyle.None;

            userControl11.Dock = DockStyle.Fill;
            userControl11.Visible = true;

        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl21.Dock = DockStyle.None;

            userControl11.Dock = DockStyle.Fill;
            userControl11.Visible = true;
            
        }
    }
}
