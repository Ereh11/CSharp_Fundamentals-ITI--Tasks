namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (txtBxName.Text.Length < 5)
            {
                ok = false;
                lblMistakeName.Text = "Name must contain at least 5 characters";
            }
            else
                lblMistakeName.Text = "";
            if (!txtBxEmail.Text.Contains('@'))
            {
                ok = false;
                lblMistakeEmail.Text = "Email must contain @";
            }
            else
                lblMistakeEmail.Text = "";
            if (!chkBxFootball.Checked && !chkBxSwim.Checked && !chkBxTennis.Checked)
            {
                ok = false;
                lblMistakeHobbies.Text = "Choose at least one hobby";
            }
            else
                lblMistakeHobbies.Text = "";

            if (ok)
            {
                lblMistakeHobbies.Text = lblMistakeEmail.Text = lblMistakeName.Text = "";
                lblRegisterSucc.Text = "Thank you. Your Registeration is valid";
            }
        }
    }
}