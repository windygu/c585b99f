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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            dateTimePicker1.TextChanged += dateTimePicker1_TextChanged;
        }

        void dateTimePicker1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("text-" + dateTimePicker1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("change-" + dateTimePicker1.Text);
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            Console.WriteLine("close-" + dateTimePicker1.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Text = "1980-01-01";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            //dateTimePicker1.Text = "";
            //dateTimePicker2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Text = "1999-01-01";
        }
    }
}
