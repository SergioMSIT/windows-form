﻿namespace Windows_Project_GestionPAGE1
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
            this.produitTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.ProduitTableAdapter();
            this.dataGridViewgestiondestock = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutriscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcourantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewproduitShort = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_courant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantite = new System.Windows.Forms.GroupBox();
            this.buttonajoutquantite = new System.Windows.Forms.Button();
            this.TextBoxQuantitemini = new System.Windows.Forms.TextBox();
            this.minimum = new System.Windows.Forms.Label();
            this.TextBoxQuantiteactuel = new System.Windows.Forms.TextBox();
            this.actuel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxcategorie = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgestiondestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduitShort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.quantite.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1338, 12);
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
            this.btnDeconnexion.Location = new System.Drawing.Point(1398, 150);
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
            this.btnAdd.Location = new System.Drawing.Point(1398, 195);
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
            this.BtnModifier.Location = new System.Drawing.Point(1398, 240);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(135, 39);
            this.BtnModifier.TabIndex = 8;
            this.BtnModifier.Text = "Modifer ce produit";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewgestiondestock
            // 
            this.dataGridViewgestiondestock.AllowUserToAddRows = false;
            this.dataGridViewgestiondestock.AllowUserToDeleteRows = false;
            this.dataGridViewgestiondestock.AllowUserToOrderColumns = true;
            this.dataGridViewgestiondestock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewgestiondestock.AutoGenerateColumns = false;
            this.dataGridViewgestiondestock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewgestiondestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewgestiondestock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
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
            this.dataGridViewgestiondestock.Location = new System.Drawing.Point(12, 533);
            this.dataGridViewgestiondestock.MultiSelect = false;
            this.dataGridViewgestiondestock.Name = "dataGridViewgestiondestock";
            this.dataGridViewgestiondestock.ReadOnly = true;
            this.dataGridViewgestiondestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewgestiondestock.RowTemplate.Height = 24;
            this.dataGridViewgestiondestock.Size = new System.Drawing.Size(1521, 275);
            this.dataGridViewgestiondestock.TabIndex = 9;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Stock_minimum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Stock_minimum";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "Marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.marqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.marqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // poidsDataGridViewTextBoxColumn
            // 
            this.poidsDataGridViewTextBoxColumn.DataPropertyName = "Poids";
            this.poidsDataGridViewTextBoxColumn.HeaderText = "Poids";
            this.poidsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poidsDataGridViewTextBoxColumn.Name = "poidsDataGridViewTextBoxColumn";
            this.poidsDataGridViewTextBoxColumn.ReadOnly = true;
            this.poidsDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tailleDataGridViewTextBoxColumn
            // 
            this.tailleDataGridViewTextBoxColumn.DataPropertyName = "Taille";
            this.tailleDataGridViewTextBoxColumn.HeaderText = "Taille";
            this.tailleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tailleDataGridViewTextBoxColumn.Name = "tailleDataGridViewTextBoxColumn";
            this.tailleDataGridViewTextBoxColumn.ReadOnly = true;
            this.tailleDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixHTDataGridViewTextBoxColumn
            // 
            this.prixHTDataGridViewTextBoxColumn.DataPropertyName = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.HeaderText = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixHTDataGridViewTextBoxColumn.Name = "prixHTDataGridViewTextBoxColumn";
            this.prixHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            this.tVADataGridViewTextBoxColumn.Width = 125;
            // 
            // presentationDataGridViewTextBoxColumn
            // 
            this.presentationDataGridViewTextBoxColumn.DataPropertyName = "Presentation";
            this.presentationDataGridViewTextBoxColumn.HeaderText = "Presentation";
            this.presentationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentationDataGridViewTextBoxColumn.Name = "presentationDataGridViewTextBoxColumn";
            this.presentationDataGridViewTextBoxColumn.ReadOnly = true;
            this.presentationDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nutriscoreDataGridViewTextBoxColumn
            // 
            this.nutriscoreDataGridViewTextBoxColumn.DataPropertyName = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.HeaderText = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nutriscoreDataGridViewTextBoxColumn.Name = "nutriscoreDataGridViewTextBoxColumn";
            this.nutriscoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutriscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockcourantDataGridViewTextBoxColumn
            // 
            this.stockcourantDataGridViewTextBoxColumn.DataPropertyName = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.HeaderText = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockcourantDataGridViewTextBoxColumn.Name = "stockcourantDataGridViewTextBoxColumn";
            this.stockcourantDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockcourantDataGridViewTextBoxColumn.Width = 125;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vu sur l\'ensemble des produits :";
            // 
            // dataGridViewproduitShort
            // 
            this.dataGridViewproduitShort.AllowUserToAddRows = false;
            this.dataGridViewproduitShort.AllowUserToDeleteRows = false;
            this.dataGridViewproduitShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewproduitShort.AutoGenerateColumns = false;
            this.dataGridViewproduitShort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewproduitShort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproduitShort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Stock_courant,
            this.Stock_minimum,
            this.ID});
            this.dataGridViewproduitShort.DataSource = this.produitBindingSource;
            this.dataGridViewproduitShort.GridColor = System.Drawing.Color.Black;
            this.dataGridViewproduitShort.Location = new System.Drawing.Point(6, 40);
            this.dataGridViewproduitShort.MultiSelect = false;
            this.dataGridViewproduitShort.Name = "dataGridViewproduitShort";
            this.dataGridViewproduitShort.ReadOnly = true;
            this.dataGridViewproduitShort.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewproduitShort.RowTemplate.Height = 24;
            this.dataGridViewproduitShort.Size = new System.Drawing.Size(251, 283);
            this.dataGridViewproduitShort.TabIndex = 12;
            this.dataGridViewproduitShort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproduit2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Stock_courant
            // 
            this.Stock_courant.DataPropertyName = "Stock_courant";
            this.Stock_courant.HeaderText = "Stock_courant";
            this.Stock_courant.MinimumWidth = 6;
            this.Stock_courant.Name = "Stock_courant";
            this.Stock_courant.ReadOnly = true;
            this.Stock_courant.Visible = false;
            this.Stock_courant.Width = 125;
            // 
            // Stock_minimum
            // 
            this.Stock_minimum.DataPropertyName = "Stock_minimum";
            this.Stock_minimum.HeaderText = "Stock_minimum";
            this.Stock_minimum.MinimumWidth = 6;
            this.Stock_minimum.Name = "Stock_minimum";
            this.Stock_minimum.ReadOnly = true;
            this.Stock_minimum.Visible = false;
            this.Stock_minimum.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantite);
            this.groupBox1.Controls.Add(this.dataGridViewproduitShort);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1316, 369);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produits : ";
            // 
            // quantite
            // 
            this.quantite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quantite.Controls.Add(this.buttonajoutquantite);
            this.quantite.Controls.Add(this.TextBoxQuantitemini);
            this.quantite.Controls.Add(this.minimum);
            this.quantite.Controls.Add(this.TextBoxQuantiteactuel);
            this.quantite.Controls.Add(this.actuel);
            this.quantite.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantite.ForeColor = System.Drawing.Color.Black;
            this.quantite.Location = new System.Drawing.Point(263, 40);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(1053, 97);
            this.quantite.TabIndex = 13;
            this.quantite.TabStop = false;
            this.quantite.Text = "Gestion De Quantite : ";
            // 
            // buttonajoutquantite
            // 
            this.buttonajoutquantite.Location = new System.Drawing.Point(484, 39);
            this.buttonajoutquantite.Name = "buttonajoutquantite";
            this.buttonajoutquantite.Size = new System.Drawing.Size(112, 36);
            this.buttonajoutquantite.TabIndex = 4;
            this.buttonajoutquantite.Text = "Modifier";
            this.buttonajoutquantite.UseVisualStyleBackColor = true;
            this.buttonajoutquantite.Click += new System.EventHandler(this.buttonajoutquantite_Click);
            // 
            // TextBoxQuantitemini
            // 
            this.TextBoxQuantitemini.Location = new System.Drawing.Point(360, 43);
            this.TextBoxQuantitemini.Name = "TextBoxQuantitemini";
            this.TextBoxQuantitemini.Size = new System.Drawing.Size(118, 32);
            this.TextBoxQuantitemini.TabIndex = 3;
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimum.Location = new System.Drawing.Point(244, 46);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(110, 26);
            this.minimum.TabIndex = 2;
            this.minimum.Text = "minimum : ";
            // 
            // TextBoxQuantiteactuel
            // 
            this.TextBoxQuantiteactuel.Location = new System.Drawing.Point(106, 42);
            this.TextBoxQuantiteactuel.Name = "TextBoxQuantiteactuel";
            this.TextBoxQuantiteactuel.Size = new System.Drawing.Size(121, 32);
            this.TextBoxQuantiteactuel.TabIndex = 1;
            // 
            // actuel
            // 
            this.actuel.AutoSize = true;
            this.actuel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actuel.Location = new System.Drawing.Point(26, 46);
            this.actuel.Name = "actuel";
            this.actuel.Size = new System.Drawing.Size(75, 26);
            this.actuel.TabIndex = 0;
            this.actuel.Text = "actuel : ";
            this.actuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxcategorie);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1316, 58);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche :";
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch2.Location = new System.Drawing.Point(582, 20);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearch2.TabIndex = 33;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearchmarque_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Marque : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Catégorie :";
            // 
            // comboBoxcategorie
            // 
            this.comboBoxcategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxcategorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "Categorie", true));
            this.comboBoxcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcategorie.FormattingEnabled = true;
            this.comboBoxcategorie.Location = new System.Drawing.Point(130, 16);
            this.comboBoxcategorie.Name = "comboBoxcategorie";
            this.comboBoxcategorie.Size = new System.Drawing.Size(147, 24);
            this.comboBoxcategorie.TabIndex = 28;
            this.comboBoxcategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategorie_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.Location = new System.Drawing.Point(343, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearch.TabIndex = 30;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearchnom_TextChanged);
            // 
            // gestionstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1545, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduitShort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.quantite.ResumeLayout(false);
            this.quantite.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource franprixgestionDataSetBindingSource;
        private Franprix_gestionDataSet franprix_gestionDataSet;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnAdd;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.Button BtnModifier;
        private Franprix_gestionDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewgestiondestock;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewproduitShort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox quantite;
        private System.Windows.Forms.TextBox TextBoxQuantitemini;
        private System.Windows.Forms.Label minimum;
        private System.Windows.Forms.TextBox TextBoxQuantiteactuel;
        private System.Windows.Forms.Label actuel;
        private System.Windows.Forms.Button buttonajoutquantite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox comboBoxcategorie;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_courant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
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