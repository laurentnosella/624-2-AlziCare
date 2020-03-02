namespace AlziCare
{
    partial class FrmAdminEditUser
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
            this.lblInfoUser = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxDesc = new System.Windows.Forms.RichTextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.Location = new System.Drawing.Point(153, 25);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(107, 13);
            this.lblInfoUser.TabIndex = 0;
            this.lblInfoUser.Text = "<Nom de l\'utilisateur>";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrenom.Location = new System.Drawing.Point(88, 71);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(241, 20);
            this.tbxPrenom.TabIndex = 2;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDesc.Location = new System.Drawing.Point(88, 149);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(241, 182);
            this.tbxDesc.TabIndex = 6;
            this.tbxDesc.Text = "";
            // 
            // btnValid
            // 
            this.btnValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValid.Location = new System.Drawing.Point(12, 371);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(195, 67);
            this.btnValid.TabIndex = 7;
            this.btnValid.Text = "&Valider";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(213, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 67);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(85, 55);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "&Prénom";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(85, 133);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "&Description";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(85, 94);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "&Nom";
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNom.Location = new System.Drawing.Point(88, 110);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(241, 20);
            this.tbxNom.TabIndex = 4;
            // 
            // FrmAdminEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.lblInfoUser);
            this.MinimumSize = new System.Drawing.Size(430, 489);
            this.Name = "FrmAdminEditUser";
            this.Text = "AlziCare - Utilisateur";
            this.Load += new System.EventHandler(this.FrmAdminEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoUser;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.RichTextBox tbxDesc;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
    }
}