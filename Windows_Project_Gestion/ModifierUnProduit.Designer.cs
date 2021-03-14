
namespace Windows_Project_GestionPAGE1
{
    partial class ModifierUnProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierUnProduit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.richTextBoxPresentation = new System.Windows.Forms.RichTextBox();
            this.comboBoxTVA = new System.Windows.Forms.ComboBox();
            this.comboBoxNutriscore = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.textTaille = new System.Windows.Forms.TextBox();
            this.textPrixht = new System.Windows.Forms.TextBox();
            this.textStockmax = new System.Windows.Forms.TextBox();
            this.textStockcourant = new System.Windows.Forms.TextBox();
            this.textStockmini = new System.Windows.Forms.TextBox();
            this.textPoids = new System.Windows.Forms.TextBox();
            this.textMarque = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.dataGridViewproduitpourmodifierunproduit = new System.Windows.Forms.DataGridView();
            this.Stock_courant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutriscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcourantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockminimumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franprix_gestionDataSet = new Windows_Project_GestionPAGE1.Franprix_gestionDataSet();
            this.produitTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.ProduitTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchMarque = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSearchNom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.CategorieTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduitpourmodifierunproduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxCategorie);
            this.groupBox1.Controls.Add(this.richTextBoxPresentation);
            this.groupBox1.Controls.Add(this.comboBoxTVA);
            this.groupBox1.Controls.Add(this.comboBoxNutriscore);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textVolume);
            this.groupBox1.Controls.Add(this.textTaille);
            this.groupBox1.Controls.Add(this.textPrixht);
            this.groupBox1.Controls.Add(this.textStockmax);
            this.groupBox1.Controls.Add(this.textStockcourant);
            this.groupBox1.Controls.Add(this.textStockmini);
            this.groupBox1.Controls.Add(this.textPoids);
            this.groupBox1.Controls.Add(this.textMarque);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(240, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 376);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier un produit";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DisplayMember = "Nom";
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(459, 133);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(100, 31);
            this.comboBoxCategorie.TabIndex = 35;
            this.comboBoxCategorie.ValueMember = "ID";
            // 
            // richTextBoxPresentation
            // 
            this.richTextBoxPresentation.Location = new System.Drawing.Point(459, 182);
            this.richTextBoxPresentation.Name = "richTextBoxPresentation";
            this.richTextBoxPresentation.Size = new System.Drawing.Size(331, 116);
            this.richTextBoxPresentation.TabIndex = 9;
            this.richTextBoxPresentation.Text = "";
            // 
            // comboBoxTVA
            // 
            this.comboBoxTVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTVA.FormattingEnabled = true;
            this.comboBoxTVA.Items.AddRange(new object[] {
            "20",
            "10",
            "5.5"});
            this.comboBoxTVA.Location = new System.Drawing.Point(459, 85);
            this.comboBoxTVA.Name = "comboBoxTVA";
            this.comboBoxTVA.Size = new System.Drawing.Size(100, 31);
            this.comboBoxTVA.TabIndex = 34;
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
            this.comboBoxNutriscore.Location = new System.Drawing.Point(690, 44);
            this.comboBoxNutriscore.Name = "comboBoxNutriscore";
            this.comboBoxNutriscore.Size = new System.Drawing.Size(100, 31);
            this.comboBoxNutriscore.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "Marque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Poids (en g)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Volume (en L)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Taille (en cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Prix HT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "TVA (en %)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Présentation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Catégorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nutriscore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stock Courant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stock Mini";
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(138, 179);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(168, 30);
            this.textVolume.TabIndex = 20;
            this.textVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTaille
            // 
            this.textTaille.Location = new System.Drawing.Point(138, 230);
            this.textTaille.Name = "textTaille";
            this.textTaille.Size = new System.Drawing.Size(168, 30);
            this.textTaille.TabIndex = 19;
            this.textTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrixht
            // 
            this.textPrixht.Location = new System.Drawing.Point(459, 40);
            this.textPrixht.Name = "textPrixht";
            this.textPrixht.Size = new System.Drawing.Size(100, 30);
            this.textPrixht.TabIndex = 18;
            this.textPrixht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStockmax
            // 
            this.textStockmax.Location = new System.Drawing.Point(690, 92);
            this.textStockmax.Name = "textStockmax";
            this.textStockmax.Size = new System.Drawing.Size(100, 30);
            this.textStockmax.TabIndex = 13;
            this.textStockmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStockcourant
            // 
            this.textStockcourant.Location = new System.Drawing.Point(138, 280);
            this.textStockcourant.Name = "textStockcourant";
            this.textStockcourant.Size = new System.Drawing.Size(168, 30);
            this.textStockcourant.TabIndex = 12;
            this.textStockcourant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStockmini
            // 
            this.textStockmini.Location = new System.Drawing.Point(690, 138);
            this.textStockmini.Name = "textStockmini";
            this.textStockmini.Size = new System.Drawing.Size(100, 30);
            this.textStockmini.TabIndex = 11;
            this.textStockmini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPoids
            // 
            this.textPoids.Location = new System.Drawing.Point(138, 130);
            this.textPoids.Name = "textPoids";
            this.textPoids.Size = new System.Drawing.Size(168, 30);
            this.textPoids.TabIndex = 10;
            this.textPoids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMarque
            // 
            this.textMarque.Location = new System.Drawing.Point(138, 85);
            this.textMarque.Name = "textMarque";
            this.textMarque.Size = new System.Drawing.Size(168, 30);
            this.textMarque.TabIndex = 9;
            this.textMarque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nom    ";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(138, 40);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(168, 30);
            this.textNom.TabIndex = 7;
            this.textNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewproduitpourmodifierunproduit
            // 
            this.dataGridViewproduitpourmodifierunproduit.AllowUserToAddRows = false;
            this.dataGridViewproduitpourmodifierunproduit.AllowUserToDeleteRows = false;
            this.dataGridViewproduitpourmodifierunproduit.AllowUserToOrderColumns = true;
            this.dataGridViewproduitpourmodifierunproduit.AutoGenerateColumns = false;
            this.dataGridViewproduitpourmodifierunproduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(76)))), ((int)(((byte)(5)))));
            this.dataGridViewproduitpourmodifierunproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproduitpourmodifierunproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock_courant,
            this.Stock_minimum,
            this.iDDataGridViewTextBoxColumn,
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
            this.stockmaxDataGridViewTextBoxColumn,
            this.stockcourantDataGridViewTextBoxColumn,
            this.stockminimumDataGridViewTextBoxColumn});
            this.dataGridViewproduitpourmodifierunproduit.DataSource = this.produitBindingSource;
            this.dataGridViewproduitpourmodifierunproduit.GridColor = System.Drawing.Color.Black;
            this.dataGridViewproduitpourmodifierunproduit.Location = new System.Drawing.Point(3, 7);
            this.dataGridViewproduitpourmodifierunproduit.MultiSelect = false;
            this.dataGridViewproduitpourmodifierunproduit.Name = "dataGridViewproduitpourmodifierunproduit";
            this.dataGridViewproduitpourmodifierunproduit.ReadOnly = true;
            this.dataGridViewproduitpourmodifierunproduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewproduitpourmodifierunproduit.RowTemplate.Height = 24;
            this.dataGridViewproduitpourmodifierunproduit.Size = new System.Drawing.Size(203, 368);
            this.dataGridViewproduitpourmodifierunproduit.TabIndex = 13;
            this.dataGridViewproduitpourmodifierunproduit.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewproduitpourmodifierunproduit_RowHeaderMouseClick);
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
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
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "Marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.marqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.marqueDataGridViewTextBoxColumn.Visible = false;
            this.marqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // poidsDataGridViewTextBoxColumn
            // 
            this.poidsDataGridViewTextBoxColumn.DataPropertyName = "Poids";
            this.poidsDataGridViewTextBoxColumn.HeaderText = "Poids";
            this.poidsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poidsDataGridViewTextBoxColumn.Name = "poidsDataGridViewTextBoxColumn";
            this.poidsDataGridViewTextBoxColumn.ReadOnly = true;
            this.poidsDataGridViewTextBoxColumn.Visible = false;
            this.poidsDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Visible = false;
            this.volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tailleDataGridViewTextBoxColumn
            // 
            this.tailleDataGridViewTextBoxColumn.DataPropertyName = "Taille";
            this.tailleDataGridViewTextBoxColumn.HeaderText = "Taille";
            this.tailleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tailleDataGridViewTextBoxColumn.Name = "tailleDataGridViewTextBoxColumn";
            this.tailleDataGridViewTextBoxColumn.ReadOnly = true;
            this.tailleDataGridViewTextBoxColumn.Visible = false;
            this.tailleDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixHTDataGridViewTextBoxColumn
            // 
            this.prixHTDataGridViewTextBoxColumn.DataPropertyName = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.HeaderText = "PrixHT";
            this.prixHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixHTDataGridViewTextBoxColumn.Name = "prixHTDataGridViewTextBoxColumn";
            this.prixHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixHTDataGridViewTextBoxColumn.Visible = false;
            this.prixHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            this.tVADataGridViewTextBoxColumn.Visible = false;
            this.tVADataGridViewTextBoxColumn.Width = 125;
            // 
            // presentationDataGridViewTextBoxColumn
            // 
            this.presentationDataGridViewTextBoxColumn.DataPropertyName = "Presentation";
            this.presentationDataGridViewTextBoxColumn.HeaderText = "Presentation";
            this.presentationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentationDataGridViewTextBoxColumn.Name = "presentationDataGridViewTextBoxColumn";
            this.presentationDataGridViewTextBoxColumn.ReadOnly = true;
            this.presentationDataGridViewTextBoxColumn.Visible = false;
            this.presentationDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorieDataGridViewTextBoxColumn.Visible = false;
            this.categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nutriscoreDataGridViewTextBoxColumn
            // 
            this.nutriscoreDataGridViewTextBoxColumn.DataPropertyName = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.HeaderText = "Nutriscore";
            this.nutriscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nutriscoreDataGridViewTextBoxColumn.Name = "nutriscoreDataGridViewTextBoxColumn";
            this.nutriscoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutriscoreDataGridViewTextBoxColumn.Visible = false;
            this.nutriscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockmaxDataGridViewTextBoxColumn
            // 
            this.stockmaxDataGridViewTextBoxColumn.DataPropertyName = "Stock_max";
            this.stockmaxDataGridViewTextBoxColumn.HeaderText = "Stock_max";
            this.stockmaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockmaxDataGridViewTextBoxColumn.Name = "stockmaxDataGridViewTextBoxColumn";
            this.stockmaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockmaxDataGridViewTextBoxColumn.Visible = false;
            this.stockmaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockcourantDataGridViewTextBoxColumn
            // 
            this.stockcourantDataGridViewTextBoxColumn.DataPropertyName = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.HeaderText = "Stock_courant";
            this.stockcourantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockcourantDataGridViewTextBoxColumn.Name = "stockcourantDataGridViewTextBoxColumn";
            this.stockcourantDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockcourantDataGridViewTextBoxColumn.Visible = false;
            this.stockcourantDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockminimumDataGridViewTextBoxColumn
            // 
            this.stockminimumDataGridViewTextBoxColumn.DataPropertyName = "Stock_minimum";
            this.stockminimumDataGridViewTextBoxColumn.HeaderText = "Stock_minimum";
            this.stockminimumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockminimumDataGridViewTextBoxColumn.Name = "stockminimumDataGridViewTextBoxColumn";
            this.stockminimumDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockminimumDataGridViewTextBoxColumn.Visible = false;
            this.stockminimumDataGridViewTextBoxColumn.Width = 125;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.franprix_gestionDataSet;
            // 
            // franprix_gestionDataSet
            // 
            this.franprix_gestionDataSet.DataSetName = "Franprix_gestionDataSet";
            this.franprix_gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(76)))), ((int)(((byte)(5)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.dataGridViewproduitpourmodifierunproduit);
            this.panel2.Location = new System.Drawing.Point(-3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 513);
            this.panel2.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(136)))), ((int)(((byte)(73)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(0, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 63);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "ANNULER";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(136)))), ((int)(((byte)(73)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(0, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 59);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "MODIFIER";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearchMarque);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBoxSearchNom);
            this.groupBox2.Location = new System.Drawing.Point(317, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 58);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche :";
            // 
            // textBoxSearchMarque
            // 
            this.textBoxSearchMarque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchMarque.Location = new System.Drawing.Point(582, 20);
            this.textBoxSearchMarque.Name = "textBoxSearchMarque";
            this.textBoxSearchMarque.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearchMarque.TabIndex = 33;
            this.textBoxSearchMarque.TextChanged += new System.EventHandler(this.textBoxSearchMarque_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(496, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Marque : ";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(283, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Nom :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Catégorie :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "Categorie", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxSearchNom
            // 
            this.textBoxSearchNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchNom.Location = new System.Drawing.Point(343, 20);
            this.textBoxSearchNom.Name = "textBoxSearchNom";
            this.textBoxSearchNom.Size = new System.Drawing.Size(147, 22);
            this.textBoxSearchNom.TabIndex = 30;
            this.textBoxSearchNom.TextChanged += new System.EventHandler(this.textBoxSearchNom_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(76)))), ((int)(((byte)(5)))));
            this.panel1.BackgroundImage = global::Windows_Project_GestionPAGE1.Properties.Resources.images;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 68);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Windows_Project_GestionPAGE1.Properties.Resources.logo_franprix;
            this.pictureBox1.Location = new System.Drawing.Point(627, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // ModifierUnProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1146, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModifierUnProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un produit";
            this.Load += new System.EventHandler(this.ModifierUnProduit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduitpourmodifierunproduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.RichTextBox richTextBoxPresentation;
        private System.Windows.Forms.ComboBox comboBoxTVA;
        private System.Windows.Forms.ComboBox comboBoxNutriscore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.TextBox textTaille;
        private System.Windows.Forms.TextBox textPrixht;
        private System.Windows.Forms.TextBox textStockmax;
        private System.Windows.Forms.TextBox textStockcourant;
        private System.Windows.Forms.TextBox textStockmini;
        private System.Windows.Forms.TextBox textPoids;
        private System.Windows.Forms.TextBox textMarque;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.DataGridView dataGridViewproduitpourmodifierunproduit;
        private Franprix_gestionDataSet franprix_gestionDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Franprix_gestionDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_courant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn stockmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcourantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockminimumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearchMarque;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSearchNom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
    }
}