namespace Vsite.CSharp.Metode
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonUlijevo = new System.Windows.Forms.ToolStripButton();
            this.buttonPremaGore = new System.Windows.Forms.ToolStripButton();
            this.ButtonPremaDolje = new System.Windows.Forms.ToolStripButton();
            this.ButtonUdesno = new System.Windows.Forms.ToolStripButton();
            this.buttonUvećaj = new System.Windows.Forms.ToolStripButton();
            this.ButtonUmanji = new System.Windows.Forms.ToolStripButton();
            this.panelZaCrtanje = new Vsite.CSharp.Metode.PanelZaCrtanje();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonUlijevo,
            this.buttonPremaGore,
            this.ButtonPremaDolje,
            this.ButtonUdesno,
            this.buttonUvećaj,
            this.ButtonUmanji});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(507, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "Pomakni ulijevo";
            // 
            // buttonUlijevo
            // 
            this.buttonUlijevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUlijevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUlijevo.Image")));
            this.buttonUlijevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUlijevo.Name = "buttonUlijevo";
            this.buttonUlijevo.Size = new System.Drawing.Size(23, 22);
            this.buttonUlijevo.Text = "Pomakni lijevo";
            this.buttonUlijevo.Click += new System.EventHandler(this.ButtonUlijevo_Click);
            // 
            // buttonPremaGore
            // 
            this.buttonPremaGore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPremaGore.Image = ((System.Drawing.Image)(resources.GetObject("buttonPremaGore.Image")));
            this.buttonPremaGore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPremaGore.Name = "buttonPremaGore";
            this.buttonPremaGore.Size = new System.Drawing.Size(23, 22);
            this.buttonPremaGore.Text = "Pomakni gore";
            this.buttonPremaGore.Click += new System.EventHandler(this.ButtonPremaGore_Click);
            // 
            // ButtonPremaDolje
            // 
            this.ButtonPremaDolje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPremaDolje.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPremaDolje.Image")));
            this.ButtonPremaDolje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPremaDolje.Name = "ButtonPremaDolje";
            this.ButtonPremaDolje.Size = new System.Drawing.Size(23, 22);
            this.ButtonPremaDolje.Text = "Pomakni dolje";
            this.ButtonPremaDolje.Click += new System.EventHandler(this.ButtonPremaDolje_Click);
            // 
            // ButtonUdesno
            // 
            this.ButtonUdesno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonUdesno.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUdesno.Image")));
            this.ButtonUdesno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUdesno.Name = "ButtonUdesno";
            this.ButtonUdesno.Size = new System.Drawing.Size(23, 22);
            this.ButtonUdesno.Text = "Pomakni desno";
            this.ButtonUdesno.Click += new System.EventHandler(this.ButtonUdesno_Click);
            // 
            // buttonUvećaj
            // 
            this.buttonUvećaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUvećaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonUvećaj.Image")));
            this.buttonUvećaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUvećaj.Name = "buttonUvećaj";
            this.buttonUvećaj.Size = new System.Drawing.Size(23, 22);
            this.buttonUvećaj.Text = "Uvećaj";
            this.buttonUvećaj.Click += new System.EventHandler(this.ButtonUvećaj_Click);
            // 
            // ButtonUmanji
            // 
            this.ButtonUmanji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonUmanji.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUmanji.Image")));
            this.ButtonUmanji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUmanji.Name = "ButtonUmanji";
            this.ButtonUmanji.Size = new System.Drawing.Size(23, 22);
            this.ButtonUmanji.Text = "Umanji";
            this.ButtonUmanji.Click += new System.EventHandler(this.ButtonUmanji_Click);
            // 
            // panelZaCrtanje
            // 
            this.panelZaCrtanje.BackColor = System.Drawing.SystemColors.Window;
            this.panelZaCrtanje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelZaCrtanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZaCrtanje.Location = new System.Drawing.Point(0, 25);
            this.panelZaCrtanje.Name = "panelZaCrtanje";
            this.panelZaCrtanje.Size = new System.Drawing.Size(507, 340);
            this.panelZaCrtanje.TabIndex = 1;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 365);
            this.Controls.Add(this.panelZaCrtanje);
            this.Controls.Add(this.toolStrip);
            this.Name = "GlavnaForma";
            this.Text = "Crtarije";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton buttonUlijevo;
        private System.Windows.Forms.ToolStripButton buttonPremaGore;
        private System.Windows.Forms.ToolStripButton ButtonPremaDolje;
        private System.Windows.Forms.ToolStripButton ButtonUdesno;
        private PanelZaCrtanje panelZaCrtanje;
        private System.Windows.Forms.ToolStripButton buttonUvećaj;
        private System.Windows.Forms.ToolStripButton ButtonUmanji;
    }
}

