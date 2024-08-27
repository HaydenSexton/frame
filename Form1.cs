namespace SimpleWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Display a message box with the text from the Textbox
            MessageBox.Show("You entered: " + txtBoxInput.Text, "information",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
