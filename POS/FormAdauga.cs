using entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS
{
    public partial class FormAdauga : Form
    {
        public FormAdauga()
        {
            InitializeComponent();
            if (ProduseAbstracteMgr.IsProd == false)
            {
                textBoxProducator.Visible = false;
                labelProducator.Visible = false;
                label1.Text = "Adauga Serviciu";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProduseAbstracteMgr.IsProd)
                {
                    Produs p = new Produs(
                    ProduseAbstracteMgr.Id,
                    textBoxNume.Text,
                    textBoxCodIntern.Text,
                    textBoxProducator.Text,
                    int.Parse(textBoxPret.Text),
                    textBoxCategorie.Text);
                    ProduseAbstracteMgr.Elemente.Add(p);
                }
                else
                {
                    Serviciu p = new Serviciu(
                    ProduseAbstracteMgr.Id,
                    textBoxNume.Text,
                    textBoxCodIntern.Text,
                    int.Parse(textBoxPret.Text),
                    textBoxCategorie.Text);
                    ProduseAbstracteMgr.Elemente.Add(p);
                }
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Pretul introdus nu are un format corespunzator");
                textBoxPret.Text = "";
                textBoxPret.Focus();
            }   
        }

        private void renuntaBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa renunti?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
