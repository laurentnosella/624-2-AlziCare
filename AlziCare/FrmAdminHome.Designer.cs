namespace AlziCare
{
    partial class FrmAdminHome
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnBudg = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(532, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(256, 67);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Éditer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupp.Enabled = false;
            this.btnSupp.Location = new System.Drawing.Point(532, 106);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(256, 67);
            this.btnSupp.TabIndex = 2;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlan.Enabled = false;
            this.btnPlan.Location = new System.Drawing.Point(532, 200);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(256, 67);
            this.btnPlan.TabIndex = 3;
            this.btnPlan.Text = "Planning";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnBudg
            // 
            this.btnBudg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBudg.Enabled = false;
            this.btnBudg.Location = new System.Drawing.Point(532, 294);
            this.btnBudg.Name = "btnBudg";
            this.btnBudg.Size = new System.Drawing.Size(256, 67);
            this.btnBudg.TabIndex = 4;
            this.btnBudg.Text = "Dépenses";
            this.btnBudg.UseVisualStyleBackColor = true;
            this.btnBudg.Click += new System.EventHandler(this.btnBudg_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(371, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 69);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgUser
            // 
            this.dtgUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUser.Location = new System.Drawing.Point(12, 12);
            this.dtgUser.Name = "dtgUser";
            this.dtgUser.Size = new System.Drawing.Size(514, 351);
            this.dtgUser.TabIndex = 7;
            this.dtgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUser_CellContentClick);
            // 
            // FrmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgUser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBudg);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnEdit);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmAdminHome";
            this.Text = "AlziCare - Espace Administrateur";
            this.Load += new System.EventHandler(this.FrmAdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnBudg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgUser;
    }
}