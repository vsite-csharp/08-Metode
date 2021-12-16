
namespace Vsite.CSharp.Metode
{
    partial class Forma
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
            this.buttonSinkroni = new System.Windows.Forms.Button();
            this.buttonAsinkroni = new System.Windows.Forms.Button();
            this.textBoxSinkronoVrijeme = new System.Windows.Forms.TextBox();
            this.textBoxAsinkronoVrijeme = new System.Windows.Forms.TextBox();
            this.buttonAsinkroni2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxAsinkroni2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSinkroni
            // 
            this.buttonSinkroni.Location = new System.Drawing.Point(12, 50);
            this.buttonSinkroni.Name = "buttonSinkroni";
            this.buttonSinkroni.Size = new System.Drawing.Size(75, 23);
            this.buttonSinkroni.TabIndex = 0;
            this.buttonSinkroni.Text = "Pritisni me...";
            this.buttonSinkroni.UseVisualStyleBackColor = true;
            this.buttonSinkroni.Click += new System.EventHandler(this.buttonSinkroni_Click);
            // 
            // buttonAsinkroni
            // 
            this.buttonAsinkroni.Location = new System.Drawing.Point(134, 50);
            this.buttonAsinkroni.Name = "buttonAsinkroni";
            this.buttonAsinkroni.Size = new System.Drawing.Size(75, 23);
            this.buttonAsinkroni.TabIndex = 1;
            this.buttonAsinkroni.Text = "...i mene";
            this.buttonAsinkroni.UseVisualStyleBackColor = true;
            this.buttonAsinkroni.Click += new System.EventHandler(this.buttonAsinkroni_Click);
            // 
            // textBoxSinkronoVrijeme
            // 
            this.textBoxSinkronoVrijeme.Location = new System.Drawing.Point(12, 12);
            this.textBoxSinkronoVrijeme.Name = "textBoxSinkronoVrijeme";
            this.textBoxSinkronoVrijeme.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinkronoVrijeme.TabIndex = 2;
            // 
            // textBoxAsinkronoVrijeme
            // 
            this.textBoxAsinkronoVrijeme.Location = new System.Drawing.Point(134, 12);
            this.textBoxAsinkronoVrijeme.Name = "textBoxAsinkronoVrijeme";
            this.textBoxAsinkronoVrijeme.Size = new System.Drawing.Size(100, 20);
            this.textBoxAsinkronoVrijeme.TabIndex = 3;
            // 
            // buttonAsinkroni2
            // 
            this.buttonAsinkroni2.Location = new System.Drawing.Point(257, 50);
            this.buttonAsinkroni2.Name = "buttonAsinkroni2";
            this.buttonAsinkroni2.Size = new System.Drawing.Size(75, 23);
            this.buttonAsinkroni2.TabIndex = 4;
            this.buttonAsinkroni2.Text = "...i mene";
            this.buttonAsinkroni2.UseVisualStyleBackColor = true;
            this.buttonAsinkroni2.Click += new System.EventHandler(this.buttonAsinkroni2_ClickAsync);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(257, 88);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 14);
            this.progressBar.TabIndex = 5;
            // 
            // textBoxAsinkroni2
            // 
            this.textBoxAsinkroni2.Location = new System.Drawing.Point(258, 12);
            this.textBoxAsinkroni2.Name = "textBoxAsinkroni2";
            this.textBoxAsinkroni2.ReadOnly = true;
            this.textBoxAsinkroni2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAsinkroni2.TabIndex = 6;
            this.textBoxAsinkroni2.Text = "Pritisni tipku ispod";
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 114);
            this.Controls.Add(this.textBoxAsinkroni2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonAsinkroni2);
            this.Controls.Add(this.textBoxAsinkronoVrijeme);
            this.Controls.Add(this.textBoxSinkronoVrijeme);
            this.Controls.Add(this.buttonAsinkroni);
            this.Controls.Add(this.buttonSinkroni);
            this.MaximizeBox = false;
            this.Name = "Forma";
            this.Text = "Moj Marljivi Program";
            this.Load += new System.EventHandler(this.Forma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSinkroni;
        private System.Windows.Forms.Button buttonAsinkroni;
        private System.Windows.Forms.TextBox textBoxSinkronoVrijeme;
        private System.Windows.Forms.TextBox textBoxAsinkronoVrijeme;
        private System.Windows.Forms.Button buttonAsinkroni2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxAsinkroni2;
    }
}

