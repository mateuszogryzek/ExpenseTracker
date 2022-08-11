namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly DataOperation _dataOperation = new ();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _dataOperation.Add(DateTextBox.Text, Convert.ToDecimal(AmountTextBox.Text), DescriptionTextBox.Text, CategoryTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter correct data");
            }
            
            dataGridView1.DataSource = _dataOperation.Expenses.ToList();

        }
    }
}