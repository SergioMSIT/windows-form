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
            this.btnsavebase = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fKProduitCategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcourantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutriscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewgestiondestock = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxcategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textMarque = new System.Windows.Forms.TextBox();
            this.textPoids = new System.Windows.Forms.TextBox();
            this.textStockmini = new System.Windows.Forms.TextBox();
            this.textStockcourant = new System.Windows.Forms.TextBox();
            this.textStockmax = new System.Windows.Forms.TextBox();
            this.textPrixht = new System.Windows.Forms.TextBox();
            this.textTaille = new System.Windows.Forms.TextBox();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxNutriscore = new System.Windows.Forms.ComboBox();
            this.comboBoxTVA = new System.Windows.Forms.ComboBox();
            this.richTextBoxPresentation = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.franprixgestionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProduitCategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgestiondestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(1523, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(158, 57);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewgestiondestock.Location = new System.Drawing.Point(0, 523);
            this.dataGridViewgestiondestock.MultiSelect = false;
            this.dataGridViewgestiondestock.Name = "dataGridViewgestiondestock";
            this.dataGridViewgestiondestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewgestiondestock.RowTemplate.Height = 24;
            this.dataGridViewgestiondestock.Size = new System.Drawing.Size(1693, 262);
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
            // textStockmini
            // 
            this.textStockmini.Location = new System.Drawing.Point(687, 85);
            this.textStockmini.Name = "textStockmini";
            this.textStockmini.Size = new System.Drawing.Size(100, 22);
            this.textStockmini.TabIndex = 11;
            // 
            // textStockcourant
            // 
            this.textStockcourant.Location = new System.Drawing.Point(687, 40);
            this.textStockcourant.Name = "textStockcourant";
            this.textStockcourant.Size = new System.Drawing.Size(100, 22);
            this.textStockcourant.TabIndex = 12;
            // 
            // textStockmax
            // 
            this.textStockmax.Location = new System.Drawing.Point(406, 230);
            this.textStockmax.Name = "textStockmax";
            this.textStockmax.Size = new System.Drawing.Size(100, 22);
            this.textStockmax.TabIndex = 13;
            // 
            // textPrixht
            // 
            this.textPrixht.Location = new System.Drawing.Point(406, 40);
            this.textPrixht.Name = "textPrixht";
            this.textPrixht.Size = new System.Drawing.Size(100, 22);
            this.textPrixht.TabIndex = 18;
            // 
            // textTaille
            // 
            this.textTaille.Location = new System.Drawing.Point(109, 230);
            this.textTaille.Name = "textTaille";
            this.textTaille.Size = new System.Drawing.Size(100, 22);
            this.textTaille.TabIndex = 19;
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(109, 179);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(100, 22);
            this.textVolume.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(584, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Stock Mini";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Stock Courant";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Stock Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nutriscore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Catégorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Présentation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "TVA (en %)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Prix HT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Taille (en cm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Volume (en L)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Poids (en g)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Marque";
            // 
            // comboBoxNutriscore
            // 
            this.comboBoxNutriscore.FormattingEnabled = true;
            this.comboBoxNutriscore.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxNutriscore.Location = new System.Drawing.Point(406, 182);
            this.comboBoxNutriscore.Name = "comboBoxNutriscore";
            this.comboBoxNutriscore.Size = new System.Drawing.Size(100, 24);
            this.comboBoxNutriscore.TabIndex = 33;
            // 
            // comboBoxTVA
            // 
            this.comboBoxTVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTVA.FormattingEnabled = true;
            this.comboBoxTVA.Items.AddRange(new object[] {
            "20",
            "10",
            "5.5"});
            this.comboBoxTVA.Location = new System.Drawing.Point(406, 85);
            this.comboBoxTVA.Name = "comboBoxTVA";
            this.comboBoxTVA.Size = new System.Drawing.Size(100, 24);
            this.comboBoxTVA.TabIndex = 34;
            // 
            // richTextBoxPresentation
            // 
            this.richTextBoxPresentation.Location = new System.Drawing.Point(687, 136);
            this.richTextBoxPresentation.Name = "richTextBoxPresentation";
            this.richTextBoxPresentation.Size = new System.Drawing.Size(253, 116);
            this.richTextBoxPresentation.TabIndex = 9;
            this.richTextBoxPresentation.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categorieBindingSource, "ID", true));
            this.comboBox1.DataSource = this.categorieBindingSource;
            this.comboBox1.DisplayMember = "Nom";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.richTextBoxPresentation);
            this.groupBox2.Controls.Add(this.comboBoxTVA);
            this.groupBox2.Controls.Add(this.comboBoxNutriscore);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textVolume);
            this.groupBox2.Controls.Add(this.textTaille);
            this.groupBox2.Controls.Add(this.textPrixht);
            this.groupBox2.Controls.Add(this.textStockmax);
            this.groupBox2.Controls.Add(this.textStockcourant);
            this.groupBox2.Controls.Add(this.textStockmini);
            this.groupBox2.Controls.Add(this.textPoids);
            this.groupBox2.Controls.Add(this.textMarque);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textNom);
            this.groupBox2.Location = new System.Drawing.Point(477, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 286);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter un produit";
            // 
            // gestionstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1693, 785);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsavebase);
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
            ((System.ComponentModel.ISupportInitialize)(this.fKProduitCategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgestiondestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnsavebase;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource fKProduitCategorieBindingSource;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textMarque;
        private System.Windows.Forms.TextBox textPoids;
        private System.Windows.Forms.TextBox textStockmini;
        private System.Windows.Forms.TextBox textStockcourant;
        private System.Windows.Forms.TextBox textStockmax;
        private System.Windows.Forms.TextBox textPrixht;
        private System.Windows.Forms.TextBox textTaille;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxNutriscore;
        private System.Windows.Forms.ComboBox comboBoxTVA;
        private System.Windows.Forms.RichTextBox richTextBoxPresentation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}