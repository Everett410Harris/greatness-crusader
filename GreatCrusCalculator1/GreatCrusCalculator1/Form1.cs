namespace GreatCrusCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // button 1
        // append the text using Text w/ + symbol
        private void button1_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1";
        }
        // button 2
        // append the text using Text w/ + symbol
        private void button2_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2";
        }
        // button 3
        // append the text using Text w/ + symbol
        private void button3_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3";
        }
        // button 4
        // append the text using Text w/ + symbol
        private void button4_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4";
        }
        // button 5
        // append the text using Text w/ + symbol
        private void button5_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5";
        }
        // button 6
        // append the text using Text w/ + symbol
        private void button6_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6";
        }
        // button 7
        // append the text using Text w/ + symbol
        private void button7_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7";
        }
        // button 8
        // append the text using Text w/ + symbol
        private void button8_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8";
        }
        //button 9
        // append the text using Text w/ + symbol
        private void button9_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9";
        }
        // button 0
        // append the text using Text w/ + symbol
        private void button10_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0";
        }
        // button +
        // append the text using Text w/ + symbol or use AppendText() method
        private void button13_Click(object sender, EventArgs e)
        {
            tb.AppendText("+");
        }
        // button -
        private void button14_Click(object sender, EventArgs e)
        {
            tb.AppendText("-");
        }
        // button /
        private void button15_Click(object sender, EventArgs e)
        {
            tb.AppendText("/");
        }
        // button x
        private void button18_Click(object sender, EventArgs e)
        {
            tb.AppendText("x");
        }
        // button . used for floating based arithmetic operations
        private void button11_Click(object sender, EventArgs e)
        {
        // if Text box is not empty then append . otherwise no need to append .
            if(tb.Text != "")
            {
                tb.AppendText(".");
            }
        }
        // button % (modulus)
        private void button17_Click(object sender, EventArgs e)
        {
            // if Text box is not empty then append % otherwise no need to append %
            if (tb.Text != "")
            {
                tb.AppendText("%");
            }
        }
        // button Clear
        private void button19_Click(object sender, EventArgs e)
        {
            // clear the text box using Text property set with null or empty string
            tb.Text = "";
        }
        // button E (exit)
        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // button <-- : reduce expression by one
        private void button12_Click(object sender, EventArgs e)
        {
            // get the old string
            string old = tb.Text;
            // reduce the expression by one (string formatted number by default) using Substring() method
            string ns = old.Substring(0, old.Length - 1);
            // update expression to same text box Text property
            tb.Text = ns;
        }
        // button = : Main Logic
        private void button16_Click(object sender, EventArgs e)
        {
        // if the expression (entered by user data) contains "x" means then do the multiplication
        // all operations are based on tb.Text which returns string by default even if type number
            if(tb.Text.Contains("x"))
            {
                // find the index position of the letter 'x' in the above expression using string IndexOf() method
                int pos = tb.Text.IndexOf('x');
                // get the First Number before x (string formatted number) using Substring() method of string
                string n1 = tb.Text.Substring(0, pos);
                // get the Second Number after x
                string n2 = tb.Text.Substring(pos+1);
                // convert string formatted 1st number to double which supports both integer and float using static method Parse()
                double a = double.Parse(n1);
                // convert string formatted 2nd number to double
                double b = double.Parse(n2);
                // multiply the number using the * operator
                double c = a * b;
                // display the result in same text box but text box accepts only string whatever data if so
                // we need to convert the result into string
                tb.Text = c.ToString();
            }
            else if (tb.Text.Contains("/"))
            {
                // find the index position of the letter '/' in the above expression using string IndexOf() method
                int pos = tb.Text.IndexOf('/');
                // get the First Number before / (string formatted number) using Substring() method of string
                string n1 = tb.Text.Substring(0, pos);
                // get the Second Number after /
                string n2 = tb.Text.Substring(pos+1);
                // convert string formatted 1st number to double which supports both integer and float using static method Parse()
                double a = double.Parse(n1);
                // convert string formatted 2nd number to double
                double b = double.Parse(n2);
                // multiply the number using the / operator
                double c = a / b;
                // display the result in same text box but text box accepts only string whatever data if so
                // we need to convert the result into string
                tb.Text = c.ToString();
            }
            else if (tb.Text.Contains("+"))
            {
                // find the index position of the letter '+' in the above expression using string IndexOf() method
                int pos = tb.Text.IndexOf('+');
                // get the First Number before + (string formatted number) using Substring() method of string
                string n1 = tb.Text.Substring(0, pos);
                // get the Second Number after +
                string n2 = tb.Text.Substring(pos+1);
                // convert string formatted 1st number to double which supports both integer and float using static method Parse()
                double a = double.Parse(n1);
                // convert string formatted 2nd number to double
                double b = double.Parse(n2);
                // multiply the number using the + operator
                double c = a + b;
                // display the result in same text box but text box accepts only string whatever data if so
                // we need to convert the result into string
                tb.Text = c.ToString();
            }
            else if (tb.Text.Contains("-"))
            {
                // find the index position of the letter '-' in the above expression using string IndexOf() method
                int pos = tb.Text.IndexOf('-');
                // get the First Number before - (string formatted number) using Substring() method of string
                string n1 = tb.Text.Substring(0, pos);
                // get the Second Number after -
                string n2 = tb.Text.Substring(pos+1);
                // convert string formatted 1st number to double which supports both integer and float using static method Parse()
                double a = double.Parse(n1);
                // convert string formatted 2nd number to double
                double b = double.Parse(n2);
                // multiply the number using the - operator
                double c = a - b;
                // display the result in same text box but text box accepts only string whatever data if so
                // we need to convert the result into string
                tb.Text = c.ToString();
            }
            else if (tb.Text.Contains("%"))
            {
                // find the index position of the letter '%' in the above expression using string IndexOf() method
                int pos = tb.Text.IndexOf('%');
                // get the First Number before % (string formatted number) using Substring() method of string
                string n1 = tb.Text.Substring(0, pos);
                // get the Second Number after %
                string n2 = tb.Text.Substring(pos+1);
                // convert string formatted 1st number to double which supports both integer and float using static method Parse()
                double a = double.Parse(n1);
                // convert string formatted 2nd number to double
                double b = double.Parse(n2);
                // multiply the number using the % operator
                double c = a % b;
                // display the result in same text box but text box accepts only string whatever data if so
                // we need to convert the result into string
                tb.Text = c.ToString();
            }
        }
    }
}