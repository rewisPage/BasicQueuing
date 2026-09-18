namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        // Step 5: Declare private variable for CashierClass
        private CashierClass cashier;

        public QueuingForm()
        {
            InitializeComponent();
            // Step 6: Initialize CashierClass in the constructor
            cashier = new CashierClass();
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            // Open the Cashier Window Queue Form simultaneously
            CashierWindowQueueForm windowForm = new CashierWindowQueueForm();
            windowForm.Show();

            // Open the Customer Serving View Form
            CustomerView customerViewForm = new CustomerView();
            customerViewForm.Show();
        }

        // Step 4 & 7: Button click event to generate number and enqueue
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}