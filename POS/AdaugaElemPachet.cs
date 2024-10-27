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
    public partial class AdaugaElemPachet : Form
    {
        private bool ok = true;

        public AdaugaElemPachet()
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
            if (textBoxNume.Text == "" && textBoxCodIntern.Text == "" && textBoxPret.Text == "" && textBoxCategorie.Text == "" && textBoxProducator.Text == "" || !ok)
                this.Hide();
            else
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
                        ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Add_elem(p);
                    }
                    else
                    {
                        Serviciu s = new Serviciu(
                        ProduseAbstracteMgr.Id,
                        textBoxNume.Text,
                        textBoxCodIntern.Text,
                        int.Parse(textBoxPret.Text),
                        textBoxCategorie.Text);
                        ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Add_elem(s);
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
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Adauga();
            ok = false;
            if (ProduseAbstracteMgr.IsProd)
            {
                if (((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Elem_pachet.Count(item => item is Produs) < ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).NrProd)
                {                   
                    Resetare();
                    textBoxProducator.Text = "";
                }
                else
                    MessageBox.Show("Ati adaugat deja numarul maxim de produse");
            }
            else
            {
                if (((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Elem_pachet.Count(item => item is Serviciu) < ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).NrServ)
                {
                    Resetare();
                }
                else
                    MessageBox.Show("Ati adaugat deja numarul maxim de servicii");
            }
        }

        private void Resetare()
        {
            textBoxNume.Text = "";
            textBoxCodIntern.Text = "";        
            textBoxPret.Text = "";
            textBoxCategorie.Text = "";
            ok = true;
        }
        private void Adauga()
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
                    ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Add_elem(p);
                }
                else
                {
                    Serviciu s = new Serviciu(
                    ProduseAbstracteMgr.Id,
                    textBoxNume.Text,
                    textBoxCodIntern.Text,
                    int.Parse(textBoxPret.Text),
                    textBoxCategorie.Text);
                    ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Add_elem(s);
                }
            }
            catch
            {               
                MessageBox.Show("Pretul introdus nu are un format corespunzator");
                textBoxPret.Text = "";
                textBoxPret.Focus();
            }
        }
    }
}
