namespace Bibliotekarz
{
    partial class wypozyczenie
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
            this.components = new System.ComponentModel.Container();
            this.bazaaaDataSet = new Bibliotekarz.bazaaaDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Bibliotekarz.bazaaaDataSetTableAdapters.booksTableAdapter();
            this.tableAdapterManager = new Bibliotekarz.bazaaaDataSetTableAdapters.TableAdapterManager();
            this.libraryDataSet = new Bibliotekarz.LibraryDataSet();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new Bibliotekarz.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager1 = new Bibliotekarz.LibraryDataSetTableAdapters.TableAdapterManager();
            this.readersTableAdapter = new Bibliotekarz.LibraryDataSetTableAdapters.ReadersTableAdapter();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Bibliotekarz.LibraryDataSet();
            this.booksBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.booksReadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksReadersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdB = new System.Windows.Forms.TextBox();
            this.txtIdR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApprove = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadersBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDataSet;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BooksTableAdapter = this.booksTableAdapter1;
            this.tableAdapterManager1.ReadersTableAdapter = this.readersTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Bibliotekarz.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.libraryDataSet;
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "Books";
            this.booksBindingSource3.DataSource = this.libraryDataSet;
            // 
            // booksBindingSource6
            // 
            this.booksBindingSource6.DataMember = "Books";
            this.booksBindingSource6.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource4
            // 
            this.booksBindingSource4.DataMember = "Books";
            this.booksBindingSource4.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.libraryDataSet;
            // 
            // booksBindingSource5
            // 
            this.booksBindingSource5.DataMember = "Books";
            this.booksBindingSource5.DataSource = this.libraryDataSetBindingSource;
            // 
            // booksReadersBindingSource
            // 
            this.booksReadersBindingSource.DataMember = "Books_Readers";
            this.booksReadersBindingSource.DataSource = this.booksBindingSource1;
            // 
            // readersBindingSource1
            // 
            this.readersBindingSource1.DataMember = "Readers";
            this.readersBindingSource1.DataSource = this.libraryDataSet1;
            // 
            // booksReadersBindingSource1
            // 
            this.booksReadersBindingSource1.DataMember = "Books_Readers";
            this.booksReadersBindingSource1.DataSource = this.booksBindingSource1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id książki:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdB
            // 
            this.txtIdB.Location = new System.Drawing.Point(26, 95);
            this.txtIdB.Name = "txtIdB";
            this.txtIdB.Size = new System.Drawing.Size(323, 22);
            this.txtIdB.TabIndex = 9;
            // 
            // txtIdR
            // 
            this.txtIdR.Location = new System.Drawing.Point(406, 98);
            this.txtIdR.Name = "txtIdR";
            this.txtIdR.Size = new System.Drawing.Size(354, 22);
            this.txtIdR.TabIndex = 11;
            this.txtIdR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id czytelnika:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtApprove
            // 
            this.txtApprove.AutoSize = true;
            this.txtApprove.Location = new System.Drawing.Point(26, 206);
            this.txtApprove.Name = "txtApprove";
            this.txtApprove.Size = new System.Drawing.Size(0, 17);
            this.txtApprove.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Wypożycz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // wypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtApprove);
            this.Controls.Add(this.txtIdR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdB);
            this.Controls.Add(this.label1);
            this.Name = "wypozyczenie";
            this.Text = "wypozyczenie";
            this.Load += new System.EventHandler(this.wypozyczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksReadersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bazaaaDataSet bazaaaDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bazaaaDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private bazaaaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private LibraryDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private System.Windows.Forms.BindingSource booksBindingSource4;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource5;
        private System.Windows.Forms.BindingSource booksReadersBindingSource;
        private LibraryDataSet libraryDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource6;
        private System.Windows.Forms.BindingSource readersBindingSource1;
        private System.Windows.Forms.BindingSource booksReadersBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdB;
        private System.Windows.Forms.TextBox txtIdR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtApprove;
        private System.Windows.Forms.Button button1;
    }
}