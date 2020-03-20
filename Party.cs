/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/

class Party
{
    private double costPerCapita;
    private string[] guestList;

    //constructor
    public Party(int maxNumOfGuests)
    {
        guestList = new string[maxNumOfGuests];
    }

    public double CostPerCapita
    {
        get { return costPerCapita; }
        set
        {
            if (value >= 0)
            {
                costPerCapita = value;
            }
        }
    }
}