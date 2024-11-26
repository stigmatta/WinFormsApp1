namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 1, overallChars = 0, average = 0;

            string message1 = "My name is Andrey";
            string message2 = "I am 19 years old";
            string message3 = "I am IT Step student";

            overallChars += message1.Length;
            MessageBox.Show(message1, $"Message {index++}", MessageBoxButtons.OK);

            overallChars += message2.Length;
            MessageBox.Show(message2, $"Message {index++}", MessageBoxButtons.OK);

            overallChars += message3.Length;
            MessageBox.Show(message3, $"Message {index}", MessageBoxButtons.OK);

            MessageBox.Show($"Average characters : {overallChars / index}", "Character Count", MessageBoxButtons.OK);

        }
    }
}
