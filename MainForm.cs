using System;
using System.Windows.Forms;

namespace Assignment4Win
{
    public partial class MainForm : Form
    {
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

        private void CR_List_Button_Click(object sender, EventArgs e)
        {
            
            // senaste, jag meckar med vad som ska hända när jag klickar på knappen create list

            bool stringIsInt;
            stringIsInt = int.TryParse(lblNumberOfGuests.Text, out int theNumberInInt);
            if (stringIsInt)
            {
                Party party = new Party(theNumberInInt);
            }
        }

    }
}
