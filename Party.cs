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
    private int NumberOfGuests()
    {
        int numGuests = 0;
        for (int i = 0; i < guestList.Length; i++)
        {
            if (!string.IsNullOrEmpty(guestList[i]))
            {
                numGuests++;
            }
           
        }
        return numGuests;
    }

    private int FindVacantPosts()
    {
        int vacantPos = -1;
        for (int index = 0; index < guestList.Length; index++)
        {
            if (string.IsNullOrEmpty(guestList[index]))
            {
                vacantPos = index;
                break;
            }
        }
        return vacantPos;
    }

    // add new guest, sidan 4 i help kompendiumet
}