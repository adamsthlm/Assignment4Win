using System;
using System.Windows.Forms;

namespace Assignment4Win
{
    public partial class MainForm : Form
    {
        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lblNumberOfGuests.Text = string.Empty;
            lblTotalCost.Text = "0.0";
            txtLastname.Text = string.Empty;
            txtfirstName.Text = String.Empty;
            listAllGuests.Items.Clear();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void CR_List_Button_Click(object sender, EventArgs e)
        //{

        //}



        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            bool maxNumOK = CreateParty();
            if (!maxNumOK)
            {
                return;
            }
        }





        // ****************************************************************************************** problem*******************************************

        private bool CreateParty()
        {

            bool ok = true;

            if (int.TryParse(txtAmount.Text, out int maxNumber) && (maxNumber >= 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party list with space for {maxNumber} ");
            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }

        private bool ReadCostPerPerson()
        {
            bool ok = true;

            if (double.TryParse(txtAmount.Text, out double amount) && (amount != 0.0))
            {
                party.CostPerCapita = amount;
            }
            else
            {
                MessageBox.Show("Invalid amount. Please try again.");
                return false;
            }
            return ok;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {

            }
        }

        private bool TrimNames()
        {
            if ((!ValidateText(txtfirstName.Text)) ||
                  (!ValidateText(txtLastname.Text)))
            {
                return false;
            }
            return true;
        }

        private bool ValidateText(string text)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please provide both the first name and the second");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
