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
            this.franprixgestionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franprix_gestionDataSet = new Windows_Project_GestionPAGE1.Franprix_gestionDataSet();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.categorieTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.CategorieTableAdapter();
            this.tableAdapterManager1 = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.TableAdapterManager();
            this.produitTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.ProduitTableAdapter();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewproduit2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantite = new System.Windows.Forms.GroupBox();
            this.buttonajoutquantite = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.minimum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.actuel = new System.Windows.Forms.Label();
            this.produitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduit2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.quantite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).BeginInit();
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
            this.btnDeconnexion.Size = new System.Drawing.Size(158, 57);
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
            // btnsavebase
            // 
            this.btnsavebase.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsavebase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavebase.Location = new System.Drawing.Point(1523, 75);
            this.btnsavebase.Name = "btnsavebase";
            this.btnsavebase.Size = new System.Drawing.Size(158, 57);
            this.btnsavebase.TabIndex = 17;
            this.btnsavebase.Text = "Sauvegarder";
            this.btnsavebase.UseVisualStyleBackColor = true;
            this.btnsavebase.Click += new System.EventHandler(this.btnsavebase_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fKProduitCategorieBindingSource
            // 
            this.fKProduitCategorieBindingSource.DataMember = "FK_Produit_Categorie";
            this.fKProduitCategorieBindingSource.DataSource = this.categorieBindingSource;
            // 
            // presentationDataGridViewTextBoxColumn
            // 
            this.presentationDataGridViewTextBoxColumn.DataPropertyName = "Presentation";
            this.presentationDataGridViewTextBoxColumn.HeaderText = "Presentation";
            this.presentationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentationDataGridViewTextBoxColumn.Name = "presentationDataGridViewTextBoxColumn";
            this.presentationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Stock_minimum
            // 
            this.Stock_minimum.DataPropertyName = "Stock_minimum";
            this.Stock_minimum.HeaderText = "Stock_minimum";
            this.Stock_minimum.MinimumWidth = 6;
            this.Stock_minimum.Name = "Stock_minimum";
            this.Stock_minimum.Width = 125;
            // 
            // stockcourantDataGridViewTextBoxColumn
            // 
            this.stockcourantDataGridViewTextBoxColumn.DataPropertyName = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.HeaderText = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockcourantDataGridViewTextBoxColumn.Name = "stockcourantDataGridViewTextBoxColumn";
            this.stockcourantDataGridViewTextBoxColumn.Width = 125;
            // 
            // Stock_max
            // 
            this.Stock_max.DataPropertyName = "Stock_max";
            this.Stock_max.HeaderText = "Stock_max";
            this.Stock_max.MinimumWidth = 6;
            this.Stock_max.Name = "Stock_max";
            this.Stock_max.Width = 125;
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
            this.categorieDataGridViewTextBoxColumn,
            this.nutriscoreDataGridViewTextBoxColumn,
            this.Stock_max,
            this.stockcourantDataGridViewTextBoxColumn,
            this.Stock_minimum,
            this.presentationDataGridViewTextBoxColumn});
            this.dataGridViewgestiondestock.DataSource = this.produitBindingSource;
            this.dataGridViewgestiondestock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewgestiondestock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewgestiondestock.GridColor = System.Drawing.Color.Black;

            this.dataGridViewgestiondestock.Location = new System.Drawing.Point(12, 533);

            this.dataGridViewgestiondestock.MultiSelect = false;
            this.dataGridViewgestiondestock.Name = "dataGridViewgestiondestock";
            this.dataGridViewgestiondestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewgestiondestock.RowTemplate.Height = 24;

            this.dataGridViewgestiondestock.Size = new System.Drawing.Size(1521, 275);

            this.dataGridViewgestiondestock.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(131, 84);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxcategorie
            // 
            this.comboBoxcategorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "Categorie", true));
            this.comboBoxcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcategorie.FormattingEnabled = true;
            this.comboBoxcategorie.Location = new System.Drawing.Point(131, 39);
            this.comboBoxcategorie.Name = "comboBoxcategorie";
            this.comboBoxcategorie.Size = new System.Drawing.Size(147, 24);
            this.comboBoxcategorie.TabIndex = 10;
            this.comboBoxcategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategorie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marque : ";
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(131, 133);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearch2.TabIndex = 21;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxSearch2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxcategorie);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 286);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher/Trier";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(1523, 439);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(158, 57);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(109, 40);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 22);
            this.textNom.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Nom";
            // 
            // textMarque
            // 
            this.textMarque.Location = new System.Drawing.Point(109, 85);
            this.textMarque.Name = "textMarque";
            this.textMarque.Size = new System.Drawing.Size(100, 22);
            this.textMarque.TabIndex = 9;
            // 
            // textPoids
            // 
            this.textPoids.Location = new System.Drawing.Point(109, 130);
            this.textPoids.Name = "textPoids";
            this.textPoids.Size = new System.Drawing.Size(100, 22);
            this.textPoids.TabIndex = 10;
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
            // dataGridViewproduit2
            // 
            this.dataGridViewproduit2.AllowUserToAddRows = false;
            this.dataGridViewproduit2.AllowUserToDeleteRows = false;
            this.dataGridViewproduit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewproduit2.AutoGenerateColumns = false;
            this.dataGridViewproduit2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewproduit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproduit2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewproduit2.DataSource = this.produitBindingSource;
            this.dataGridViewproduit2.GridColor = System.Drawing.Color.Black;
            this.dataGridViewproduit2.Location = new System.Drawing.Point(6, 40);
            this.dataGridViewproduit2.MultiSelect = false;
            this.dataGridViewproduit2.Name = "dataGridViewproduit2";
            this.dataGridViewproduit2.ReadOnly = true;
            this.dataGridViewproduit2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewproduit2.RowTemplate.Height = 24;
            this.dataGridViewproduit2.Size = new System.Drawing.Size(251, 283);
            this.dataGridViewproduit2.TabIndex = 12;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantite);
            this.groupBox1.Controls.Add(this.dataGridViewproduit2);
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
            this.quantite.Controls.Add(this.textBox2);
            this.quantite.Controls.Add(this.minimum);
            this.quantite.Controls.Add(this.textBox1);
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
            this.buttonajoutquantite.Location = new System.Drawing.Point(430, 38);
            this.buttonajoutquantite.Name = "buttonajoutquantite";
            this.buttonajoutquantite.Size = new System.Drawing.Size(112, 36);
            this.buttonajoutquantite.TabIndex = 4;
            this.buttonajoutquantite.Text = "Modifier";
            this.buttonajoutquantite.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 32);
            this.textBox2.TabIndex = 3;
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimum.Location = new System.Drawing.Point(190, 45);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(110, 26);
            this.minimum.TabIndex = 2;
            this.minimum.Text = "minimum : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 32);
            this.textBox1.TabIndex = 1;
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
            // produitBindingSource1
            // 
            this.produitBindingSource1.DataMember = "Produit";
            this.produitBindingSource1.DataSource = this.franprixgestionDataSetBindingSource;
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
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion de stock";
            this.Load += new System.EventHandler(this.gestionstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduit2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.quantite.ResumeLayout(false);
            this.quantite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).EndInit();

            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource franprixgestionDataSetBindingSource;
        private Franprix_gestionDataSet franprix_gestionDataSet;
        private System.Windows.Forms.Button btnDeconnexion;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private Franprix_gestionDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Franprix_gestionDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn presentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcourantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutriscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewgestiondestock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        protected System.Windows.Forms.ComboBox comboBoxcategorie;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridViewproduit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox quantite;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label minimum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label actuel;
        private System.Windows.Forms.BindingSource produitBindingSource1;
        private System.Windows.Forms.Button buttonajoutquantite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox comboBoxcategorie;
        private System.Windows.Forms.TextBox textBoxSearch;

    }
}