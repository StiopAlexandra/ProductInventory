using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entitati;

namespace POS
{
    public partial class FormModifica : Form
    {
        public FormModifica()
        {
            InitializeComponent();
            if(ProduseAbstracteMgr.IsProd==false)
            {
                textBoxProducator.Visible = false;
                labelProducator.Visible = false;
                label1.Text = "Modifica Serviciu";
            }
            else
            {
                textBoxProducator.Text = ((Produs)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Producator;
            }
            textBoxNume.Text = ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Nume;
            textBoxCodIntern.Text = ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].CodIntern;
            textBoxPret.Text = ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Pret.ToString();
            textBoxCategorie.Text = ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Categorie;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Nume = textBoxNume.Text;
                ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].CodIntern = textBoxCodIntern.Text;
                ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Pret = int.Parse(textBoxPret.Text);
                ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent].Categorie = textBoxCategorie.Text;
                if (ProduseAbstracteMgr.IsProd)
                {
                    ((Produs)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Producator = textBoxProducator.Text;
                }
                this.Hide();               
            }
            catch
            {
                MessageBox.Show("Pretul introdus nu are un format corespunzator");
                textBoxPret.Focus();
            }
            
        }

        private void renuntaBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa renunti?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
