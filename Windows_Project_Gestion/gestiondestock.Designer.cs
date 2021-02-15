namespace Windows_Project_GestionPAGE1
{
    partial class gestionstock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionstock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.franprixgestionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franprix_gestionDataSet = new Windows_Project_GestionPAGE1.Franprix_gestionDataSet();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.categorieTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.CategorieTableAdapter();
            this.BtnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(944, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // franprixgestionDataSetBindingSource
            // 
            this.franprixgestionDataSetBindingSource.DataSource = this.franprix_gestionDataSet;
            this.franprixgestionDataSetBindingSource.Position = 0;
            // 
            // franprix_gestionDataSet
            // 
            this.franprix_gestionDataSet.DataSetName = "Franprix_gestionDataSet";
            this.franprix_gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeconnexion.Location = new System.Drawing.Point(983, 130);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(135, 39);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(983, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter un produit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModifier.Location = new System.Drawing.Point(983, 260);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(135, 39);
            this.BtnModifier.TabIndex = 8;
            this.BtnModifier.Text = "Modifer ce produit";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // gestionstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(136)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1130, 737);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion de stock";
            this.Load += new System.EventHandler(this.gestionstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource franprixgestionDataSetBindingSource;
        private Franprix_gestionDataSet franprix_gestionDataSet;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnAdd;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.Button BtnModifier;
    }
}