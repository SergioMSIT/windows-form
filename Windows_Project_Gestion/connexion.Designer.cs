﻿namespace Windows_Project_GestionPAGE1
{
    partial class connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.texteconnextion = new System.Windows.Forms.Label();
            this.motdepasse = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.LensShop = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 26);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texteconnextion
            // 
            this.texteconnextion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.texteconnextion.AutoSize = true;
            this.texteconnextion.BackColor = System.Drawing.Color.Transparent;
            this.texteconnextion.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteconnextion.ForeColor = System.Drawing.Color.Silver;
            this.texteconnextion.Location = new System.Drawing.Point(149, 221);
            this.texteconnextion.Name = "texteconnextion";
            this.texteconnextion.Size = new System.Drawing.Size(82, 36);
            this.texteconnextion.TabIndex = 1;
            this.texteconnextion.Text = "Email";
            this.texteconnextion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motdepasse
            // 
            this.motdepasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.motdepasse.AutoSize = true;
            this.motdepasse.BackColor = System.Drawing.Color.Transparent;
            this.motdepasse.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdepasse.ForeColor = System.Drawing.Color.Silver;
            this.motdepasse.Location = new System.Drawing.Point(107, 300);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(185, 36);
            this.motdepasse.TabIndex = 5;
            this.motdepasse.Text = "Mot de passe";
            this.motdepasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(786, 448);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "CONNEXION";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(608, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "ANNULER";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMDP
            // 
            this.txtMDP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMDP.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDP.Location = new System.Drawing.Point(30, 343);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(350, 26);
            this.txtMDP.TabIndex = 2;
            this.txtMDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LensShop
            // 
            this.LensShop.AutoSize = true;
            this.LensShop.BackColor = System.Drawing.Color.Transparent;
            this.LensShop.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LensShop.LinkColor = System.Drawing.Color.Gray;
            this.LensShop.Location = new System.Drawing.Point(35, 118);
            this.LensShop.Name = "LensShop";
            this.LensShop.Size = new System.Drawing.Size(343, 78);
            this.LensShop.TabIndex = 6;
            this.LensShop.TabStop = true;
            this.LensShop.Text = "LensShop";
            this.LensShop.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // connexion
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Windows_Project_GestionPAGE1.Properties.Resources.l_series_promo_product_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(970, 501);
            this.Controls.Add(this.LensShop);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.texteconnextion);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Franprix";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texte;
        private System.Windows.Forms.Label affichage;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label texteconnextion;
        private System.Windows.Forms.Label motdepasse;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.LinkLabel LensShop;
    }
}

