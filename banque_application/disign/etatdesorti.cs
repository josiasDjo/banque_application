using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque_application
{
    public partial class etatDeSorti : UserControl
    {
        private Label label1;
        private Label transactionId;
        private Label NomOut;
        private Label PrenomOut;
        private Label montantTot;
        private Label label2;
        private Label adresseOut;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label phoneOut;
        private Label label6;
        private Label factureN;
        private Label label7;
        private Label dateOut;
        private Label label9;
        private Label label8;
        private Label typeTrans;
        private Label label10;
        private Label montantSolde;
        private PictureBox pictureBox1;

        public etatDeSorti()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionId = new System.Windows.Forms.Label();
            this.NomOut = new System.Windows.Forms.Label();
            this.PrenomOut = new System.Windows.Forms.Label();
            this.montantTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adresseOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.factureN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.typeTrans = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.montantSolde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::banque_application.Properties.Resources.logo_bank_no_bg;
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "A l\'attention de : ";
            // 
            // transactionId
            // 
            this.transactionId.AutoSize = true;
            this.transactionId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionId.Location = new System.Drawing.Point(257, 357);
            this.transactionId.Name = "transactionId";
            this.transactionId.Size = new System.Drawing.Size(55, 22);
            this.transactionId.TabIndex = 3;
            this.transactionId.Text = "transt";
            // 
            // NomOut
            // 
            this.NomOut.AutoSize = true;
            this.NomOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomOut.Location = new System.Drawing.Point(138, 216);
            this.NomOut.Name = "NomOut";
            this.NomOut.Size = new System.Drawing.Size(47, 22);
            this.NomOut.TabIndex = 3;
            this.NomOut.Text = "Nom";
            // 
            // PrenomOut
            // 
            this.PrenomOut.AutoSize = true;
            this.PrenomOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomOut.Location = new System.Drawing.Point(681, 216);
            this.PrenomOut.Name = "PrenomOut";
            this.PrenomOut.Size = new System.Drawing.Size(70, 22);
            this.PrenomOut.TabIndex = 3;
            this.PrenomOut.Text = "Prenom";
            // 
            // montantTot
            // 
            this.montantTot.AutoSize = true;
            this.montantTot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantTot.Location = new System.Drawing.Point(355, 406);
            this.montantTot.Name = "montantTot";
            this.montantTot.Size = new System.Drawing.Size(103, 22);
            this.montantTot.TabIndex = 3;
            this.montantTot.Text = "montantTot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse : ";
            // 
            // adresseOut
            // 
            this.adresseOut.AutoSize = true;
            this.adresseOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseOut.Location = new System.Drawing.Point(176, 259);
            this.adresseOut.Name = "adresseOut";
            this.adresseOut.Size = new System.Drawing.Size(89, 22);
            this.adresseOut.TabIndex = 3;
            this.adresseOut.Text = "Adresse : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Téléphone : ";
            // 
            // phoneOut
            // 
            this.phoneOut.AutoSize = true;
            this.phoneOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneOut.Location = new System.Drawing.Point(717, 259);
            this.phoneOut.Name = "phoneOut";
            this.phoneOut.Size = new System.Drawing.Size(71, 22);
            this.phoneOut.TabIndex = 3;
            this.phoneOut.Text = "phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Facture N° : ";
            // 
            // factureN
            // 
            this.factureN.AutoSize = true;
            this.factureN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factureN.Location = new System.Drawing.Point(195, 325);
            this.factureN.Name = "factureN";
            this.factureN.Size = new System.Drawing.Size(105, 22);
            this.factureN.TabIndex = 3;
            this.factureN.Text = "facture num";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Référence de Déôt : ";
            // 
            // dateOut
            // 
            this.dateOut.AutoSize = true;
            this.dateOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOut.Location = new System.Drawing.Point(806, 616);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(44, 22);
            this.dateOut.TabIndex = 3;
            this.dateOut.Text = "date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Type de transaction : ";
            // 
            // typeTrans
            // 
            this.typeTrans.AutoSize = true;
            this.typeTrans.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTrans.Location = new System.Drawing.Point(268, 482);
            this.typeTrans.Name = "typeTrans";
            this.typeTrans.Size = new System.Drawing.Size(89, 22);
            this.typeTrans.TabIndex = 3;
            this.typeTrans.Text = "type trans";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Montant : ";
            // 
            // montantSolde
            // 
            this.montantSolde.AutoSize = true;
            this.montantSolde.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantSolde.Location = new System.Drawing.Point(268, 524);
            this.montantSolde.Name = "montantSolde";
            this.montantSolde.Size = new System.Drawing.Size(76, 22);
            this.montantSolde.TabIndex = 3;
            this.montantSolde.Text = "montant";
            // 
            // etatDeSorti
            // 
            this.Controls.Add(this.montantTot);
            this.Controls.Add(this.phoneOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresseOut);
            this.Controls.Add(this.montantSolde);
            this.Controls.Add(this.typeTrans);
            this.Controls.Add(this.factureN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrenomOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.NomOut);
            this.Controls.Add(this.transactionId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "etatDeSorti";
            this.Size = new System.Drawing.Size(1084, 657);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
