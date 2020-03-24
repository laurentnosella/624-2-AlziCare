namespace AlziCare
{
    partial class FrmSelectAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.dgwPatient = new System.Windows.Forms.DataGridView();
            this.btnEspaceAdmin = new System.Windows.Forms.Button();
            this.btnFrontEnd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veuillez sélectionner le compte du &patient";
            // 
            // dgwPatient
            // 
            this.dgwPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatient.Location = new System.Drawing.Point(12, 157);
            this.dgwPatient.Name = "dgwPatient";
            this.dgwPatient.Size = new System.Drawing.Size(414, 278);
            this.dgwPatient.TabIndex = 2;
            this.dgwPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPatient_CellContentClick);
            // 
            // btnEspaceAdmin
            // 
            this.btnEspaceAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEspaceAdmin.Location = new System.Drawing.Point(331, 12);
            this.btnEspaceAdmin.Name = "btnEspaceAdmin";
            this.btnEspaceAdmin.Size = new System.Drawing.Size(95, 23);
            this.btnEspaceAdmin.TabIndex = 4;
            this.btnEspaceAdmin.Text = "&Espace Admin";
            this.btnEspaceAdmin.UseVisualStyleBackColor = true;
            this.btnEspaceAdmin.Click += new System.EventHandler(this.btnEspaceAdmin_Click);
            // 
            // btnFrontEnd
            // 
            this.btnFrontEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrontEnd.Location = new System.Drawing.Point(169, 167);
            this.btnFrontEnd.Name = "btnFrontEnd";
            this.btnFrontEnd.Size = new System.Drawing.Size(101, 23);
            this.btnFrontEnd.TabIndex = 5;
            this.btnFrontEnd.Text = "Acces &FrontEnd";
            this.btnFrontEnd.UseVisualStyleBackColor = true;
            this.btnFrontEnd.Click += new System.EventHandler(this.btnFrontEnd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFrontEnd);
            this.Controls.Add(this.btnEspaceAdmin);
            this.Controls.Add(this.dgwPatient);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(454, 486);
            this.Name = "FrmSelectAccount";
            this.Text = "AlziCare - Sélection du compte";
            this.Load += new System.EventHandler(this.SelectAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwPatient;
        private System.Windows.Forms.Button btnEspaceAdmin;
        private System.Windows.Forms.Button btnFrontEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}