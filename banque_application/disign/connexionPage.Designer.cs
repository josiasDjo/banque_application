namespace banque_application.disign
{
    partial class connexionPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFonction = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenomDeb = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomDeb = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnValiderConnexion = new System.Windows.Forms.Button();
            this.txtMotDePasseDeb = new System.Windows.Forms.MaskedTextBox();
            this.showpswd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showpswd);
            this.panel1.Controls.Add(this.txtMotDePasseDeb);
            this.panel1.Controls.Add(this.txtFonction);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrenomDeb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomDeb);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnValiderConnexion);
            this.panel1.Location = new System.Drawing.Point(525, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 642);
            this.panel1.TabIndex = 1;
            // 
            // txtFonction
            // 
            this.txtFonction.FormattingEnabled = true;
            this.txtFonction.Items.AddRange(new object[] {
            "Directeur de Banque",
            "Directeur Adjoint",
            "Conseiller Financier",
            "Responsable des Ressources Humaines",
            "Guichetier",
            "Caissier",
            "Technicien Informatique"});
            this.txtFonction.Location = new System.Drawing.Point(70, 414);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(347, 28);
            this.txtFonction.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::banque_application.Properties.Resources.logo_bank_no_bg;
            this.pictureBox1.Location = new System.Drawing.Point(162, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Fonction";
            // 
            // txtPrenomDeb
            // 
            this.txtPrenomDeb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomDeb.Location = new System.Drawing.Point(70, 255);
            this.txtPrenomDeb.Name = "txtPrenomDeb";
            this.txtPrenomDeb.Size = new System.Drawing.Size(347, 38);
            this.txtPrenomDeb.TabIndex = 58;
            this.txtPrenomDeb.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Prénom";
            // 
            // txtNomDeb
            // 
            this.txtNomDeb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDeb.Location = new System.Drawing.Point(70, 182);
            this.txtNomDeb.Name = "txtNomDeb";
            this.txtNomDeb.Size = new System.Drawing.Size(347, 38);
            this.txtNomDeb.TabIndex = 59;
            this.txtNomDeb.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Nom";
            // 
            // btnValiderConnexion
            // 
            this.btnValiderConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnValiderConnexion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderConnexion.ForeColor = System.Drawing.Color.White;
            this.btnValiderConnexion.Location = new System.Drawing.Point(70, 470);
            this.btnValiderConnexion.MinimumSize = new System.Drawing.Size(287, 42);
            this.btnValiderConnexion.Name = "btnValiderConnexion";
            this.btnValiderConnexion.Size = new System.Drawing.Size(347, 42);
            this.btnValiderConnexion.TabIndex = 53;
            this.btnValiderConnexion.Text = "Valider";
            this.btnValiderConnexion.UseVisualStyleBackColor = false;
            this.btnValiderConnexion.Click += new System.EventHandler(this.btnValiderTransfere_Click);
            // 
            // txtMotDePasseDeb
            // 
            this.txtMotDePasseDeb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasseDeb.Location = new System.Drawing.Point(70, 338);
            this.txtMotDePasseDeb.Name = "txtMotDePasseDeb";
            this.txtMotDePasseDeb.PasswordChar = '*';
            this.txtMotDePasseDeb.Size = new System.Drawing.Size(347, 29);
            this.txtMotDePasseDeb.TabIndex = 155;
            // 
            // showpswd
            // 
            this.showpswd.BackColor = System.Drawing.Color.Gray;
            this.showpswd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpswd.ForeColor = System.Drawing.Color.White;
            this.showpswd.Location = new System.Drawing.Point(334, 334);
            this.showpswd.Name = "showpswd";
            this.showpswd.Size = new System.Drawing.Size(83, 37);
            this.showpswd.TabIndex = 156;
            this.showpswd.Text = "Montrer";
            this.showpswd.UseVisualStyleBackColor = false;
            this.showpswd.Click += new System.EventHandler(this.showpswd_Click_1);
            // 
            // connexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::banque_application.Properties.Resources.buy_real_instagram_followers_https___buyrealsocialmarketing_com_instagram;
            this.Controls.Add(this.panel1);
            this.Name = "connexionPage";
            this.Size = new System.Drawing.Size(1501, 836);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtFonction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtPrenomDeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNomDeb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnValiderConnexion;
        private System.Windows.Forms.Button showpswd;
        private System.Windows.Forms.MaskedTextBox txtMotDePasseDeb;
    }
}
