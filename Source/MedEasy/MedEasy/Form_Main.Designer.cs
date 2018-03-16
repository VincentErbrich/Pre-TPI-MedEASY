namespace MedEasy
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_Connecte = new System.Windows.Forms.Label();
            this.lbl_CurrentUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mst_TopMenu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lbl_Connecte
            // 
            this.lbl_Connecte.AutoSize = true;
            this.lbl_Connecte.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Connecte.Location = new System.Drawing.Point(1054, 0);
            this.lbl_Connecte.Name = "lbl_Connecte";
            this.lbl_Connecte.Size = new System.Drawing.Size(161, 17);
            this.lbl_Connecte.TabIndex = 1;
            this.lbl_Connecte.Text = "Connecté en tant que :";
            // 
            // lbl_CurrentUser
            // 
            this.lbl_CurrentUser.AutoSize = true;
            this.lbl_CurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_CurrentUser.Location = new System.Drawing.Point(1054, 22);
            this.lbl_CurrentUser.Name = "lbl_CurrentUser";
            this.lbl_CurrentUser.Size = new System.Drawing.Size(0, 17);
            this.lbl_CurrentUser.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.lbl_CurrentUser);
            this.Controls.Add(this.lbl_Connecte);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Management Made Easy";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_Connecte;
        private System.Windows.Forms.Label lbl_CurrentUser;
    }
}

