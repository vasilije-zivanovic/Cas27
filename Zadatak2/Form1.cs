using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RestoranPrihvati_Click(object sender, EventArgs e)
        {
            ArrayList a = unosForma1.VratiVrednosti();
            if (a.Count < 1) { MessageBox.Show("Nepravilan unos!","",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }

            dataGridView1.Rows.Add(a[0], a[1], a[2], a[3], a[4].ToString());
        }
    }
}
