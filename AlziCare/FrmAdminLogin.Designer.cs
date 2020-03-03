namespace AlziCare
{
    partial class FrmAdminLogin
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(33, 162);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(221, 81);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "Se &connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(31, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(84, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "&Nom d\'utilisateur";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(31, 69);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(71, 13);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "&Mot de passe";
            // 
            // txbMdp
            // 
            this.txbMdp.Location = new System.Drawing.Point(34, 85);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.PasswordChar = '*';
            this.txbMdp.Size = new System.Drawing.Size(221, 20);
            this.txbMdp.TabIndex = 4;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(34, 46);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(221, 20);
            this.txbLogin.TabIndex = 2;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Location = new System.Drawing.Point(54, 135);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(178, 13);
            this.lblErrorLogin.TabIndex = 5;
            this.lblErrorLogin.Text = "Erreur dans le login ou mot de passe";
            this.lblErrorLogin.Visible = false;
            // 
            // FrmAdminLogin
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 263);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txbMdp);
            this.Controls.Add(this.txbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminLogin";
            this.Text = "AlziCare - Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblErrorLogin;
    }
}