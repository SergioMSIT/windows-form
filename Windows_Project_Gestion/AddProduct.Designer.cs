

namespace Windows_Project_GestionPAGE1
{
    partial class AddProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.franprix_gestionDataSet = new Windows_Project_GestionPAGE1.Franprix_gestionDataSet();
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
            this.categorieTableAdapter1 = new Windows_Project_GestionPAGE1.Franprix_gestionDataSetTableAdapters.CategorieTableAdapter();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(898, 358);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 57);
            this.btnAddProduct.TabIndex = 6;
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
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 322);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un produit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "ID", true));
            this.comboBoxCategorie.DataSource = this.bindingSource1;
            this.comboBoxCategorie.DisplayMember = "Nom";
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(406, 133);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCategorie.TabIndex = 35;
            this.comboBoxCategorie.ValueMember = "ID";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Categorie";
            this.bindingSource1.DataSource = this.franprix_gestionDataSet;
            // 
            // franprix_gestionDataSet
            // 
            this.franprix_gestionDataSet.DataSetName = "Franprix_gestionDataSet";
            this.franprix_gestionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBoxPresentation
            // 
            this.richTextBoxPresentation.Location = new System.Drawing.Point(687, 136);
            this.richTextBoxPresentation.Name = "richTextBoxPresentation";
            this.richTextBoxPresentation.Size = new System.Drawing.Size(253, 116);
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
            this.comboBoxTVA.Location = new System.Drawing.Point(406, 85);
            this.comboBoxTVA.Name = "comboBoxTVA";
            this.comboBoxTVA.Size = new System.Drawing.Size(100, 24);
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
            this.comboBoxNutriscore.Location = new System.Drawing.Point(406, 182);
            this.comboBoxNutriscore.Name = "comboBoxNutriscore";
            this.comboBoxNutriscore.Size = new System.Drawing.Size(100, 24);
            this.comboBoxNutriscore.TabIndex = 33;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Poids (en g)";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Taille (en cm)";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "TVA (en %)";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Catégorie";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stock Courant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stock Mini";
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(109, 179);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(100, 22);
            this.textVolume.TabIndex = 20;
            // 
            // textTaille
            // 
            this.textTaille.Location = new System.Drawing.Point(109, 230);
            this.textTaille.Name = "textTaille";
            this.textTaille.Size = new System.Drawing.Size(100, 22);
            this.textTaille.TabIndex = 19;
            // 
            // textPrixht
            // 
            this.textPrixht.Location = new System.Drawing.Point(406, 40);
            this.textPrixht.Name = "textPrixht";
            this.textPrixht.Size = new System.Drawing.Size(100, 22);
            this.textPrixht.TabIndex = 18;
            // 
            // textStockmax
            // 
            this.textStockmax.Location = new System.Drawing.Point(406, 230);
            this.textStockmax.Name = "textStockmax";
            this.textStockmax.Size = new System.Drawing.Size(100, 22);
            this.textStockmax.TabIndex = 13;
            // 
            // textStockcourant
            // 
            this.textStockcourant.Location = new System.Drawing.Point(687, 40);
            this.textStockcourant.Name = "textStockcourant";
            this.textStockcourant.Size = new System.Drawing.Size(100, 22);
            this.textStockcourant.TabIndex = 12;
            // 
            // textStockmini
            // 
            this.textStockmini.Location = new System.Drawing.Point(687, 85);
            this.textStockmini.Name = "textStockmini";
            this.textStockmini.Size = new System.Drawing.Size(100, 22);
            this.textStockmini.TabIndex = 11;
            // 
            // textPoids
            // 
            this.textPoids.Location = new System.Drawing.Point(109, 130);
            this.textPoids.Name = "textPoids";
            this.textPoids.Size = new System.Drawing.Size(100, 22);
            this.textPoids.TabIndex = 10;
            // 
            // textMarque
            // 
            this.textMarque.Location = new System.Drawing.Point(109, 85);
            this.textMarque.Name = "textMarque";
            this.textMarque.Size = new System.Drawing.Size(100, 22);
            this.textMarque.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nom";
            // 
            // categorieTableAdapter1
            // 
            this.categorieTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(749, 358);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(143, 57);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnnuler;
            this.ClientSize = new System.Drawing.Size(1053, 489);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franprix_gestionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.RichTextBox richTextBoxPresentation;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Franprix_gestionDataSet franprix_gestionDataSet1;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private Franprix_gestionDataSet franprix_gestionDataSet2;
        private Franprix_gestionDataSet franprix_gestionDataSet;
        private Franprix_gestionDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter1;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}