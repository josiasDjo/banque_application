﻿namespace banque_application
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumCompteDeb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneDeb = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomDeb = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnValiderTransfere = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtNumCompteDeb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPhoneDeb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomDeb);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnValiderTransfere);
            this.panel1.Location = new System.Drawing.Point(276, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 693);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Directeur Général",
            "Directeur du personnel",
            "Directeur des ressources humaines",
            "Guichetier",
            "Database Manager"});
            this.comboBox1.Location = new System.Drawing.Point(66, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 28);
            this.comboBox1.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::banque_application.Properties.Resources.Growth_Logo_Template1;
            this.pictureBox1.Location = new System.Drawing.Point(196, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumCompteDeb
            // 
            this.txtNumCompteDeb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCompteDeb.Location = new System.Drawing.Point(66, 370);
            this.txtNumCompteDeb.Name = "txtNumCompteDeb";
            this.txtNumCompteDeb.Size = new System.Drawing.Size(347, 38);
            this.txtNumCompteDeb.TabIndex = 57;
            this.txtNumCompteDeb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Fonction";
            // 
            // txtPhoneDeb
            // 
            this.txtPhoneDeb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneDeb.Location = new System.Drawing.Point(66, 288);
            this.txtPhoneDeb.Name = "txtPhoneDeb";
            this.txtPhoneDeb.Size = new System.Drawing.Size(347, 38);
            this.txtPhoneDeb.TabIndex = 58;
            this.txtPhoneDeb.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Prénom";
            // 
            // txtNomDeb
            // 
            this.txtNomDeb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDeb.Location = new System.Drawing.Point(66, 215);
            this.txtNomDeb.Name = "txtNomDeb";
            this.txtNomDeb.Size = new System.Drawing.Size(347, 38);
            this.txtNomDeb.TabIndex = 59;
            this.txtNomDeb.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Nom";
            // 
            // btnValiderTransfere
            // 
            this.btnValiderTransfere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnValiderTransfere.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderTransfere.ForeColor = System.Drawing.Color.White;
            this.btnValiderTransfere.Location = new System.Drawing.Point(90, 583);
            this.btnValiderTransfere.Name = "btnValiderTransfere";
            this.btnValiderTransfere.Size = new System.Drawing.Size(287, 42);
            this.btnValiderTransfere.TabIndex = 53;
            this.btnValiderTransfere.Text = "Valider";
            this.btnValiderTransfere.UseVisualStyleBackColor = false;
            this.btnValiderTransfere.Click += new System.EventHandler(this.btnValiderTransfere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::banque_application.Properties.Resources.buy_real_instagram_followers_https___buyrealsocialmarketing_com_instagram;
            this.ClientSize = new System.Drawing.Size(1006, 829);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Page de connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValiderTransfere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtNumCompteDeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtPhoneDeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNomDeb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

