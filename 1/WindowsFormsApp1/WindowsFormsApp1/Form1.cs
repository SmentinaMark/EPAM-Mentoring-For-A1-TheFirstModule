using System;
using System.Windows.Forms;
using MyClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GetName getName;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                getName = new GetName();
            }
            else
            {
                getName = new GetName(textBox1.Text);
            }
            MessageBox.Show($"{getName.GetNameMethod()}", "Результат", MessageBoxButtons.OK);
        }
    }
}
