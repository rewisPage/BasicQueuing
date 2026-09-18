namespace BasicQueuingCashier
{
    partial class QueuingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQueue = new Label();
            lblHeading = new Label();
            lblSub = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.FromArgb(45, 45, 48);
            btnCashier.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(35, 52);
            btnCashier.Margin = new Padding(4, 3, 4, 3);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(140, 115);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.ForeColor = Color.White;
            lblQueue.Location = new Point(222, 87);
            lblQueue.Margin = new Padding(4, 0, 4, 0);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(190, 51);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 10000";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.LightGray;
            lblHeading.Location = new Point(239, 40);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(161, 25);
            lblHeading.TabIndex = 2;
            lblHeading.Text = "Position in Queue";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.Tomato;
            lblSub.Location = new Point(35, 179);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(126, 15);
            lblSub.TabIndex = 3;
            lblSub.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(502, 231);
            Controls.Add(lblSub);
            Controls.Add(lblHeading);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(500, 200);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "QueuingForm";
            StartPosition = FormStartPosition.Manual;
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSub;
    }
}