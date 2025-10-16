using System.Text.RegularExpressions;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text.Trim();
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Regex floatRegex = new Regex(@"^(?=.{1,60}$)[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$");
            richTextBox2.Clear();
            foreach (string word in words)
            {
                Match match = floatRegex.Match(word);
                if (match.Success)
                {
                    richTextBox2.AppendText(word + " → Valid Float" + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Invalid (not a valid float or too long): " + word);
                }

            }
        }
    }
}
