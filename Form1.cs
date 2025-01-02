using System.Data;

namespace CalcPercent
{
    public partial class CalculatePercent : Form
    {
        public CalculatePercent()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal oldValue = Convert.ToDecimal(txtOldValue.Text);
                decimal newValue = Convert.ToDecimal(txtNewValue.Text);

                decimal returnPercentage = ((newValue - oldValue) / oldValue) * 100;
                decimal sub = newValue - oldValue;

                lblResult.Text = $"{sub:F2} (%{returnPercentage:F2})";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs
                string resultName = txtResultName.Text;
                decimal oldValue = Convert.ToDecimal(txtOldValue.Text);
                decimal newValue = Convert.ToDecimal(txtNewValue.Text);
                decimal sub = newValue - oldValue;
                decimal result = ((newValue - oldValue) / oldValue) * 100;
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Current date and time

                if (string.IsNullOrWhiteSpace(resultName))
                {
                    MessageBox.Show("Please provide a name for the result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dataToSave = $"{resultName},{oldValue},{newValue},{sub},{result:F2},{currentDate}";

                string filePath = "SavedResults.txt"; // File path
                File.AppendAllText(filePath, dataToSave + Environment.NewLine);

                // Inform the user
                MessageBox.Show("Result saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtResultName.Clear();
                txtOldValue.Clear();
                txtNewValue.Clear();
                lblResult.Text = "...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "SavedResults.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No saved results found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lines = File.ReadAllLines(filePath);

                var dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Old Value");
                dataTable.Columns.Add("New Value");
                dataTable.Columns.Add("Sub");
                dataTable.Columns.Add("Result (%)");
                dataTable.Columns.Add("Date");

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        dataTable.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                    }
                }

                dgvResults.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
