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
    public partial class AdaugaPachet : Form
    {
        private bool ok = true;

        public AdaugaPachet()
        {
            InitializeComponent();
        }

        private void renuntaBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa renunti?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProduseAbstracteMgr.Elemente.RemoveAt(ProduseAbstracteMgr.IndexCurent);
                ProduseAbstracteMgr.IsProd = false;
                ProduseAbstracteMgr.IsServ = false;
                this.Hide();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBoxProd.Text);
                int.Parse(textBoxProd.Text);
                if (ok)
                {
                    Init();
                    ok = false;
                }
                ProduseAbstracteMgr.IsProd = false;
                ProduseAbstracteMgr.IsServ = false;
                this.Hide();
            }
            catch
            {             
                MessageBox.Show("Numarul de produse sau numarul de servicii introdus nu are un format corespunzator");
            }  
        }

        private Pachet Init()
        {
            Pachet pach = new Pachet(
                ProduseAbstracteMgr.Id,
                textBoxNume.Text,
                textBoxCodIntern.Text,
                int.Parse(textBoxProd.Text),
                int.Parse(textBoxServ.Text),
                textBoxCategorie.Text);
            ProduseAbstracteMgr.Elemente.Add(pach);
            return pach;
        }
        private void addProd_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxProd.Text);
                if (ok)
                {
                    Init();
                    ok = false;
                }
                if (n != 0 && n != ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Elem_pachet.Count(item => item is Produs))
                {
                    ProduseAbstracteMgr.IsProd = true;
                    ProduseAbstracteMgr.IsServ = false;
                    ProduseAbstracteMgr.IndexCurent = ProduseAbstracteMgr.Elemente.Count - 1;
                    AdaugaElemPachet new_elem = new AdaugaElemPachet();
                    new_elem.ShowDialog();
                }
            }
            catch
            {
                if(textBoxProd.Text == "")
                    MessageBox.Show("Te rog sa introduci numarul maxim de produse");
                else
                {
                    MessageBox.Show("Numarul maxim de produse introdus nu are un format corespunzator");
                    textBoxProd.Text = "";
                }              
                textBoxProd.Focus();
            }
        }

        private void addServ_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxServ.Text);
                if (ok)
                {
                    Init();
                    ok = false;
                }
                if(n!=0 && n!= ((Pachet)ProduseAbstracteMgr.Elemente[ProduseAbstracteMgr.IndexCurent]).Elem_pachet.Count(item => item is Serviciu))
                {
                    ProduseAbstracteMgr.IsProd = false;
                    ProduseAbstracteMgr.IsServ = true;
                    ProduseAbstracteMgr.IndexCurent = ProduseAbstracteMgr.Elemente.Count - 1;
                    AdaugaElemPachet new_elem = new AdaugaElemPachet();
                    new_elem.ShowDialog();
                }                
            }
            catch
            {
                if (textBoxProd.Text == "")
                    MessageBox.Show("Te rog sa introduci numarul maxim de produse");
                else
                {
                    MessageBox.Show("Numarul maxim de servicii introdus nu are un format corespunzator");
                    textBoxProd.Text = "";
                }
                textBoxProd.Focus();
            }
        }
    }
}
