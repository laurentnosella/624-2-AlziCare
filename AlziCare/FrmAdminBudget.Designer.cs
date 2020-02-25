namespace AlziCare
{
    partial class FrmAdminBudget
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
            this.lbDepense = new System.Windows.Forms.ListBox();
            this.lbTotal = new System.Windows.Forms.ListBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDepense
            // 
            this.lbDepense.FormattingEnabled = true;
            this.lbDepense.Items.AddRange(new object[] {
            "Panadol - 15 CHF",
            "Aspirine - 20 CHF",
            "Dolipran - 10 CHF"});
            this.lbDepense.Location = new System.Drawing.Point(140, 28);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.Size = new System.Drawing.Size(433, 251);
            this.lbDepense.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.FormattingEnabled = true;
            this.lbTotal.Items.AddRange(new object[] {
            "45 CHF"});
            this.lbTotal.Location = new System.Drawing.Point(36, 18);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(433, 56);
            this.lbTotal.TabIndex = 1;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(698, 415);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(90, 23);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Extraire en PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails des dépenses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Location = new System.Drawing.Point(104, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // FrmAdminBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lbDepense);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmAdminBudget";
            this.Text = " AlziCare - Vue des dépenses";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDepense;
        private System.Windows.Forms.ListBox lbTotal;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}