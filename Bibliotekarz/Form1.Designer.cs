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
            this.components = new System.ComponentModel.Container();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnWypozyczenie = new System.Windows.Forms.Button();
            this.btnZwrot = new System.Windows.Forms.Button();
            this.btnNowaKsiazka = new System.Windows.Forms.Button();
            this.btnNowyCzytelnik = new System.Windows.Forms.Button();
            this.bazaaaDataSet = new Bibliotekarz.bazaaaDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Bibliotekarz.bazaaaDataSetTableAdapters.booksTableAdapter();
            this.tableAdapterManager = new Bibliotekarz.bazaaaDataSetTableAdapters.TableAdapterManager();
            this.btnWszystkieKsiazki = new System.Windows.Forms.Button();
            this.btnWszyscyCzytelnicy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(15, 60);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(273, 347);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // btnWypozyczenie
            // 
            this.btnWypozyczenie.Location = new System.Drawing.Point(427, 80);
            this.btnWypozyczenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnZwrot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnNowaKsiazka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnNowyCzytelnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNowyCzytelnik.Name = "btnNowyCzytelnik";
            this.btnNowyCzytelnik.Size = new System.Drawing.Size(171, 37);
            this.btnNowyCzytelnik.TabIndex = 4;
            this.btnNowyCzytelnik.Text = "Nowy czytelnik";
            this.btnNowyCzytelnik.UseVisualStyleBackColor = true;
            this.btnNowyCzytelnik.Click += new System.EventHandler(this.btnNowyCzytelnik_Click);
            // 
            // bazaaaDataSet
            // 
            this.bazaaaDataSet.DataSetName = "bazaaaDataSet";
            this.bazaaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.bazaaaDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.czytelnicyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bibliotekarz.bazaaaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnWszystkieKsiazki
            // 
            this.btnWszystkieKsiazki.Location = new System.Drawing.Point(427, 250);
            this.btnWszystkieKsiazki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWszystkieKsiazki.Name = "btnWszystkieKsiazki";
            this.btnWszystkieKsiazki.Size = new System.Drawing.Size(171, 37);
            this.btnWszystkieKsiazki.TabIndex = 5;
            this.btnWszystkieKsiazki.Text = "Wszystkie książki";
            this.btnWszystkieKsiazki.UseVisualStyleBackColor = true;
            this.btnWszystkieKsiazki.Click += new System.EventHandler(this.btnWszystkieKsiazki_Click);
            // 
            // btnWszyscyCzytelnicy
            // 
            this.btnWszyscyCzytelnicy.Location = new System.Drawing.Point(427, 291);
            this.btnWszyscyCzytelnicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWszyscyCzytelnicy.Name = "btnWszyscyCzytelnicy";
            this.btnWszyscyCzytelnicy.Size = new System.Drawing.Size(171, 37);
            this.btnWszyscyCzytelnicy.TabIndex = 6;
            this.btnWszyscyCzytelnicy.Text = "Wszyscy czytelnicy";
            this.btnWszyscyCzytelnicy.UseVisualStyleBackColor = true;
            this.btnWszyscyCzytelnicy.Click += new System.EventHandler(this.btnWszyscyCzytelnicy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 523);
            this.Controls.Add(this.btnWszyscyCzytelnicy);
            this.Controls.Add(this.btnWszystkieKsiazki);
            this.Controls.Add(this.btnNowyCzytelnik);
            this.Controls.Add(this.btnNowaKsiazka);
            this.Controls.Add(this.btnZwrot);
            this.Controls.Add(this.btnWypozyczenie);
            this.Controls.Add(this.tbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bibliotekarz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnWypozyczenie;
        private System.Windows.Forms.Button btnZwrot;
        private System.Windows.Forms.Button btnNowaKsiazka;
        private System.Windows.Forms.Button btnNowyCzytelnik;
        private bazaaaDataSet bazaaaDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bazaaaDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private bazaaaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnWszystkieKsiazki;
        private System.Windows.Forms.Button btnWszyscyCzytelnicy;
    }
}

