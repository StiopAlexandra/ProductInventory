using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entitati;

namespace POS
{
    public partial class FormProdServ : Form
    {
        private ProduseMgr prodMgr = new ProduseMgr();
        private ServiciiMgr servMgr = new ServiciiMgr();
        private PacheteMgr pachMgr = new PacheteMgr();

        public FormProdServ()
        {
            InitializeComponent();
            if (ProduseAbstracteMgr.IsProd)
                ProduseAbstracteMgr.Elemente = prodMgr.loadFromXML("XMLProduse");
            else
                if (ProduseAbstracteMgr.IsServ)
                    ProduseAbstracteMgr.Elemente = servMgr.loadFromXML("XMLServicii");
                else
                {
                    ProduseAbstracteMgr.Elemente = pachMgr.loadFromXML("XMLPachete");
                    modificareBtn.Visible = false;
                }
            ProduseAbstracteMgr.Id = ProduseAbstracteMgr.Elemente.Count();
        }

        private void Display()
        {
            listBox1.Items.Clear();
            foreach (ProdusAbstract p in ProduseAbstracteMgr.Elemente)
            {
               listBox1.Items.Add(p.Descriere());
            }
        }
        
        private void DisplayFiltrare(IEnumerable<ProdusAbstract> list)
        {
            listBox1.Items.Clear();
            foreach (ProdusAbstract p in list.ToList())
            {
                listBox1.Items.Add(p.Descriere());
            }      
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] {"Nume","Pret","Categorie"});
            comboBox2.Items.AddRange(new object[] { "Nume", "Pret", "Categorie" });
            Display();
        }

        private void FormProduse_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ProduseAbstracteMgr.IsProd)
                prodMgr.save2XML("XMLProduse");
            else
                if (ProduseAbstracteMgr.IsServ)
                    servMgr.save2XML("XMLServicii");
                else
                    servMgr.save2XML("XMLPachete");
        }

        private void modificareBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                ProduseAbstracteMgr.IndexCurent = index;
                FormModifica modifica = new FormModifica();
                modifica.ShowDialog();
                Display();
            }
            else
            {
                if (ProduseAbstracteMgr.IsProd)
                    MessageBox.Show("Selecteaza un produs");
                else
                    MessageBox.Show("Selecteaza un serviciu");
            }          
        }

        private void adaugareBtn_Click_1(object sender, EventArgs e)
        {
            pachMgr.GenerateId();
            if(ProduseAbstracteMgr.IsProd == false && ProduseAbstracteMgr.IsServ == false)
            {
                AdaugaPachet adaugaPach = new AdaugaPachet();
                adaugaPach.ShowDialog();
            }
            else
            {
                FormAdauga adauga = new FormAdauga();
                adauga.ShowDialog();
            }           
            Display();
        }

        private void stergereBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                string msg;
                if (ProduseAbstracteMgr.IsProd)
                    msg= "Doresti sa stergi acest produs?";
                else
                if (ProduseAbstracteMgr.IsServ)
                    msg = "Doresti sa stergi acest serviciu?";
                else
                    msg = "Doresti sa stergi acest pachet?";
                if (MessageBox.Show(msg, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ProduseAbstracteMgr.Elemente.RemoveAt(index);
                }
                Display();
            }
            else
            {
                if (ProduseAbstracteMgr.IsProd)
                    MessageBox.Show("Selecteaza un produs");
                else
                if (ProduseAbstracteMgr.IsServ)
                    MessageBox.Show("Selecteaza un serviciu");
                else
                    MessageBox.Show("Selecteaza un pachet");
            }           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm paginaPrincipala = new MainForm();
            paginaPrincipala.Show();
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (rDesc.Checked == false && rAsc.Checked == false)
                MessageBox.Show("Cum doresti sa ordonezi?");
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    if (rAsc.Checked)
                        prodMgr.OrdonareNume(true);
                    else
                        prodMgr.OrdonareNume(false);
                    break;
                case 1:
                    if (rAsc.Checked)
                        prodMgr.OrdonarePret(true);
                    else
                        prodMgr.OrdonarePret(false);
                    break;
                case 2:
                    if (rAsc.Checked)
                        prodMgr.OrdonareCategorie(true);
                    else
                        prodMgr.OrdonareCategorie(false);
                    break;
                default:
                    MessageBox.Show("Dupa ce criteriu doresti sa ordonezi?");
                    break;
            }
            Display();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s=="")
                MessageBox.Show("Ce doresti sa cauti?");
            else { 
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    DisplayFiltrare(prodMgr.FiltrareNume(s));
                    break;
                case 1:
                    int i = int.Parse(s);
                    DisplayFiltrare(prodMgr.FiltrarePret(i));
                    break;
                case 2:
                    DisplayFiltrare(prodMgr.FiltrareCategorie(s));
                    break;
                default:
                    MessageBox.Show("Dupa ce criteriu doresti sa cauti?");
                    break;
            }
            }
        }
    }
}
