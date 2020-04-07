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
    public bool AddNewGuest(string fistName, string lastName)
    {
        bool ok = true;
        int vacantPos = FindVacantPosts();
        if (vacantPos != -1)
        {
            guestList[vacantPos] = FullName(fistName, lastName);

        }
        return ok;
    }


    /// <summary>
    /// This method adds first name w. lastname and converts lastname to <!---->
    /// letters.
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param> to UPPER
    /// <returns></returns>
    private string FullName(string firstName, string lastName) => lastName.ToUpper() + ", " + firstName;

    private int FindVacantPos()
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

    public int Count
    {
        get { return NumberOfGuests(); }
    }

    public double CalcTotalCost()
    {
        int numOfGuests = NumberOfGuests();
        double costper = CostPerCapita;
        double totalCost = numOfGuests * costper;
        return totalCost;
    }

    public string[] GetGuestList()
    {
       
        
        int size = NumberOfGuests();

        if (size <= 0)
        {
            return null;
        }

        string[] guests = new string[size];
        for (int i = 0, j = 0; i < guestList.Length; i++)
        {
            if (!string.IsNullOrEmpty(guestList[i]))
            {
                guests[j++] = guestList[i];
            }
        }
        return guests;
    } 

    public bool CheckIndex(int index)
    {
        return (index >= 0) && (index < guestList.Length);

    }

    public string GetItemAt(int index)
    {
        if (CheckIndex(index))
        {
            return guestList[index];

        }
        return null;

    }

    public bool DeleteAt(int index)
    {
        if (CheckIndex(index))
        {
            guestList[index] = string.Empty;
            return true;
        }
        else
            return false;
    }

    public bool ChangeAt(int index, string firstName, string lastName)
    {
        bool ok = false;
        if (CheckIndex(index))
        {
            guestList[index] = FullName(firstName, lastName);
        }
        else
            ok = true;

        return ok;

    }
}