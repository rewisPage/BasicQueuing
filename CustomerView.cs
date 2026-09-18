namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        // Timer to periodically poll and update the serving display
        private System.Windows.Forms.Timer timer;

        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            // Step 1: Initialize timer using the 1-second interval pattern from Handout/Lab
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();

            // Step 2: Perform immediate initial display check
            UpdateServingNumber();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            UpdateServingNumber();
        }

        // Step 3: Check Queue state and inspect front element
        private void UpdateServingNumber()
        {
            // Single condition validating if queue is initialized and contains elements
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                // Peek at the first ticket currently being served without dequeuing it
                string nextNumber = CashierClass.CashierQueue.Peek();

                // Validate if the queue still contains this item
                if (CashierClass.CashierQueue.Contains(nextNumber))
                {
                    lblNowServing.Text = nextNumber;
                }
            }
            else
            {
                lblNowServing.Text = "None";
            }
        }
    }
}