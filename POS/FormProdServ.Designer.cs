
namespace POS
{
    partial class FormProdServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdServ));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adaugareBtn = new System.Windows.Forms.Button();
            this.modificareBtn = new System.Windows.Forms.Button();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rDesc = new System.Windows.Forms.RadioButton();
            this.rAsc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 2500;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(657, 329);
            this.listBox1.TabIndex = 0;
            // 
            // adaugareBtn
            // 
            this.adaugareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugareBtn.Location = new System.Drawing.Point(709, 170);
            this.adaugareBtn.Name = "adaugareBtn";
            this.adaugareBtn.Size = new System.Drawing.Size(150, 50);
            this.adaugareBtn.TabIndex = 1;
            this.adaugareBtn.Text = "ADAUGARE";
            this.adaugareBtn.UseVisualStyleBackColor = true;
            this.adaugareBtn.Click += new System.EventHandler(this.adaugareBtn_Click_1);
            // 
            // modificareBtn
            // 
            this.modificareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificareBtn.Location = new System.Drawing.Point(709, 258);
            this.modificareBtn.Name = "modificareBtn";
            this.modificareBtn.Size = new System.Drawing.Size(150, 50);
            this.modificareBtn.TabIndex = 2;
            this.modificareBtn.Text = "MODIFICARE";
            this.modificareBtn.UseVisualStyleBackColor = true;
            this.modificareBtn.Click += new System.EventHandler(this.modificareBtn_Click);
            // 
            // stergereBtn
            // 
            this.stergereBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergereBtn.Location = new System.Drawing.Point(709, 344);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(150, 50);
            this.stergereBtn.TabIndex = 3;
            this.stergereBtn.Text = "STERGERE";
            this.stergereBtn.UseVisualStyleBackColor = true;
            this.stergereBtn.Click += new System.EventHandler(this.stergereBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(36, 39);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 40);
            this.backBtn.TabIndex = 4;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(479, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ordoneaza  ";
            // 
            // rDesc
            // 
            this.rDesc.AutoSize = true;
            this.rDesc.Location = new System.Drawing.Point(88, 13);
            this.rDesc.Name = "rDesc";
            this.rDesc.Size = new System.Drawing.Size(83, 17);
            this.rDesc.TabIndex = 8;
            this.rDesc.TabStop = true;
            this.rDesc.Text = "Descendent";
            this.rDesc.UseVisualStyleBackColor = true;
            // 
            // rAsc
            // 
            this.rAsc.AutoSize = true;
            this.rAsc.Location = new System.Drawing.Point(6, 13);
            this.rAsc.Name = "rAsc";
            this.rAsc.Size = new System.Drawing.Size(76, 17);
            this.rAsc.TabIndex = 9;
            this.rAsc.TabStop = true;
            this.rAsc.Text = "Ascendent";
            this.rAsc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rDesc);
            this.groupBox1.Controls.Add(this.rAsc);
            this.groupBox1.Location = new System.Drawing.Point(249, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 41);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "dupa:";
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.Transparent;
            this.sortBtn.Image = ((System.Drawing.Image)(resources.GetObject("sortBtn.Image")));
            this.sortBtn.Location = new System.Drawing.Point(635, 67);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(34, 34);
            this.sortBtn.TabIndex = 12;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(635, 18);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(34, 34);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cauta dupa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(249, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(97, 39);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(40, 40);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // FormProdServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.stergereBtn);
            this.Controls.Add(this.modificareBtn);
            this.Controls.Add(this.adaugareBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "FormProdServ";
            this.Text = "FormProdServ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProduse_FormClosed);
            this.Load += new System.EventHandler(this.FormProduse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button adaugareBtn;
        private System.Windows.Forms.Button modificareBtn;
        private System.Windows.Forms.Button stergereBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rDesc;
        private System.Windows.Forms.RadioButton rAsc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button refreshBtn;
    }
}