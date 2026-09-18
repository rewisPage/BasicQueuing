namespace BasicQueuingCashier
{
    // Step 1: Define the CashierClass to manage queue state
    public class CashierClass
    {
        // Step 2: Declare variables as specified in Step 3 of the lab exercise
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        // Step 3: Initialize default values in constructor
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        // Step 4: Increments counter and returns formatted queue code
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}