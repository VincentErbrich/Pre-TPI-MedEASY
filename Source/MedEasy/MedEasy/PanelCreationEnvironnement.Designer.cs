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
            this.pnlRendezVous = new System.Windows.Forms.Panel();
            this.lblRdvNotes = new System.Windows.Forms.Label();
            this.lblRdvPremierRdv = new System.Windows.Forms.Label();
            this.lblRdvRaison = new System.Windows.Forms.Label();
            this.lblRdvDate = new System.Windows.Forms.Label();
            this.dtpRdvDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRdvCurrentPatient = new System.Windows.Forms.Label();
            this.lblListePatients = new System.Windows.Forms.Label();
            this.grbRdvRaison = new System.Windows.Forms.GroupBox();
            this.rdbRdvRaisonVisiteRoutine = new System.Windows.Forms.RadioButton();
            this.rdbRdvRaisonPbMedical = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRdvPremiereConsultNon = new System.Windows.Forms.RadioButton();
            this.rdbRdvPremiereConsultOui = new System.Windows.Forms.RadioButton();
            this.rtbRdvNotes = new System.Windows.Forms.RichTextBox();
            this.pnlRendezVous.SuspendLayout();
            this.grbRdvRaison.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRendezVous
            // 
            this.pnlRendezVous.AutoScroll = true;
            this.pnlRendezVous.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRendezVous.Controls.Add(this.rtbRdvNotes);
            this.pnlRendezVous.Controls.Add(this.groupBox1);
            this.pnlRendezVous.Controls.Add(this.grbRdvRaison);
            this.pnlRendezVous.Controls.Add(this.lblRdvNotes);
            this.pnlRendezVous.Controls.Add(this.lblRdvPremierRdv);
            this.pnlRendezVous.Controls.Add(this.lblRdvRaison);
            this.pnlRendezVous.Controls.Add(this.lblRdvDate);
            this.pnlRendezVous.Controls.Add(this.dtpRdvDate);
            this.pnlRendezVous.Controls.Add(this.button1);
            this.pnlRendezVous.Controls.Add(this.lblRdvCurrentPatient);
            this.pnlRendezVous.Controls.Add(this.lblListePatients);
            this.pnlRendezVous.Location = new System.Drawing.Point(289, 200);
            this.pnlRendezVous.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRendezVous.Name = "pnlRendezVous";
            this.pnlRendezVous.Size = new System.Drawing.Size(1265, 556);
            this.pnlRendezVous.TabIndex = 4;
            // 
            // lblRdvNotes
            // 
            this.lblRdvNotes.AutoSize = true;
            this.lblRdvNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvNotes.Location = new System.Drawing.Point(67, 566);
            this.lblRdvNotes.Name = "lblRdvNotes";
            this.lblRdvNotes.Size = new System.Drawing.Size(89, 29);
            this.lblRdvNotes.TabIndex = 12;
            this.lblRdvNotes.Text = "Notes :";
            // 
            // lblRdvPremierRdv
            // 
            this.lblRdvPremierRdv.AutoSize = true;
            this.lblRdvPremierRdv.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvPremierRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvPremierRdv.Location = new System.Drawing.Point(67, 462);
            this.lblRdvPremierRdv.Name = "lblRdvPremierRdv";
            this.lblRdvPremierRdv.Size = new System.Drawing.Size(259, 29);
            this.lblRdvPremierRdv.TabIndex = 11;
            this.lblRdvPremierRdv.Text = "Première consultation :";
            // 
            // lblRdvRaison
            // 
            this.lblRdvRaison.AutoSize = true;
            this.lblRdvRaison.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvRaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvRaison.Location = new System.Drawing.Point(66, 356);
            this.lblRdvRaison.Name = "lblRdvRaison";
            this.lblRdvRaison.Size = new System.Drawing.Size(280, 29);
            this.lblRdvRaison.TabIndex = 10;
            this.lblRdvRaison.Text = "Raisons de consultation :";
            // 
            // lblRdvDate
            // 
            this.lblRdvDate.AutoSize = true;
            this.lblRdvDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvDate.Location = new System.Drawing.Point(66, 250);
            this.lblRdvDate.Name = "lblRdvDate";
            this.lblRdvDate.Size = new System.Drawing.Size(75, 29);
            this.lblRdvDate.TabIndex = 9;
            this.lblRdvDate.Text = "Date :";
            // 
            // dtpRdvDate
            // 
            this.dtpRdvDate.Location = new System.Drawing.Point(665, 250);
            this.dtpRdvDate.Name = "dtpRdvDate";
            this.dtpRdvDate.Size = new System.Drawing.Size(200, 31);
            this.dtpRdvDate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Changer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectionnerPatient_Click);
            // 
            // lblRdvCurrentPatient
            // 
            this.lblRdvCurrentPatient.AutoSize = true;
            this.lblRdvCurrentPatient.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvCurrentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvCurrentPatient.Location = new System.Drawing.Point(66, 81);
            this.lblRdvCurrentPatient.Name = "lblRdvCurrentPatient";
            this.lblRdvCurrentPatient.Size = new System.Drawing.Size(412, 31);
            this.lblRdvCurrentPatient.TabIndex = 6;
            this.lblRdvCurrentPatient.Text = "ERREUR : Pas de patient actif";
            // 
            // lblListePatients
            // 
            this.lblListePatients.AutoSize = true;
            this.lblListePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePatients.Location = new System.Drawing.Point(64, 19);
            this.lblListePatients.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListePatients.Name = "lblListePatients";
            this.lblListePatients.Size = new System.Drawing.Size(466, 37);
            this.lblListePatients.TabIndex = 2;
            this.lblListePatients.Text = "Programmer une consultation";
            // 
            // grbRdvRaison
            // 
            this.grbRdvRaison.Controls.Add(this.rdbRdvRaisonPbMedical);
            this.grbRdvRaison.Controls.Add(this.rdbRdvRaisonVisiteRoutine);
            this.grbRdvRaison.Location = new System.Drawing.Point(665, 326);
            this.grbRdvRaison.Name = "grbRdvRaison";
            this.grbRdvRaison.Size = new System.Drawing.Size(528, 74);
            this.grbRdvRaison.TabIndex = 14;
            this.grbRdvRaison.TabStop = false;
            // 
            // rdbRdvRaisonVisiteRoutine
            // 
            this.rdbRdvRaisonVisiteRoutine.AutoSize = true;
            this.rdbRdvRaisonVisiteRoutine.Location = new System.Drawing.Point(32, 27);
            this.rdbRdvRaisonVisiteRoutine.Name = "rdbRdvRaisonVisiteRoutine";
            this.rdbRdvRaisonVisiteRoutine.Size = new System.Drawing.Size(198, 29);
            this.rdbRdvRaisonVisiteRoutine.TabIndex = 0;
            this.rdbRdvRaisonVisiteRoutine.TabStop = true;
            this.rdbRdvRaisonVisiteRoutine.Text = "Visite de routine";
            this.rdbRdvRaisonVisiteRoutine.UseVisualStyleBackColor = true;
            // 
            // rdbRdvRaisonPbMedical
            // 
            this.rdbRdvRaisonPbMedical.AutoSize = true;
            this.rdbRdvRaisonPbMedical.Location = new System.Drawing.Point(282, 27);
            this.rdbRdvRaisonPbMedical.Name = "rdbRdvRaisonPbMedical";
            this.rdbRdvRaisonPbMedical.Size = new System.Drawing.Size(214, 29);
            this.rdbRdvRaisonPbMedical.TabIndex = 1;
            this.rdbRdvRaisonPbMedical.TabStop = true;
            this.rdbRdvRaisonPbMedical.Text = "Problème médical";
            this.rdbRdvRaisonPbMedical.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRdvPremiereConsultNon);
            this.groupBox1.Controls.Add(this.rdbRdvPremiereConsultOui);
            this.groupBox1.Location = new System.Drawing.Point(665, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rdbRdvPremiereConsultNon
            // 
            this.rdbRdvPremiereConsultNon.AutoSize = true;
            this.rdbRdvPremiereConsultNon.Location = new System.Drawing.Point(282, 27);
            this.rdbRdvPremiereConsultNon.Name = "rdbRdvPremiereConsultNon";
            this.rdbRdvPremiereConsultNon.Size = new System.Drawing.Size(82, 29);
            this.rdbRdvPremiereConsultNon.TabIndex = 1;
            this.rdbRdvPremiereConsultNon.TabStop = true;
            this.rdbRdvPremiereConsultNon.Text = "Non";
            this.rdbRdvPremiereConsultNon.UseVisualStyleBackColor = true;
            // 
            // rdbRdvPremiereConsultOui
            // 
            this.rdbRdvPremiereConsultOui.AutoSize = true;
            this.rdbRdvPremiereConsultOui.Location = new System.Drawing.Point(32, 27);
            this.rdbRdvPremiereConsultOui.Name = "rdbRdvPremiereConsultOui";
            this.rdbRdvPremiereConsultOui.Size = new System.Drawing.Size(76, 29);
            this.rdbRdvPremiereConsultOui.TabIndex = 0;
            this.rdbRdvPremiereConsultOui.TabStop = true;
            this.rdbRdvPremiereConsultOui.Text = "Oui";
            this.rdbRdvPremiereConsultOui.UseVisualStyleBackColor = true;
            // 
            // rtbRdvNotes
            // 
            this.rtbRdvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRdvNotes.Location = new System.Drawing.Point(665, 564);
            this.rtbRdvNotes.Name = "rtbRdvNotes";
            this.rtbRdvNotes.Size = new System.Drawing.Size(550, 266);
            this.rtbRdvNotes.TabIndex = 16;
            this.rtbRdvNotes.Text = "";
            // 
            // PanelCreationEnvironnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1759);
            this.Controls.Add(this.pnlRendezVous);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PanelCreationEnvironnement";
            this.Text = "PanelCreationEnvironnement";
            this.Load += new System.EventHandler(this.PanelCreationEnvironnement_Load);
            this.pnlRendezVous.ResumeLayout(false);
            this.pnlRendezVous.PerformLayout();
            this.grbRdvRaison.ResumeLayout(false);
            this.grbRdvRaison.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRendezVous;
        private System.Windows.Forms.Label lblListePatients;
        private System.Windows.Forms.Label lblRdvCurrentPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRdvNotes;
        private System.Windows.Forms.Label lblRdvPremierRdv;
        private System.Windows.Forms.Label lblRdvRaison;
        private System.Windows.Forms.Label lblRdvDate;
        private System.Windows.Forms.DateTimePicker dtpRdvDate;
        private System.Windows.Forms.RichTextBox rtbRdvNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRdvPremiereConsultNon;
        private System.Windows.Forms.RadioButton rdbRdvPremiereConsultOui;
        private System.Windows.Forms.GroupBox grbRdvRaison;
        private System.Windows.Forms.RadioButton rdbRdvRaisonPbMedical;
        private System.Windows.Forms.RadioButton rdbRdvRaisonVisiteRoutine;
    }
}