namespace Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        void Reset_txtbValue()
        {
            txtbValue.Text = "";
            txtbResult.Text = "";
            MessageBox.Show("Please Enter Only Numeric Values!");
        }
        private void txtbValue_TextChanged(object sender, EventArgs e)
        {
            int NumberofDots = 0;
            for (int i = 0; i < txtbValue.Text?.Length; i++)
            {
                char c = txtbValue.Text[i];
                if (!((c >= 48 && c <= 57) || c == '.'))
                {
                    Reset_txtbValue();
                    break;
                }

                if (txtbValue.Text[i] == '.')
                {
                    NumberofDots++;
                    if (NumberofDots > 1)
                    {
                        Reset_txtbValue();
                        break;
                    }
                }
                
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double valueEntered;

            if (!double.TryParse(txtbValue.Text, out valueEntered))
            {
                MessageBox.Show("Must Enter value That Want To Convert!");
            }

            if (radiobtnMTKilo.Checked)
            {
                txtbResult.Text = (valueEntered / 1000).ToString();
            }
            else if (radiobtnMTMile.Checked)
            {
                txtbResult.Text = (valueEntered / 1_609.344).ToString();
            }
            else if (raidobtnMTMeter.Checked)
            {
                txtbResult.Text = (valueEntered * 1_609.344).ToString();
            }
            else
            {
                MessageBox.Show("Choose one of Units!");
            }
        }
    }
}