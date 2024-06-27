using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banque_application.disign
{
    public partial class payementPret : UserControl
    {
        service_personnel sp = new service_personnel();


        private Button btnValiderPaye;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private ComboBox txtDevise;
        private RichTextBox txtNumCompte;
        private RichTextBox txtMontantCredit;
        private Label label12;
        private RichTextBox txtAdresse;
        private Label label18;
        private Label label16;
        private RichTextBox txtPhone;
        private Label label8;
        private RichTextBox txtPrenom;
        private Label label7;
        private RichTextBox txtNom;
        private Label label6;
        private Label label4;
        private Label label5;

        public payementPret()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnValiderPaye = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtDevise = new System.Windows.Forms.ComboBox();
            this.txtNumCompte = new System.Windows.Forms.RichTextBox();
            this.txtMontantCredit = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValiderPaye
            // 
            this.btnValiderPaye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnValiderPaye.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderPaye.ForeColor = System.Drawing.Color.White;
            this.btnValiderPaye.Location = new System.Drawing.Point(522, 646);
            this.btnValiderPaye.Name = "btnValiderPaye";
            this.btnValiderPaye.Size = new System.Drawing.Size(396, 47);
            this.btnValiderPaye.TabIndex = 87;
            this.btnValiderPaye.Text = "Valider";
            this.btnValiderPaye.UseVisualStyleBackColor = false;
            this.btnValiderPaye.Click += new System.EventHandler(this.btnValiderPaye_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::banque_application.Properties.Resources.téléchargement__1_;
            this.pictureBox6.Location = new System.Drawing.Point(1059, 654);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::banque_application.Properties.Resources.Premium_Photo___Dollar_Sign_Isolated_Dolar_symbol_on_Round_green_icon_3D_rendering;
            this.pictureBox8.Location = new System.Drawing.Point(1059, 525);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(90, 76);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 83;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::banque_application.Properties.Resources.Logo_Du_Comptable_PNG___Compte__Comptable__La_Comptabilité_PNG_et_vecteur_pour_téléchargement_gratuit;
            this.pictureBox5.Location = new System.Drawing.Point(1059, 384);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::banque_application.Properties.Resources._0fb444f0_d206_497a_96cc_b7467f7b563b;
            this.pictureBox4.Location = new System.Drawing.Point(1059, 245);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1059, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // txtDevise
            // 
            this.txtDevise.FormattingEnabled = true;
            this.txtDevise.Items.AddRange(new object[] {
            "USD",
            "FC"});
            this.txtDevise.Location = new System.Drawing.Point(71, 665);
            this.txtDevise.Name = "txtDevise";
            this.txtDevise.Size = new System.Drawing.Size(397, 28);
            this.txtDevise.TabIndex = 81;
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Location = new System.Drawing.Point(71, 566);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(847, 40);
            this.txtNumCompte.TabIndex = 74;
            this.txtNumCompte.Text = "";
            // 
            // txtMontantCredit
            // 
            this.txtMontantCredit.Location = new System.Drawing.Point(71, 474);
            this.txtMontantCredit.Name = "txtMontantCredit";
            this.txtMontantCredit.Size = new System.Drawing.Size(847, 40);
            this.txtMontantCredit.TabIndex = 71;
            this.txtMontantCredit.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 22);
            this.label12.TabIndex = 66;
            this.label12.Text = "Devise";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(72, 290);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(847, 40);
            this.txtAdresse.TabIndex = 73;
            this.txtAdresse.Text = "";
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(67, 543);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 22);
            this.label18.TabIndex = 65;
            this.label18.Text = "Numéro de compte";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(67, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 22);
            this.label16.TabIndex = 63;
            this.label16.Text = "Montant Payé";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(71, 377);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(847, 40);
            this.txtPhone.TabIndex = 78;
            this.txtPhone.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 59;
            this.label8.Text = "Adresse";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 208);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(847, 40);
            this.txtPrenom.TabIndex = 80;
            this.txtPrenom.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 58;
            this.label7.Text = "Téléphone";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(71, 125);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(847, 40);
            this.txtNom.TabIndex = 79;
            this.txtNom.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(67, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Informations Personnelles";
            // 
            // payementPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValiderPaye);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtDevise);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.txtMontantCredit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "payementPret";
            this.Size = new System.Drawing.Size(1213, 836);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnValiderPaye_Click(object sender, EventArgs e)
        {
            getDataRetrait();
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            txtChangeAdresse();
        }
    }
}
