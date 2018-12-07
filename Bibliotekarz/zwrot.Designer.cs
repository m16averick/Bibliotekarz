namespace Bibliotekarz
{
    partial class zwrot
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApprove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Zwróć!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdR
            // 
            this.txtIdR.Location = new System.Drawing.Point(411, 72);
            this.txtIdR.Name = "txtIdR";
            this.txtIdR.Size = new System.Drawing.Size(354, 22);
            this.txtIdR.TabIndex = 18;
            this.txtIdR.TextChanged += new System.EventHandler(this.txtIdR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id czytelnika:";
            // 
            // txtIdB
            // 
            this.txtIdB.Location = new System.Drawing.Point(31, 69);
            this.txtIdB.Name = "txtIdB";
            this.txtIdB.Size = new System.Drawing.Size(323, 22);
            this.txtIdB.TabIndex = 16;
            this.txtIdB.TextChanged += new System.EventHandler(this.txtIdB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id książki:";
            // 
            // txtApprove
            // 
            this.txtApprove.AutoSize = true;
            this.txtApprove.Location = new System.Drawing.Point(31, 246);
            this.txtApprove.Name = "txtApprove";
            this.txtApprove.Size = new System.Drawing.Size(0, 17);
            this.txtApprove.TabIndex = 20;
            // 
            // zwrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 322);
            this.Controls.Add(this.txtApprove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdB);
            this.Controls.Add(this.label1);
            this.Name = "zwrot";
            this.Text = "Zwrot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtApprove;
    }
}