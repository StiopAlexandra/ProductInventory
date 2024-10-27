
namespace POS
{
    partial class MainForm
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
            this.produse = new System.Windows.Forms.Button();
            this.servicii = new System.Windows.Forms.Button();
            this.pachete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produse
            // 
            this.produse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produse.Location = new System.Drawing.Point(348, 109);
            this.produse.Name = "produse";
            this.produse.Size = new System.Drawing.Size(163, 54);
            this.produse.TabIndex = 0;
            this.produse.Text = "PRODUSE";
            this.produse.UseVisualStyleBackColor = true;
            this.produse.Click += new System.EventHandler(this.produse_Click);
            // 
            // servicii
            // 
            this.servicii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicii.Location = new System.Drawing.Point(348, 205);
            this.servicii.Name = "servicii";
            this.servicii.Size = new System.Drawing.Size(163, 54);
            this.servicii.TabIndex = 1;
            this.servicii.Text = "SERVICII";
            this.servicii.UseVisualStyleBackColor = true;
            this.servicii.Click += new System.EventHandler(this.servicii_Click);
            // 
            // pachete
            // 
            this.pachete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pachete.Location = new System.Drawing.Point(348, 296);
            this.pachete.Name = "pachete";
            this.pachete.Size = new System.Drawing.Size(163, 54);
            this.pachete.TabIndex = 2;
            this.pachete.Text = "PACHETE";
            this.pachete.UseVisualStyleBackColor = true;
            this.pachete.Click += new System.EventHandler(this.pachete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pachete);
            this.Controls.Add(this.servicii);
            this.Controls.Add(this.produse);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produse;
        private System.Windows.Forms.Button servicii;
        private System.Windows.Forms.Button pachete;
    }
}

