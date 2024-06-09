namespace banque_application
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
            this.panel1_ConnexionShow = new System.Windows.Forms.Panel();
            this.secondPanelAccueil = new System.Windows.Forms.Panel();
            this.panel1_ConnexionShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_ConnexionShow
            // 
            this.panel1_ConnexionShow.BackColor = System.Drawing.Color.White;
            this.panel1_ConnexionShow.Controls.Add(this.secondPanelAccueil);
            this.panel1_ConnexionShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_ConnexionShow.Location = new System.Drawing.Point(0, 0);
            this.panel1_ConnexionShow.Name = "panel1_ConnexionShow";
            this.panel1_ConnexionShow.Size = new System.Drawing.Size(1006, 1050);
            this.panel1_ConnexionShow.TabIndex = 0;
            // 
            // secondPanelAccueil
            // 
            this.secondPanelAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.secondPanelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPanelAccueil.Location = new System.Drawing.Point(0, 0);
            this.secondPanelAccueil.Name = "secondPanelAccueil";
            this.secondPanelAccueil.Size = new System.Drawing.Size(1006, 1050);
            this.secondPanelAccueil.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1006, 1050);
            this.Controls.Add(this.panel1_ConnexionShow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1028, 1006);
            this.Name = "Form1";
            this.Text = "GROWTH";
            this.panel1_ConnexionShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1_ConnexionShow;
        private System.Windows.Forms.Panel secondPanelAccueil;
        //public System.Windows.Forms.Panel panel1_Accueil_one_Show;
    }
}

