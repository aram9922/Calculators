using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;
            textBox.Text = textBox.Text + number;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            string s = textBox.Text;
            if (s.Length > 0)
            {
                textBox.Text = s.Remove(s.Length - 1, 1);
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "/";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}