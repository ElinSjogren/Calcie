using System.Security.Cryptography.X509Certificates;

namespace Labb2miniraknare
{
    public partial class Form1 : Form
    {
        int val1 = 0;
        int val2 = 0;
       
        string operator1 = "0";
        


        public int OPClickEvent(int numb) //när jag trycker på plus eller likamed utförs operationen
        {
            
            if(operator1 == "0")
            { 
                val2 = int.Parse(displaybox.Text);
            }
            if(operator1 == "+")
            {
                val2 = val2 + numb;
                outlbl.Text = val2.ToString();
                operator1= "0";

            }
            if (operator1 == "-")
            {
                val2 = val2 - numb;
                outlbl.Text = numb.ToString();
                operator1 = "0";
            }
            if (operator1 == "*")
            {
                val2 = val2 * numb;
                outlbl.Text = numb.ToString();
                operator1 = "0";
            }
            if (operator1 == "/")
            {
                if (numb == 0)
                { 
                    outlbl.Text = "Error";
                    return 0;
                }

                else
                {
                    val2 = val2 / numb;
                    outlbl.Text = numb.ToString();
                    operator1 = "0";
                }
            }

            return val2;
        }



        public string btnNumPress(string numClick)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = numClick;
                return numClick;
            }
            else
            {
                displaybox.Text = displaybox.Text + numClick;
                return numClick;
            }
        }
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "1";
            }
            else
            {
                displaybox.Text = displaybox.Text + "1";
            }
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "2";
            }
            else
            {
                displaybox.Text = displaybox.Text + "2";
            }
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "3";
            }
            else
            {
                displaybox.Text = displaybox.Text + "3";
            }
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "4";
            }
            else
            {
                displaybox.Text = displaybox.Text + "4";
            }
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "5";
            }
            else
            {
                displaybox.Text = displaybox.Text + "5";
            }
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "6";
            }
            else
            {
                displaybox.Text = displaybox.Text + "6";
            }
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "7";
            }
            else
            {
                displaybox.Text = displaybox.Text + "7";
            }
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "8";
            }
            else
            {
                displaybox.Text = displaybox.Text + "8";
            }
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "9";
            }
            else
            {
                displaybox.Text = displaybox.Text + "9";
            }
        }

        private void erasebtn_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
            outlbl.Text = " ";
            val2 = 0;
            val1 = 0;
            operator1 = "0";

        }

        private void zerobtn_Click(object sender, EventArgs e)
        {

            if (displaybox.Text == "0" && displaybox.Text != null)
            {
                displaybox.Text = "0";
            }
            else
            {
                displaybox.Text = displaybox.Text + "0";
            }
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            try { 
                val2 = OPClickEvent(int.Parse(displaybox.Text));
                displaybox.Text = val2.ToString();
                oplbl.Text = " ";
                val2 = 0;
                val1 = 0;
                outlbl.Text = " ";
            }
            catch { 
                outlbl.Text = "Error, to large number";
            }
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {   
            try { 
                oplbl.Text = "+";
                val1 = int.Parse(displaybox.Text);
            
                val2 = OPClickEvent(val1);
                outlbl.Text = val2.ToString();
                operator1 = "+";
                displaybox.Text = "0";
            }
            catch { 
                outlbl.Text = "Error, to large";
            }
}

        private void minusbtn_Click(object sender, EventArgs e)
        {
            try { 
                oplbl.Text = "-";
                val1 = int.Parse(displaybox.Text);

                val2 = OPClickEvent(val1);
                outlbl.Text = val2.ToString();
                operator1 = "-";
                displaybox.Text = "0";
            }
            catch
            {
                outlbl.Text = "Error, to large";
            }
        }

        private void multibtn_Click(object sender, EventArgs e)
        {
            try { 
                oplbl.Text = "x";
                val1 = int.Parse(displaybox.Text);

                val2 = OPClickEvent(val1);
                outlbl.Text = val2.ToString();
                operator1 = "*";
                displaybox.Text = "0";
            }
            catch
            {
                outlbl.Text = "Error, to large";
            }
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            try
            {
                oplbl.Text = "/";
                val1 = int.Parse(displaybox.Text);

                val2 = OPClickEvent(val1);
                outlbl.Text = val2.ToString();
                operator1 = "/";
                displaybox.Text = "0";
            }
            catch
            {
                outlbl.Text = "Error, to large";
            }
        }
    }
}