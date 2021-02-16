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
            this.tableAdapterManager1 = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.TableAdapterManager();
            this.produitTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.ProduitTableAdapter();
            this.dataGridViewgestiondestock = new System.Windows.Forms.DataGridView();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxcategorie = new System.Windows.Forms.ComboBox();
            this.stockcourantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutriscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgestiondestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1340, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 132);
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
            this.btnDeconnexion.Location = new System.Drawing.Point(1362, 140);
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
            this.btnAdd.Location = new System.Drawing.Point(1362, 185);
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
            this.BtnModifier.Location = new System.Drawing.Point(1362, 230);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(135, 39);
            this.BtnModifier.TabIndex = 8;
            this.BtnModifier.Text = "Modifer ce produit";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategorieTableAdapter = this.categorieTableAdapter;
            this.tableAdapterManager1.ConnexionTableAdapter = null;
            this.tableAdapterManager1.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewgestiondestock
            // 
            this.dataGridViewgestiondestock.AllowUserToOrderColumns = true;
            this.dataGridViewgestiondestock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewgestiondestock.AutoGenerateColumns = false;
            this.dataGridViewgestiondestock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewgestiondestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewgestiondestock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn,
            this.poidsDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.tailleDataGridViewTextBoxColumn,
            this.prixHTDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.presentationDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.nutriscoreDataGridViewTextBoxColumn,
            this.stockcourantDataGridViewTextBoxColumn});
            this.dataGridViewgestiondestock.DataSource = this.produitBindingSource;
            this.dataGridViewgestiondestock.GridColor = System.Drawing.Color.Black;
            this.dataGridViewgestiondestock.Location = new System.Drawing.Point(12, 498);
            this.dataGridViewgestiondestock.MultiSelect = false;
            this.dataGridViewgestiondestock.Name = "dataGridViewgestiondestock";
            this.dataGridViewgestiondestock.ReadOnly = true;
            this.dataGridViewgestiondestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewgestiondestock.RowTemplate.Height = 24;
            this.dataGridViewgestiondestock.Size = new System.Drawing.Size(1485, 275);
            this.dataGridViewgestiondestock.TabIndex = 9;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.franprixgestionDataSetBindingSource;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.franprixgestionDataSetBindingSource;
            // 
            // comboBoxcategorie
            // 
            this.comboBoxcategorie.FormattingEnabled = true;
            this.comboBoxcategorie.Location = new System.Drawing.Point(12, 468);
            this.comboBoxcategorie.Name = "comboBoxcategorie";
            this.comboBoxcategorie.Size = new System.Drawing.Size(328, 24);
            this.comboBoxcategorie.TabIndex = 10;
            this.comboBoxcategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategorie_SelectedIndexChanged);
            // 
            // stockcourantDataGridViewTextBoxColumn
            // 
            this.stockcourantDataGridViewTextBoxColumn.DataPropertyName = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.HeaderText = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockcourantDataGridViewTextBoxColumn.Name = "stockcourantDataGridViewTextBoxColumn";
            this.stockcourantDataGridViewTextBoxColumn.Width = 125;
            // 
            // nutriscoreDataGridViewTextBoxColumn
            // 
            this.nutriscoreDataGridViewTextBoxColumn.DataPropertyName = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.HeaderText = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nutriscoreDataGridViewTextBoxColumn.Name = "nutriscoreDataGridViewTextBoxColumn";
            this.nutriscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // presentationDataGridViewTextBoxColumn
            // 
            this.presentationDataGridViewTextBoxColumn.DataPropertyName = "Presentation";
            this.presentationDataGridViewTextBoxColumn.HeaderText = "Presentation";
            this.presentationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentationDataGridViewTextBoxColumn.Name = "presentationDataGridViewTextBoxColumn";
            this.presentationDataGridViewTextBoxColumn.Width = 125;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.Width = 125;
            // 
            // prixHTDataGridViewTextBoxColumn
            // 
            this.prixHTDataGridViewTextBoxColumn.DataPropertyName = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.HeaderText = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixHTDataGridViewTextBoxColumn.Name = "prixHTDataGridViewTextBoxColumn";
            this.prixHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tailleDataGridViewTextBoxColumn
            // 
            this.tailleDataGridViewTextBoxColumn.DataPropertyName = "Taille";
            this.tailleDataGridViewTextBoxColumn.HeaderText = "Taille";
            this.tailleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tailleDataGridViewTextBoxColumn.Name = "tailleDataGridViewTextBoxColumn";
            this.tailleDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // poidsDataGridViewTextBoxColumn
            // 
            this.poidsDataGridViewTextBoxColumn.DataPropertyName = "Poids";
            this.poidsDataGridViewTextBoxColumn.HeaderText = "Poids";
            this.poidsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poidsDataGridViewTextBoxColumn.Name = "poidsDataGridViewTextBoxColumn";
            this.poidsDataGridViewTextBoxColumn.Width = 125;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "Marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.marqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // gestionstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1509, 785);
            this.Controls.Add(this.comboBoxcategorie);
            this.Controls.Add(this.dataGridViewgestiondestock);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgestiondestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
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
        private Franprix_gestionDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Franprix_gestionDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewgestiondestock;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.ComboBox comboBoxcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutriscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcourantDataGridViewTextBoxColumn;
    }
}