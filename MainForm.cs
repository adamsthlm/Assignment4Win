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

        private void BtnCreateParty_Click(object sender, EventArgs e)
        {
            bool maxNumOK = CreateParty();
            if (!maxNumOK)
            {
                return;
            }
        }


        private bool CreateParty()
        {

            bool ok = true;

            if (int.TryParse(textBox1.Text, out int maxNumber) && (maxNumber >= 0))
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

        private bool ReadCostPerPerson
        {
            get
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
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                bool ok = party.AddNewGuest(txtfirstName.Text, txtLastname.Text);
                if (!ok)
                {
                    MessageBox.Show("List is full! New guest not added!", "Error");

                }
                else
                    UpdateGUI();
            }
        }

        private void UpdateGUI()
        {
            listAllGuests.Items.Clear();
            string[] guestList = party.GetGuestList();
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    listAllGuests.Items.Add(str);

                }
            }
            else
                return;
           
            if (ReadCostPerPerson)
            {
                double totalCost = party.CalcTotalCost();
                string theCostAsString = totalCost.ToString();
                lblTotalCost.Text = theCostAsString;
            }
          
            lblNumberOfGuests.Text = party.Count.ToString();
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
                MessageBox.Show("Please provide both the first name AND last");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Här behöver jag hantera om ingen lista är skapad


            try
            {
                party.DeleteAt(listAllGuests.SelectedIndex);
                UpdateGUI();
                // Hurray!!!
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please create a guestlist first!");
                InitializeGUI();
               // throw;
            }
            


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
