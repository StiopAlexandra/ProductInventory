
namespace POS
{
    partial class AdaugaPachet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.renuntaBtn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.textBoxCodIntern = new System.Windows.Forms.TextBox();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.textBoxServ = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelServ = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelCodIntern = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.addProd = new System.Windows.Forms.Button();
            this.addServ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Adaugare pachet";
            // 
            // renuntaBtn
            // 
            this.renuntaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renuntaBtn.Location = new System.Drawing.Point(249, 296);
            this.renuntaBtn.Name = "renuntaBtn";
            this.renuntaBtn.Size = new System.Drawing.Size(100, 30);
            this.renuntaBtn.TabIndex = 37;
            this.renuntaBtn.Text = "RENUNTA";
            this.renuntaBtn.UseVisualStyleBackColor = true;
            this.renuntaBtn.Click += new System.EventHandler(this.renuntaBtn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(122, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "SALVEAZA";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(184, 160);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(278, 20);
            this.textBoxCategorie.TabIndex = 35;
            // 
            // textBoxCodIntern
            // 
            this.textBoxCodIntern.Location = new System.Drawing.Point(184, 119);
            this.textBoxCodIntern.Name = "textBoxCodIntern";
            this.textBoxCodIntern.Size = new System.Drawing.Size(278, 20);
            this.textBoxCodIntern.TabIndex = 34;
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(184, 201);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxProd.TabIndex = 33;
            // 
            // textBoxServ
            // 
            this.textBoxServ.Location = new System.Drawing.Point(184, 242);
            this.textBoxServ.Name = "textBoxServ";
            this.textBoxServ.Size = new System.Drawing.Size(100, 20);
            this.textBoxServ.TabIndex = 32;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(184, 80);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(278, 20);
            this.textBoxNume.TabIndex = 31;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(76, 160);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(102, 17);
            this.labelCategorie.TabIndex = 30;
            this.labelCategorie.Text = "CATEGORIE:";
            // 
            // labelServ
            // 
            this.labelServ.AutoSize = true;
            this.labelServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServ.Location = new System.Drawing.Point(28, 245);
            this.labelServ.Name = "labelServ";
            this.labelServ.Size = new System.Drawing.Size(150, 17);
            this.labelServ.TabIndex = 29;
            this.labelServ.Text = "NR. MAX. SERVICII:";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(17, 202);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(162, 17);
            this.labelProd.TabIndex = 28;
            this.labelProd.Text = "NR. MAX. PRODUSE:";
            // 
            // labelCodIntern
            // 
            this.labelCodIntern.AutoSize = true;
            this.labelCodIntern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodIntern.Location = new System.Drawing.Point(66, 119);
            this.labelCodIntern.Name = "labelCodIntern";
            this.labelCodIntern.Size = new System.Drawing.Size(108, 17);
            this.labelCodIntern.TabIndex = 27;
            this.labelCodIntern.Text = "COD INTERN:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(117, 80);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(57, 17);
            this.labelNume.TabIndex = 26;
            this.labelNume.Text = "NUME:";
            // 
            // addProd
            // 
            this.addProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProd.Location = new System.Drawing.Point(290, 195);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(172, 30);
            this.addProd.TabIndex = 39;
            this.addProd.Text = "ADAUGA PRODUSE";
            this.addProd.UseVisualStyleBackColor = true;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // addServ
            // 
            this.addServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServ.Location = new System.Drawing.Point(290, 236);
            this.addServ.Name = "addServ";
            this.addServ.Size = new System.Drawing.Size(172, 30);
            this.addServ.TabIndex = 40;
            this.addServ.Text = "ADAUGA SERVICII";
            this.addServ.UseVisualStyleBackColor = true;
            this.addServ.Click += new System.EventHandler(this.addServ_Click);
            // 
            // AdaugaPachet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.addServ);
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renuntaBtn);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCategorie);
            this.Controls.Add(this.textBoxCodIntern);
            this.Controls.Add(this.textBoxProd);
            this.Controls.Add(this.textBoxServ);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelServ);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelCodIntern);
            this.Controls.Add(this.labelNume);
            this.Name = "AdaugaPachet";
            this.Text = "AdaugaPachet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renuntaBtn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.TextBox textBoxCodIntern;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.TextBox textBoxServ;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelServ;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelCodIntern;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button addProd;
        private System.Windows.Forms.Button addServ;
    }
}