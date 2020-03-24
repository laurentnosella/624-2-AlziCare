namespace AlziCare
{
    partial class FrmUserRappel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserRappel));
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNomMedic = new System.Windows.Forms.Label();
            this.btnMedic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(160, 22);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(82, 31);
            this.lblHeure.TabIndex = 0;
            this.lblHeure.Text = "13:45";
            // 
            // lblNomMedic
            // 
            this.lblNomMedic.AutoSize = true;
            this.lblNomMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMedic.Location = new System.Drawing.Point(10, 77);
            this.lblNomMedic.Name = "lblNomMedic";
            this.lblNomMedic.Size = new System.Drawing.Size(382, 31);
            this.lblNomMedic.TabIndex = 1;
            this.lblNomMedic.Text = "13:40 - Aspirine 3 comprimé(s)";
            // 
            // btnMedic
            // 
            this.btnMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedic.Location = new System.Drawing.Point(15, 234);
            this.btnMedic.Name = "btnMedic";
            this.btnMedic.Size = new System.Drawing.Size(372, 59);
            this.btnMedic.TabIndex = 2;
            this.btnMedic.Text = "J\'ai pris mon &médicament";
            this.btnMedic.UseVisualStyleBackColor = true;
            this.btnMedic.Click += new System.EventHandler(this.btnMedic_Click);
            // 
            // FrmUserRappel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btnMedic);
            this.Controls.Add(this.lblNomMedic);
            this.Controls.Add(this.lblHeure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(418, 367);
            this.Name = "FrmUserRappel";
            this.Text = "AlziCare - Rappel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblNomMedic;
        private System.Windows.Forms.Button btnMedic;
    }
}