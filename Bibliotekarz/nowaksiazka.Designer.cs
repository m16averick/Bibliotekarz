namespace Bibliotekarz
{
    partial class nowaksiazka
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
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
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
            // nowaksiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 361);
            this.Name = "nowaksiazka";
            this.Text = "Nowa książka";
            this.Load += new System.EventHandler(this.nowaksiazka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bazaaaDataSet bazaaaDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bazaaaDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private bazaaaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}