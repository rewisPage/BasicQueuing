using System.Collections;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        // Challenge Exercise: Declare Timer instance
        private System.Windows.Forms.Timer timer;

        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            // Challenge Exercise (Step 13): Automatically refresh list every 1 second
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        // Step 9: Manual refresh click event
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        // Challenge Exercise (Step 12): btnNext removes first item in queue
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("The queue is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Step 10: Method to display queue elements inside the ListView
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            if (CashierList != null)
            {
                foreach (Object obj in CashierList)
                {
                    listCashierQueue.Items.Add(obj.ToString());
                }
            }
        }

        // Challenge Exercise (Step 13): Timer tick handler for auto-refresh
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}