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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void produse_Click(object sender, EventArgs e)
        {
            ProduseAbstracteMgr.IsProd = true;
            ProduseAbstracteMgr.IsServ = false;
            open_Form();
        }

        private void servicii_Click(object sender, EventArgs e)
        {
            ProduseAbstracteMgr.IsProd = false;
            ProduseAbstracteMgr.IsServ = true;
            open_Form();
        }

        private void open_Form()
        {
            FormProdServ form_newItem = new FormProdServ();
            form_newItem.Show();
            this.Visible = false;
        }

        private void pachete_Click(object sender, EventArgs e)
        {
            ProduseAbstracteMgr.IsProd = false;
            ProduseAbstracteMgr.IsServ = false;
            open_Form();
        }
    }
}
