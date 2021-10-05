namespace Scaldadita
{
    partial class frmGioco
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioco));
            this.label1 = new System.Windows.Forms.Label();
            this.lblParolaCorrente = new System.Windows.Forms.Label();
            this.lblProssimaParola = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWPM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCPM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrate = new System.Windows.Forms.Label();
            this.mioTimer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblBattuti = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBackspace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.dgvParole = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCharErrati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParole)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAROLA CORRENTE";
            // 
            // lblParolaCorrente
            // 
            this.lblParolaCorrente.AutoSize = true;
            this.lblParolaCorrente.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParolaCorrente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParolaCorrente.Location = new System.Drawing.Point(12, 68);
            this.lblParolaCorrente.Name = "lblParolaCorrente";
            this.lblParolaCorrente.Size = new System.Drawing.Size(0, 29);
            this.lblParolaCorrente.TabIndex = 2;
            this.lblParolaCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProssimaParola
            // 
            this.lblProssimaParola.AutoSize = true;
            this.lblProssimaParola.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProssimaParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProssimaParola.Location = new System.Drawing.Point(512, 68);
            this.lblProssimaParola.Name = "lblProssimaParola";
            this.lblProssimaParola.Size = new System.Drawing.Size(0, 29);
            this.lblProssimaParola.TabIndex = 4;
            this.lblProssimaParola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "PAROLA SUCCESSIVA";
            // 
            // txtInputParola
            // 
            this.txtInputParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputParola.Location = new System.Drawing.Point(12, 233);
            this.txtInputParola.Name = "txtInputParola";
            this.txtInputParola.Size = new System.Drawing.Size(801, 31);
            this.txtInputParola.TabIndex = 5;
            this.txtInputParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputParola.TextChanged += new System.EventHandler(this.txtInputParola_TextChanged);
            this.txtInputParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputParola_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Statistiche provvisorie";
            // 
            // lblWPM
            // 
            this.lblWPM.AutoSize = true;
            this.lblWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWPM.Location = new System.Drawing.Point(306, 372);
            this.lblWPM.Name = "lblWPM";
            this.lblWPM.Size = new System.Drawing.Size(0, 25);
            this.lblWPM.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parole al minuto (WPM):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Caratteri al minuto (CPM):";
            // 
            // lblCPM
            // 
            this.lblCPM.AutoSize = true;
            this.lblCPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPM.Location = new System.Drawing.Point(306, 397);
            this.lblCPM.Name = "lblCPM";
            this.lblCPM.Size = new System.Drawing.Size(0, 25);
            this.lblCPM.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Parole errate:";
            // 
            // lblErrate
            // 
            this.lblErrate.AutoSize = true;
            this.lblErrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrate.Location = new System.Drawing.Point(306, 422);
            this.lblErrate.Name = "lblErrate";
            this.lblErrate.Size = new System.Drawing.Size(0, 25);
            this.lblErrate.TabIndex = 11;
            // 
            // mioTimer
            // 
            this.mioTimer.Interval = 1000;
            this.mioTimer.Tick += new System.EventHandler(this.mioTimer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Caratteri battuti:";
            // 
            // lblBattuti
            // 
            this.lblBattuti.AutoSize = true;
            this.lblBattuti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattuti.Location = new System.Drawing.Point(679, 398);
            this.lblBattuti.Name = "lblBattuti";
            this.lblBattuti.Size = new System.Drawing.Size(0, 25);
            this.lblBattuti.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Numero di pressioni \"Backspace\":";
            // 
            // lblBackspace
            // 
            this.lblBackspace.AutoSize = true;
            this.lblBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackspace.Location = new System.Drawing.Point(679, 373);
            this.lblBackspace.Name = "lblBackspace";
            this.lblBackspace.Size = new System.Drawing.Size(0, 25);
            this.lblBackspace.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Secondi rimanenti:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Red;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(494, 276);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 25);
            this.lblTempo.TabIndex = 18;
            // 
            // dgvParole
            // 
            this.dgvParole.AllowUserToAddRows = false;
            this.dgvParole.AllowUserToDeleteRows = false;
            this.dgvParole.AllowUserToResizeColumns = false;
            this.dgvParole.AllowUserToResizeRows = false;
            this.dgvParole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParole.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParole.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParole.Location = new System.Drawing.Point(12, 137);
            this.dgvParole.Name = "dgvParole";
            this.dgvParole.ReadOnly = true;
            this.dgvParole.RowHeadersVisible = false;
            this.dgvParole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvParole.Size = new System.Drawing.Size(800, 80);
            this.dgvParole.TabIndex = 19;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(542, 426);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(131, 20);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "Caratteri errati:";
            // 
            // lblCharErrati
            // 
            this.lblCharErrati.AutoSize = true;
            this.lblCharErrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharErrati.Location = new System.Drawing.Point(679, 422);
            this.lblCharErrati.Name = "lblCharErrati";
            this.lblCharErrati.Size = new System.Drawing.Size(0, 25);
            this.lblCharErrati.TabIndex = 29;
            // 
            // frmGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(825, 491);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblCharErrati);
            this.Controls.Add(this.dgvParole);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBattuti);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBackspace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblErrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputParola);
            this.Controls.Add(this.lblProssimaParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblParolaCorrente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGioco";
            this.Text = "SCALDADITA";
            this.Load += new System.EventHandler(this.frmGioco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParolaCorrente;
        private System.Windows.Forms.Label lblProssimaParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrate;
        private System.Windows.Forms.Timer mioTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBattuti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBackspace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.DataGridView dgvParole;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCharErrati;
    }
}

