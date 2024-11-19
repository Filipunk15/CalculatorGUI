using System;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Calcu : Form
    {
        private string value;
        private int signNum;
        private int firstValue;
        private int secondValue;
        public Calcu()
        {
            InitializeComponent();
            textBox1.Text = "0";
            signNum = 0;
        }

        private void button_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            value = btn.Text;
            if (value.Length < textBox1.MaxLength)
            {
                changeValue();
            }

        }

        private void changeValue()
        {
            value = value.ToString();
            if (textBox1.Text == "0")
            {
                textBox1.Text = value;
            }
            else
            {
                textBox1.Text += value;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            getResults();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            signNum = 1;
            textBox2.Text = textBox1.Text;
            textBox1.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            signNum = 2;
            textBox2.Text = textBox1.Text;
            textBox1.Text = "0";

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            signNum = 3;
            textBox2.Text = textBox1.Text;
            textBox1.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            signNum = 4;
            textBox2.Text = textBox1.Text;
            textBox1.Text = "0";
        }

        private int getResults()
        {
            switch (signNum)
            {
                case 1:
                    {
                        firstValue = Convert.ToInt32(textBox2.Text);
                        secondValue = Convert.ToInt32(textBox1.Text);
                        textBox2.Text = firstValue.ToString() + " + " + secondValue.ToString();
                        int result = firstValue + secondValue;
                        textBox1.Text = result.ToString();
                        return firstValue + secondValue;
                    }
                case 2:
                    {
                        firstValue = Convert.ToInt32(textBox2.Text);
                        secondValue = Convert.ToInt32(textBox1.Text);
                        textBox2.Text = firstValue.ToString() + " - " + secondValue.ToString();
                        int result = firstValue - secondValue;
                        textBox1.Text = result.ToString();
                        return firstValue - secondValue;
                    }
                case 3:
                    {
                        firstValue = Convert.ToInt32(textBox2.Text);
                        secondValue = Convert.ToInt32(textBox1.Text);
                        textBox2.Text = firstValue.ToString() + " * " + secondValue.ToString();
                        int result = firstValue * secondValue;
                        textBox1.Text = result.ToString();
                        return firstValue * secondValue;
                    }
                case 4:
                    {
                        firstValue = Convert.ToInt32(textBox2.Text);
                        secondValue = Convert.ToInt32(textBox1.Text);
                        if (secondValue == 0)
                        {
                            textBox1.Text = "Neplatne zadani!";
                            return 0;
                        }
                        else
                        {
                            textBox2.Text = firstValue.ToString() + " / " + secondValue.ToString();
                            int result = firstValue / secondValue;
                            textBox1.Text = result.ToString();
                            return firstValue / secondValue;
                        }
                    }
                default:
                    return 0;
            }
        }
    }
}
