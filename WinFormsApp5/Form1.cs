using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 10)
            {
                MessageBox.Show("Wrong input(length)","Error date" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox1.Text.Count(l => l == '.') != 2)
            {
                MessageBox.Show("Wrong input(got error)", "Error date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text.Any(l => char.IsLetter(l)))
            {
                MessageBox.Show("Wrong input(has letters)", "Error date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime date = Convert.ToDateTime(textBox1.Text);
            MessageBox.Show($"{date.DayOfWeek}");
        }
    }
}
