namespace MedEasy
{
    partial class PanelCreationEnvironnement
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
            this.pnlNouveauPatient = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnecte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNouveauPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNouveauPatient
            // 
            this.pnlNouveauPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNouveauPatient.Controls.Add(this.label5);
            this.pnlNouveauPatient.Controls.Add(this.label4);
            this.pnlNouveauPatient.Controls.Add(this.label3);
            this.pnlNouveauPatient.Controls.Add(this.label2);
            this.pnlNouveauPatient.Controls.Add(this.lblConnecte);
            this.pnlNouveauPatient.Controls.Add(this.label1);
            this.pnlNouveauPatient.Location = new System.Drawing.Point(91, 47);
            this.pnlNouveauPatient.Name = "pnlNouveauPatient";
            this.pnlNouveauPatient.Size = new System.Drawing.Size(1265, 530);
            this.pnlNouveauPatient.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Créer un nouveau Patient";
            // 
            // lblConnecte
            // 
            this.lblConnecte.AutoSize = true;
            this.lblConnecte.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblConnecte.Location = new System.Drawing.Point(33, 70);
            this.lblConnecte.Name = "lblConnecte";
            this.lblConnecte.Size = new System.Drawing.Size(43, 16);
            this.lblConnecte.TabIndex = 4;
            this.lblConnecte.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Etat Civil :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(33, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(33, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Téléphone :\r\nDomicile";
            // 
            // PanelCreationEnvironnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 818);
            this.Controls.Add(this.pnlNouveauPatient);
            this.Name = "PanelCreationEnvironnement";
            this.Text = "PanelCreationEnvironnement";
            this.pnlNouveauPatient.ResumeLayout(false);
            this.pnlNouveauPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNouveauPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnecte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}