namespace Calculatrice
{
    public partial class Form1 : Form
    {
        double chiffreA, chiffreB, result;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }
        private void LabelCalcul_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            chiffreA = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            sign = "+";
            LabelCalcul.Text = chiffreA + " " + sign;
        }

        private void soustraction_Click(object sender, EventArgs e)
        {
            chiffreA = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            sign = "-";
            LabelCalcul.Text = chiffreA + " " + sign;
        }

        private void virgule_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + ",";
        }

        private void division_Click(object sender, EventArgs e)
        {
            chiffreA = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            sign = "/";
            LabelCalcul.Text = chiffreA + " " + sign;
        }
        private void Multiplication_Click(object sender, EventArgs e)
        {
            chiffreA = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            sign = "*";
            LabelCalcul.Text = chiffreA + " " + sign;

        }
        private void Calcul_Click(object sender, EventArgs e)
        {
            chiffreB = Convert.ToDouble(label1.Text);
            if (sign == "+")
            {
                result = chiffreA + chiffreB;
            }
            else if (sign == "-")
            {
                result = chiffreA - chiffreB;
            }
            else if (sign == "/")
            {
                result = chiffreA / chiffreB;
            }
            else if (sign == "*")
            {
                result = chiffreA * chiffreB;
            }
            label1.Text = result.ToString();
            LabelCalcul.Text = chiffreA + " " + sign + " " + chiffreB;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            chiffreA = chiffreB = 0;
            label1.Text = "0";
            LabelCalcul.Text = "";
        }
    }
}
