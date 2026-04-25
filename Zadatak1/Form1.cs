using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox) sender;
            if (tb.Text.Length > 0 && !int.TryParse(tb.Text, out int t))
            {
                errorProvider1.SetError(tb, String.Empty);
            }
            else
            {
                errorProvider1.SetError(tb, "Nepravilan unos!");
            }
        }
    }
}
