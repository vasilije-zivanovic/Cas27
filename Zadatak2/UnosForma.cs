using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    public enum Tip { domaci, strani }

    public partial class UnosForma : UserControl
    {
        public UnosForma()
        {
            InitializeComponent();
            Domaca.Checked = true;
            Naziv.TextChanged += Naziv_TextChanged; errorProvider1.SetError(Naziv, "Nema unos!");
            Adresa.TextChanged += Naziv_TextChanged; errorProvider1.SetError(Adresa, "Nema unos!");
            Spec.TextChanged += Naziv_TextChanged; errorProvider1.SetError(Spec, "Nema unos!");
        }

        public bool ImaGreske()
        {
            return (errorProvider1.GetError(Naziv) != "" || errorProvider1.GetError(Adresa) != "" || errorProvider1.GetError(Spec) != "");
        }

        public ArrayList VratiVrednosti()
        {
            ArrayList a = new ArrayList();

            if (ImaGreske()) { return a; }

            a.Add(Naziv.Text);
            a.Add(Adresa.Text);
            a.Add(Otvoren.Checked);
            a.Add(Spec.Text);
            a.Add(Domaca.Checked ? Tip.domaci : Tip.strani);

            return a;
        }

        private void Naziv_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                errorProvider1.SetError(tb, "");
            } else
            {
                errorProvider1.SetError(tb, "Prazan unos!");
            }
        }
    }
}
