namespace LoanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupOut.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            groupOut.Visible = false;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtCard.Text = string.Empty;
            txtPeroid.Text = string.Empty;
            txtRate.Text = string.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtAmount.Text) ||
                    string.IsNullOrWhiteSpace(txtCard.Text) ||
                    string.IsNullOrWhiteSpace(txtPeroid.Text) ||
                    string.IsNullOrWhiteSpace(txtRate.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Parse input values
                if (!float.TryParse(txtAmount.Text, out float amount))
                {
                    MessageBox.Show("Invalid amount value.");
                    return;
                }

                if (!int.TryParse(txtRate.Text, out int rate) || rate < 0 || rate > 100)
                {
                    MessageBox.Show("Rate must be between 0 to 100");
                    return;
                }

                if (!int.TryParse(txtPeroid.Text, out int period) || period <= 0)
                {
                    MessageBox.Show("Period must be greater than 0");
                    return;
                }

                // Main calculation
                float ratePercent = rate / 100f; // Convert rate to percentage
                float interest = amount * period * ratePercent;

                // UI update
                groupOut.Visible = true;
                lblOutName.Text = txtName.Text;
                lblOutGH.Text = txtCard.Text;
                lblOutAddress.Text = txtAddress.Text;
                lblOutPeroid.Text = period.ToString() + " month(s)";
                lblOutRate.Text = rate.ToString() + "%";
                lblOutAmount.Text = "GHS " + amount.ToString("F2");
                lblOutPayment.Text = "GHS " + (amount + interest).ToString("F2");
                lblOutInterest.Text = "GHS " + interest.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
