namespace Gpax
{
    public partial class Form1 : Form
    {
        private GPACalculator gpaCalculator;

        public Form1()
        {
            InitializeComponent();
            gpaCalculator = new GPACalculator();
        }

        private void btData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbGpa.Text))
                {
                    MessageBox.Show("Please enter a GPA value.");
                    return;
                }

                if (!double.TryParse(tbGpa.Text, out double input))
                {
                    MessageBox.Show("Invalid GPA format. Please enter a numeric value.");
                    tbGpa.Clear();
                    return;
                }
                if (input < 0.00 || input > 4.00)  // ตรวจสอบช่วงของ GPA
                {
                    MessageBox.Show("GPA must be between 0.00 and 4.00.");
                    tbGpa.Clear();
                    return;
                }

                gpaCalculator.setGPA(input);
                UpdateUI();
                tbGpa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                tbGpa.Clear();
            }
        }
        private void UpdateUI()
        {
            tbGpax.Text = gpaCalculator.getGPAX().ToString("F2");
            tbGpaMax.Text = gpaCalculator.getMaxGPA().ToString("F2");
            tbGpaMin.Text = gpaCalculator.getMinGPA().ToString("F2");
            tbStudentCount.Text = gpaCalculator.getStudentCount().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbGpa.Clear();
            tbGpax.Clear();
            tbGpaMax.Clear();
            tbGpaMin.Clear();
            tbStudentCount.Clear();
            gpaCalculator = new GPACalculator(); // Reset GPACalculator
            MessageBox.Show("All data has been cleared successfully!");
        }
    }
}
