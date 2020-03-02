namespace AlziCare
{
    partial class FrmAdminPlanning
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRappel = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxMedicCombo = new System.Windows.Forms.RadioButton();
            this.cbxMedicTxt = new System.Windows.Forms.RadioButton();
            this.tbxMedic = new System.Windows.Forms.TextBox();
            this.cbMedic = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxHeure = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'un évènement";
            // 
            // cbRappel
            // 
            this.cbRappel.FormattingEnabled = true;
            this.cbRappel.Items.AddRange(new object[] {
            "Sans rappel",
            "Avec rappel"});
            this.cbRappel.Location = new System.Drawing.Point(40, 39);
            this.cbRappel.Name = "cbRappel";
            this.cbRappel.Size = new System.Drawing.Size(121, 21);
            this.cbRappel.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudQuantity);
            this.groupBox4.Location = new System.Drawing.Point(440, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Quantité";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(40, 40);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxMedicCombo);
            this.groupBox3.Controls.Add(this.cbxMedicTxt);
            this.groupBox3.Controls.Add(this.tbxMedic);
            this.groupBox3.Controls.Add(this.cbMedic);
            this.groupBox3.Location = new System.Drawing.Point(234, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&Médicament";
            // 
            // cbxMedicCombo
            // 
            this.cbxMedicCombo.AutoSize = true;
            this.cbxMedicCombo.Checked = true;
            this.cbxMedicCombo.Location = new System.Drawing.Point(25, 64);
            this.cbxMedicCombo.Name = "cbxMedicCombo";
            this.cbxMedicCombo.Size = new System.Drawing.Size(14, 13);
            this.cbxMedicCombo.TabIndex = 2;
            this.cbxMedicCombo.TabStop = true;
            this.cbxMedicCombo.UseVisualStyleBackColor = true;
            this.cbxMedicCombo.CheckedChanged += new System.EventHandler(this.cbMedicCombo_CheckedChanged);
            // 
            // cbxMedicTxt
            // 
            this.cbxMedicTxt.AutoSize = true;
            this.cbxMedicTxt.Location = new System.Drawing.Point(25, 22);
            this.cbxMedicTxt.Name = "cbxMedicTxt";
            this.cbxMedicTxt.Size = new System.Drawing.Size(14, 13);
            this.cbxMedicTxt.TabIndex = 0;
            this.cbxMedicTxt.UseVisualStyleBackColor = true;
            this.cbxMedicTxt.CheckedChanged += new System.EventHandler(this.cbMedicTxt_CheckedChanged);
            // 
            // tbxMedic
            // 
            this.tbxMedic.Location = new System.Drawing.Point(54, 20);
            this.tbxMedic.Name = "tbxMedic";
            this.tbxMedic.Size = new System.Drawing.Size(121, 20);
            this.tbxMedic.TabIndex = 1;
            // 
            // cbMedic
            // 
            this.cbMedic.FormattingEnabled = true;
            this.cbMedic.Items.AddRange(new object[] {
            "Panadol",
            "Dolipran",
            "Aspirine"});
            this.cbMedic.Location = new System.Drawing.Point(54, 61);
            this.cbMedic.Name = "cbMedic";
            this.cbMedic.Size = new System.Drawing.Size(121, 21);
            this.cbMedic.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxHeure);
            this.groupBox2.Location = new System.Drawing.Point(17, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Heure";
            // 
            // tbxHeure
            // 
            this.tbxHeure.Location = new System.Drawing.Point(50, 40);
            this.tbxHeure.Name = "tbxHeure";
            this.tbxHeure.Size = new System.Drawing.Size(100, 20);
            this.tbxHeure.TabIndex = 0;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Location = new System.Drawing.Point(800, 188);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbRappel);
            this.groupBox5.Location = new System.Drawing.Point(646, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "&Rappel";
            // 
            // FrmAdminPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 221);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 260);
            this.Name = "FrmAdminPlanning";
            this.Text = "AlziCare - Gestion du planning";
            this.Load += new System.EventHandler(this.AdminPlanning_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRappel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton cbxMedicCombo;
        private System.Windows.Forms.RadioButton cbxMedicTxt;
        private System.Windows.Forms.TextBox tbxMedic;
        private System.Windows.Forms.ComboBox cbMedic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxHeure;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}