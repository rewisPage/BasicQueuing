namespace BasicQueuingCashier
{
    partial class CustomerView
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
            lblServingTitle = new Label();
            lblNowServing = new Label();
            SuspendLayout();
            // 
            // lblServingTitle
            // 
            lblServingTitle.AutoSize = true;
            lblServingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServingTitle.ForeColor = Color.LightGray;
            lblServingTitle.Location = new Point(35, 40);
            lblServingTitle.Margin = new Padding(4, 0, 4, 0);
            lblServingTitle.Name = "lblServingTitle";
            lblServingTitle.Size = new Size(146, 30);
            lblServingTitle.TabIndex = 0;
            lblServingTitle.Text = "*Now Serving";
            // 
            // lblNowServing
            // 
            lblNowServing.AutoSize = true;
            lblNowServing.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNowServing.ForeColor = Color.White;
            lblNowServing.Location = new Point(47, 110);
            lblNowServing.Margin = new Padding(4, 0, 4, 0);
            lblNowServing.Name = "lblNowServing";
            lblNowServing.Size = new Size(0, 65);
            lblNowServing.TabIndex = 1;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(420, 231);
            Controls.Add(lblNowServing);
            Controls.Add(lblServingTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(500, 550);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CustomerView";
            StartPosition = FormStartPosition.Manual;
            Text = "CustomerView";
            Load += CustomerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblServingTitle;
        private System.Windows.Forms.Label lblNowServing;
    }
}