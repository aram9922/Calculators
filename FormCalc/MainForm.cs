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
        double num1;
        double num2;
        string label;
        public MainForm()
        {
            InitializeComponent();
            Plus.Enabled = false;
            Minus.Enabled = false;
            Divide.Enabled = false;
            Multiply.Enabled = false;
            Backspace.Enabled = false;
            Dot.Enabled = false;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;
            textBox.Text = textBox.Text + number;
            Plus.Enabled = true;
            Minus.Enabled = true;
            Divide.Enabled = true;
            Multiply.Enabled = true;
            Backspace.Enabled = true;
            Dot.Enabled = true;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ",";
            Backspace.Enabled = true;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            string s = textBox.Text;
            if (s.Length > 0)
            {
                textBox.Text = s.Remove(s.Length - 1, 1);
            }
            if (textBox.Text == "")
            {
                Plus.Enabled = false;
                Minus.Enabled = false;
                Divide.Enabled = false;
                Multiply.Enabled = false;
                Backspace.Enabled = false;
                Dot.Enabled = false;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Text = "";
            label1.Text = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Text = "";
            label1.Text = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Text = "";
            label1.Text = "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Text = "";
            label1.Text = "/";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(textBox.Text);
            textBox.Text = "";
            label = label1.Text;
            label1.Text = "=";
            switch (label)
            {
                case "+":
                    textBox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox.Text = (num1 / num2).ToString();
                    break;
            }
        }
    }
}