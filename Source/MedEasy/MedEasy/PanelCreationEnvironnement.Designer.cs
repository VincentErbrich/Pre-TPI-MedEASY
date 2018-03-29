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
            this.pnlPatientss = new System.Windows.Forms.Panel();
            this.lblListePatients = new System.Windows.Forms.Label();
            this.tblPatients = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientss.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientss
            // 
            this.pnlPatientss.AutoScroll = true;
            this.pnlPatientss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatientss.Controls.Add(this.lblListePatients);
            this.pnlPatientss.Controls.Add(this.tblPatients);
            this.pnlPatientss.Location = new System.Drawing.Point(184, 190);
            this.pnlPatientss.Name = "pnlPatientss";
            this.pnlPatientss.Size = new System.Drawing.Size(1265, 556);
            this.pnlPatientss.TabIndex = 4;
            // 
            // lblListePatients
            // 
            this.lblListePatients.AutoSize = true;
            this.lblListePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePatients.Location = new System.Drawing.Point(32, 10);
            this.lblListePatients.Name = "lblListePatients";
            this.lblListePatients.Size = new System.Drawing.Size(152, 20);
            this.lblListePatients.TabIndex = 2;
            this.lblListePatients.Text = "Liste des patients";
            // 
            // tblPatients
            // 
            this.tblPatients.AutoSize = true;
            this.tblPatients.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblPatients.ColumnCount = 5;
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatients.Location = new System.Drawing.Point(36, 53);
            this.tblPatients.Name = "tblPatients";
            this.tblPatients.RowCount = 1;
            this.tblPatients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblPatients.Size = new System.Drawing.Size(1156, 112);
            this.tblPatients.TabIndex = 1;
            // 
            // PanelCreationEnvironnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 937);
            this.Controls.Add(this.pnlPatientss);
            this.Name = "PanelCreationEnvironnement";
            this.Text = "PanelCreationEnvironnement";
            this.pnlPatientss.ResumeLayout(false);
            this.pnlPatientss.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientss;
        private System.Windows.Forms.Label lblListePatients;
        private System.Windows.Forms.TableLayoutPanel tblPatients;
    }
}