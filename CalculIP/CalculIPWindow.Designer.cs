namespace CalculIP
{
    partial class CalculIPWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculIPWindow));
            this.CalculBroadcastIP = new System.Windows.Forms.GroupBox();
            this.label_NB_SousReseaux = new System.Windows.Forms.Label();
            this.TB_NB_SousReseaux = new System.Windows.Forms.TextBox();
            this.label_NB_MAchine = new System.Windows.Forms.Label();
            this.TB_NB_Machines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ResultatCSR_AdresseIP = new System.Windows.Forms.TextBox();
            this.TB_ResultatCSR_Broadcast = new System.Windows.Forms.TextBox();
            this.Resultat1 = new System.Windows.Forms.Label();
            this.TB_MasqueSR = new System.Windows.Forms.TextBox();
            this.TB_AdresseIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CombolistCIDR = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_resultatMasque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalculBroadcastIP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculBroadcastIP
            // 
            this.CalculBroadcastIP.BackColor = System.Drawing.Color.Transparent;
            this.CalculBroadcastIP.Controls.Add(this.label_NB_SousReseaux);
            this.CalculBroadcastIP.Controls.Add(this.TB_NB_SousReseaux);
            this.CalculBroadcastIP.Controls.Add(this.label_NB_MAchine);
            this.CalculBroadcastIP.Controls.Add(this.TB_NB_Machines);
            this.CalculBroadcastIP.Controls.Add(this.label3);
            this.CalculBroadcastIP.Controls.Add(this.label4);
            this.CalculBroadcastIP.Controls.Add(this.label2);
            this.CalculBroadcastIP.Controls.Add(this.label1);
            this.CalculBroadcastIP.Controls.Add(this.TB_ResultatCSR_AdresseIP);
            this.CalculBroadcastIP.Controls.Add(this.TB_ResultatCSR_Broadcast);
            this.CalculBroadcastIP.Controls.Add(this.Resultat1);
            this.CalculBroadcastIP.Controls.Add(this.TB_MasqueSR);
            this.CalculBroadcastIP.Controls.Add(this.TB_AdresseIP);
            this.CalculBroadcastIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculBroadcastIP.Location = new System.Drawing.Point(4, 108);
            this.CalculBroadcastIP.Name = "CalculBroadcastIP";
            this.CalculBroadcastIP.Size = new System.Drawing.Size(323, 208);
            this.CalculBroadcastIP.TabIndex = 0;
            this.CalculBroadcastIP.TabStop = false;
            this.CalculBroadcastIP.Text = "Calcul Broadcast et adresse IP";
            // 
            // label_NB_SousReseaux
            // 
            this.label_NB_SousReseaux.AutoSize = true;
            this.label_NB_SousReseaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NB_SousReseaux.Location = new System.Drawing.Point(6, 175);
            this.label_NB_SousReseaux.Name = "label_NB_SousReseaux";
            this.label_NB_SousReseaux.Size = new System.Drawing.Size(102, 13);
            this.label_NB_SousReseaux.TabIndex = 12;
            this.label_NB_SousReseaux.Text = "Nombre de machine";
            this.label_NB_SousReseaux.Visible = false;
            // 
            // TB_NB_SousReseaux
            // 
            this.TB_NB_SousReseaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NB_SousReseaux.Location = new System.Drawing.Point(174, 172);
            this.TB_NB_SousReseaux.Name = "TB_NB_SousReseaux";
            this.TB_NB_SousReseaux.ReadOnly = true;
            this.TB_NB_SousReseaux.Size = new System.Drawing.Size(129, 20);
            this.TB_NB_SousReseaux.TabIndex = 11;
            this.TB_NB_SousReseaux.Visible = false;
            // 
            // label_NB_MAchine
            // 
            this.label_NB_MAchine.AutoSize = true;
            this.label_NB_MAchine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NB_MAchine.Location = new System.Drawing.Point(6, 148);
            this.label_NB_MAchine.Name = "label_NB_MAchine";
            this.label_NB_MAchine.Size = new System.Drawing.Size(102, 13);
            this.label_NB_MAchine.TabIndex = 10;
            this.label_NB_MAchine.Text = "Nombre de machine";
            // 
            // TB_NB_Machines
            // 
            this.TB_NB_Machines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NB_Machines.Location = new System.Drawing.Point(174, 145);
            this.TB_NB_Machines.Name = "TB_NB_Machines";
            this.TB_NB_Machines.ReadOnly = true;
            this.TB_NB_Machines.Size = new System.Drawing.Size(129, 20);
            this.TB_NB_Machines.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresse de Broadcast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse réseau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Votre masque de sous réseau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Votre adresse IP";
            // 
            // TB_ResultatCSR_AdresseIP
            // 
            this.TB_ResultatCSR_AdresseIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ResultatCSR_AdresseIP.Location = new System.Drawing.Point(174, 92);
            this.TB_ResultatCSR_AdresseIP.Name = "TB_ResultatCSR_AdresseIP";
            this.TB_ResultatCSR_AdresseIP.ReadOnly = true;
            this.TB_ResultatCSR_AdresseIP.Size = new System.Drawing.Size(129, 20);
            this.TB_ResultatCSR_AdresseIP.TabIndex = 3;
            // 
            // TB_ResultatCSR_Broadcast
            // 
            this.TB_ResultatCSR_Broadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ResultatCSR_Broadcast.Location = new System.Drawing.Point(174, 118);
            this.TB_ResultatCSR_Broadcast.Name = "TB_ResultatCSR_Broadcast";
            this.TB_ResultatCSR_Broadcast.ReadOnly = true;
            this.TB_ResultatCSR_Broadcast.Size = new System.Drawing.Size(129, 20);
            this.TB_ResultatCSR_Broadcast.TabIndex = 4;
            // 
            // Resultat1
            // 
            this.Resultat1.AutoSize = true;
            this.Resultat1.Location = new System.Drawing.Point(6, 72);
            this.Resultat1.Name = "Resultat1";
            this.Resultat1.Size = new System.Drawing.Size(54, 13);
            this.Resultat1.TabIndex = 2;
            this.Resultat1.Text = "Résultat";
            // 
            // TB_MasqueSR
            // 
            this.TB_MasqueSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MasqueSR.Location = new System.Drawing.Point(174, 45);
            this.TB_MasqueSR.Name = "TB_MasqueSR";
            this.TB_MasqueSR.Size = new System.Drawing.Size(129, 20);
            this.TB_MasqueSR.TabIndex = 1;
            this.TB_MasqueSR.TextChanged += new System.EventHandler(this.TB_MasqueSR_TextChanged);
            this.TB_MasqueSR.Leave += new System.EventHandler(this.TB_MasqueSR_Leave);
            // 
            // TB_AdresseIP
            // 
            this.TB_AdresseIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_AdresseIP.Location = new System.Drawing.Point(174, 19);
            this.TB_AdresseIP.Name = "TB_AdresseIP";
            this.TB_AdresseIP.Size = new System.Drawing.Size(129, 20);
            this.TB_AdresseIP.TabIndex = 0;
            this.TB_AdresseIP.TextChanged += new System.EventHandler(this.TB_AdresseIP_TextChanged);
            this.TB_AdresseIP.Leave += new System.EventHandler(this.TB_AdresseIP_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CombolistCIDR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TB_resultatMasque);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcul Masque";
            // 
            // CombolistCIDR
            // 
            this.CombolistCIDR.BackColor = System.Drawing.SystemColors.Window;
            this.CombolistCIDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombolistCIDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CombolistCIDR.FormattingEnabled = true;
            this.CombolistCIDR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CombolistCIDR.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.CombolistCIDR.Location = new System.Drawing.Point(174, 16);
            this.CombolistCIDR.Name = "CombolistCIDR";
            this.CombolistCIDR.Size = new System.Drawing.Size(129, 21);
            this.CombolistCIDR.TabIndex = 7;
            this.CombolistCIDR.SelectedIndexChanged += new System.EventHandler(this.CombolistCIDR_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Longueur du masque";
            // 
            // TB_resultatMasque
            // 
            this.TB_resultatMasque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_resultatMasque.Location = new System.Drawing.Point(174, 43);
            this.TB_resultatMasque.Name = "TB_resultatMasque";
            this.TB_resultatMasque.ReadOnly = true;
            this.TB_resultatMasque.Size = new System.Drawing.Size(129, 20);
            this.TB_resultatMasque.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Résultat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculIP.Properties.Resources.Conformit;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CalculIPWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalculBroadcastIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 800);
            this.Name = "CalculIPWindow";
            this.Text = "Calculateur d\'adresse IP";
            this.Load += new System.EventHandler(this.CalculIPWindow_Load);
            this.CalculBroadcastIP.ResumeLayout(false);
            this.CalculBroadcastIP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CalculBroadcastIP;
        private System.Windows.Forms.TextBox TB_AdresseIP;
        private System.Windows.Forms.TextBox TB_MasqueSR;
        private System.Windows.Forms.TextBox TB_ResultatCSR_AdresseIP;
        private System.Windows.Forms.TextBox TB_ResultatCSR_Broadcast;
        private System.Windows.Forms.Label Resultat1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_resultatMasque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CombolistCIDR;
        private System.Windows.Forms.Label label_NB_MAchine;
        private System.Windows.Forms.TextBox TB_NB_Machines;
        private System.Windows.Forms.Label label_NB_SousReseaux;
        private System.Windows.Forms.TextBox TB_NB_SousReseaux;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

