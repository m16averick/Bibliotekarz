namespace Bibliotekarz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnWypozyczenie = new System.Windows.Forms.Button();
            this.btnZwrot = new System.Windows.Forms.Button();
            this.btnNowaKsiazka = new System.Windows.Forms.Button();
            this.btnNowyCzytelnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(274, 347);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // btnWypozyczenie
            // 
            this.btnWypozyczenie.Location = new System.Drawing.Point(427, 80);
            this.btnWypozyczenie.Name = "btnWypozyczenie";
            this.btnWypozyczenie.Size = new System.Drawing.Size(171, 37);
            this.btnWypozyczenie.TabIndex = 1;
            this.btnWypozyczenie.Text = "Wypożyczenie";
            this.btnWypozyczenie.UseVisualStyleBackColor = true;
            this.btnWypozyczenie.Click += new System.EventHandler(this.btnWypozyczenie_Click);
            // 
            // btnZwrot
            // 
            this.btnZwrot.Location = new System.Drawing.Point(427, 123);
            this.btnZwrot.Name = "btnZwrot";
            this.btnZwrot.Size = new System.Drawing.Size(171, 37);
            this.btnZwrot.TabIndex = 2;
            this.btnZwrot.Text = "Zwrot";
            this.btnZwrot.UseVisualStyleBackColor = true;
            this.btnZwrot.Click += new System.EventHandler(this.btnZwrot_Click);
            // 
            // btnNowaKsiazka
            // 
            this.btnNowaKsiazka.Location = new System.Drawing.Point(427, 166);
            this.btnNowaKsiazka.Name = "btnNowaKsiazka";
            this.btnNowaKsiazka.Size = new System.Drawing.Size(171, 37);
            this.btnNowaKsiazka.TabIndex = 3;
            this.btnNowaKsiazka.Text = "Nowa książka";
            this.btnNowaKsiazka.UseVisualStyleBackColor = true;
            this.btnNowaKsiazka.Click += new System.EventHandler(this.btnNowaKsiazka_Click);
            // 
            // btnNowyCzytelnik
            // 
            this.btnNowyCzytelnik.Location = new System.Drawing.Point(427, 209);
            this.btnNowyCzytelnik.Name = "btnNowyCzytelnik";
            this.btnNowyCzytelnik.Size = new System.Drawing.Size(171, 37);
            this.btnNowyCzytelnik.TabIndex = 4;
            this.btnNowyCzytelnik.Text = "Nowy czytelnik";
            this.btnNowyCzytelnik.UseVisualStyleBackColor = true;
            this.btnNowyCzytelnik.Click += new System.EventHandler(this.btnNowyCzytelnik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 371);
            this.Controls.Add(this.btnNowyCzytelnik);
            this.Controls.Add(this.btnNowaKsiazka);
            this.Controls.Add(this.btnZwrot);
            this.Controls.Add(this.btnWypozyczenie);
            this.Controls.Add(this.tbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bibliotekarz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnWypozyczenie;
        private System.Windows.Forms.Button btnZwrot;
        private System.Windows.Forms.Button btnNowaKsiazka;
        private System.Windows.Forms.Button btnNowyCzytelnik;
    }
}

