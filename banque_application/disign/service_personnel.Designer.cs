using System;
using System.Drawing;

namespace banque_application.disign
{
    partial class service_personnel
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
            this.components = new System.ComponentModel.Container();
            this.btnValiderCredit = new System.Windows.Forms.Button();
            this.txtPhoneEm = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPostNomEm = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrenomEm = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomEm = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.txtdateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalaire = new System.Windows.Forms.RichTextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtPoste = new System.Windows.Forms.ComboBox();
            this.recherche = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnValiderCredit
            // 
            this.btnValiderCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnValiderCredit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCredit.ForeColor = System.Drawing.Color.White;
            this.btnValiderCredit.Location = new System.Drawing.Point(1032, 160);
            this.btnValiderCredit.Name = "btnValiderCredit";
            this.btnValiderCredit.Size = new System.Drawing.Size(263, 47);
            this.btnValiderCredit.TabIndex = 94;
            this.btnValiderCredit.Text = "Valider";
            this.btnValiderCredit.UseVisualStyleBackColor = false;
            this.btnValiderCredit.Click += new System.EventHandler(this.btnValiderCredit_Click);
            // 
            // txtPhoneEm
            // 
            this.txtPhoneEm.Location = new System.Drawing.Point(207, 376);
            this.txtPhoneEm.Name = "txtPhoneEm";
            this.txtPhoneEm.Size = new System.Drawing.Size(774, 40);
            this.txtPhoneEm.TabIndex = 82;
            this.txtPhoneEm.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(527, 615);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 28);
            this.label12.TabIndex = 81;
            this.label12.Text = "Date d\'embauche";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(206, 300);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(774, 40);
            this.txtAdresse.TabIndex = 83;
            this.txtAdresse.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 466);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 28);
            this.label18.TabIndex = 80;
            this.label18.Text = "Poste";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 382);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 28);
            this.label16.TabIndex = 79;
            this.label16.Text = "Téléphone";
            // 
            // txtPostNomEm
            // 
            this.txtPostNomEm.Location = new System.Drawing.Point(206, 160);
            this.txtPostNomEm.Name = "txtPostNomEm";
            this.txtPostNomEm.Size = new System.Drawing.Size(774, 40);
            this.txtPostNomEm.TabIndex = 85;
            this.txtPostNomEm.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 28);
            this.label8.TabIndex = 78;
            this.label8.Text = "Adresse";
            // 
            // txtPrenomEm
            // 
            this.txtPrenomEm.Location = new System.Drawing.Point(206, 231);
            this.txtPrenomEm.Name = "txtPrenomEm";
            this.txtPrenomEm.Size = new System.Drawing.Size(774, 40);
            this.txtPrenomEm.TabIndex = 87;
            this.txtPrenomEm.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 77;
            this.label7.Text = "Post-Nom";
            // 
            // txtNomEm
            // 
            this.txtNomEm.Location = new System.Drawing.Point(206, 85);
            this.txtNomEm.Name = "txtNomEm";
            this.txtNomEm.Size = new System.Drawing.Size(774, 40);
            this.txtNomEm.TabIndex = 86;
            this.txtNomEm.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 76;
            this.label6.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 75;
            this.label4.Text = "Nom";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "Informations Personnelles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Date de naissance";
            // 
            // txtdateEmbauche
            // 
            this.txtdateEmbauche.Location = new System.Drawing.Point(713, 614);
            this.txtdateEmbauche.Name = "txtdateEmbauche";
            this.txtdateEmbauche.Size = new System.Drawing.Size(267, 26);
            this.txtdateEmbauche.TabIndex = 95;
            // 
            // txtdateNaissance
            // 
            this.txtdateNaissance.Location = new System.Drawing.Point(206, 615);
            this.txtdateNaissance.Name = "txtdateNaissance";
            this.txtdateNaissance.Size = new System.Drawing.Size(278, 26);
            this.txtdateNaissance.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 80;
            this.label2.Text = "Salaire";
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(207, 531);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(774, 40);
            this.txtSalaire.TabIndex = 84;
            this.txtSalaire.Text = "";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(1032, 303);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(263, 47);
            this.btnValider.TabIndex = 147;
            this.btnValider.Text = "Modifier";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtPoste
            // 
            this.txtPoste.FormattingEnabled = true;
            this.txtPoste.Items.AddRange(new object[] {
            "Directeur de Banque",
            "Directeur Adjoint",
            "Conseiller Financier",
            "Responsable des Ressources Humaines",
            "Guichetier",
            "Caissier",
            "Technicien Informatique"});
            this.txtPoste.Location = new System.Drawing.Point(206, 460);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(774, 28);
            this.txtPoste.TabIndex = 148;
            // 
            // recherche
            // 
            this.recherche.ForeColor = System.Drawing.Color.Gray;
            this.recherche.Location = new System.Drawing.Point(1042, 99);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(253, 26);
            this.recherche.TabIndex = 149;
            this.recherche.Text = "Recherher ici ...";
            this.recherche.GotFocus += new System.EventHandler(this.RemovePlaceholder);
            this.recherche.LostFocus += new System.EventHandler(this.SetPlaceholder);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // service_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.txtPoste);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtdateNaissance);
            this.Controls.Add(this.txtdateEmbauche);
            this.Controls.Add(this.btnValiderCredit);
            this.Controls.Add(this.txtSalaire);
            this.Controls.Add(this.txtPhoneEm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPostNomEm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrenomEm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomEm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "service_personnel";
            this.Size = new System.Drawing.Size(1322, 784);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderCredit;
        private System.Windows.Forms.RichTextBox txtPhoneEm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtAdresse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtPostNomEm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtPrenomEm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNomEm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdateEmbauche;
        private System.Windows.Forms.DateTimePicker txtdateNaissance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSalaire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox txtPoste;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
