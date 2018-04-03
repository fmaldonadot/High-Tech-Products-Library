namespace High_Tech_Products_Library
{
    partial class HighTechForm
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
            this.TWOlab01 = new System.Windows.Forms.Label();
            this.btnSearchByKey = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHYear = new System.Windows.Forms.TextBox();
            this.txtHMonth = new System.Windows.Forms.TextBox();
            this.txtHDay = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.cmbTypeProd = new System.Windows.Forms.ComboBox();
            this.Prodtypelabel = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.SNLabel = new System.Windows.Forms.Label();
            this.cmbBGenre = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.BookGenrelabel = new System.Windows.Forms.Label();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.txtBPages = new System.Windows.Forms.TextBox();
            this.BPageslabel = new System.Windows.Forms.Label();
            this.txtSCapacity = new System.Windows.Forms.TextBox();
            this.SCapacitylabel = new System.Windows.Forms.Label();
            this.cmbSoftType = new System.Windows.Forms.ComboBox();
            this.SoftTypelabel = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.Stocklabel = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radbtnByItem = new System.Windows.Forms.RadioButton();
            this.radbtnBySN = new System.Windows.Forms.RadioButton();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TWOlab01
            // 
            this.TWOlab01.AutoSize = true;
            this.TWOlab01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWOlab01.Location = new System.Drawing.Point(621, 145);
            this.TWOlab01.Name = "TWOlab01";
            this.TWOlab01.Size = new System.Drawing.Size(16, 18);
            this.TWOlab01.TabIndex = 203;
            this.TWOlab01.Text = "$";
            // 
            // btnSearchByKey
            // 
            this.btnSearchByKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchByKey.Image = global::High_Tech_Products_Library.Properties.Resources.Search_icon3;
            this.btnSearchByKey.Location = new System.Drawing.Point(454, 185);
            this.btnSearchByKey.Name = "btnSearchByKey";
            this.btnSearchByKey.Size = new System.Drawing.Size(30, 33);
            this.btnSearchByKey.TabIndex = 165;
            this.btnSearchByKey.UseVisualStyleBackColor = true;
            this.btnSearchByKey.Click += new System.EventHandler(this.btnSearchByKey_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(532, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(83, 23);
            this.txtPrice.TabIndex = 190;
            this.txtPrice.TabStop = false;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pricelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelabel.Location = new System.Drawing.Point(484, 146);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(42, 19);
            this.Pricelabel.TabIndex = 189;
            this.Pricelabel.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 185;
            this.label11.Text = "(dd/mm/yyyy)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(246, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 184;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 183;
            this.label13.Text = "/";
            // 
            // txtHYear
            // 
            this.txtHYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHYear.Location = new System.Drawing.Point(263, 114);
            this.txtHYear.Name = "txtHYear";
            this.txtHYear.Size = new System.Drawing.Size(63, 21);
            this.txtHYear.TabIndex = 141;
            // 
            // txtHMonth
            // 
            this.txtHMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHMonth.Location = new System.Drawing.Point(207, 114);
            this.txtHMonth.Name = "txtHMonth";
            this.txtHMonth.Size = new System.Drawing.Size(33, 21);
            this.txtHMonth.TabIndex = 140;
            // 
            // txtHDay
            // 
            this.txtHDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDay.Location = new System.Drawing.Point(151, 114);
            this.txtHDay.Name = "txtHDay";
            this.txtHDay.Size = new System.Drawing.Size(33, 21);
            this.txtHDay.TabIndex = 139;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(39, 114);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(99, 17);
            this.Datelabel.TabIndex = 182;
            this.Datelabel.Text = "Publication Date";
            // 
            // cmbTypeProd
            // 
            this.cmbTypeProd.DisplayMember = "Undefined";
            this.cmbTypeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeProd.FormattingEnabled = true;
            this.cmbTypeProd.Location = new System.Drawing.Point(501, 29);
            this.cmbTypeProd.Name = "cmbTypeProd";
            this.cmbTypeProd.Size = new System.Drawing.Size(97, 26);
            this.cmbTypeProd.TabIndex = 153;
            this.cmbTypeProd.ValueMember = "Undefined";
            this.cmbTypeProd.SelectedIndexChanged += new System.EventHandler(this.cmbTypeProd_SelectedIndexChanged);
            // 
            // Prodtypelabel
            // 
            this.Prodtypelabel.AutoSize = true;
            this.Prodtypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Prodtypelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Prodtypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prodtypelabel.Location = new System.Drawing.Point(427, 32);
            this.Prodtypelabel.Name = "Prodtypelabel";
            this.Prodtypelabel.Size = new System.Drawing.Size(62, 20);
            this.Prodtypelabel.TabIndex = 180;
            this.Prodtypelabel.Text = "Product";
            // 
            // btnErase
            // 
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnErase.Location = new System.Drawing.Point(129, 225);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(93, 32);
            this.btnErase.TabIndex = 167;
            this.btnErase.Text = "&Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Location = new System.Drawing.Point(357, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 32);
            this.btnReset.TabIndex = 169;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModify.Location = new System.Drawing.Point(248, 187);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(93, 32);
            this.btnModify.TabIndex = 164;
            this.btnModify.Text = "&Mofify Product";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplay.Location = new System.Drawing.Point(129, 187);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(93, 32);
            this.btnDisplay.TabIndex = 163;
            this.btnDisplay.Text = "&Display Product";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(14, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 162;
            this.btnAdd.Text = "&Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadFile.Location = new System.Drawing.Point(14, 225);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(93, 32);
            this.btnLoadFile.TabIndex = 166;
            this.btnLoadFile.Text = "&Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWriteFile.Location = new System.Drawing.Point(248, 225);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(93, 32);
            this.btnWriteFile.TabIndex = 168;
            this.btnWriteFile.Text = "&Save File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(357, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 32);
            this.btnExit.TabIndex = 170;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(151, 17);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(146, 21);
            this.txtSN.TabIndex = 172;
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SNLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNLabel.Location = new System.Drawing.Point(46, 20);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(89, 17);
            this.SNLabel.TabIndex = 176;
            this.SNLabel.Text = "Serial Number";
            // 
            // cmbBGenre
            // 
            this.cmbBGenre.DisplayMember = "Undefined";
            this.cmbBGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBGenre.FormattingEnabled = true;
            this.cmbBGenre.Location = new System.Drawing.Point(529, 70);
            this.cmbBGenre.Name = "cmbBGenre";
            this.cmbBGenre.Size = new System.Drawing.Size(108, 24);
            this.cmbBGenre.TabIndex = 154;
            this.cmbBGenre.ValueMember = "Undefined";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(151, 77);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(175, 21);
            this.txtAuthor.TabIndex = 137;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(151, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 21);
            this.txtTitle.TabIndex = 136;
            // 
            // BookGenrelabel
            // 
            this.BookGenrelabel.AutoSize = true;
            this.BookGenrelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookGenrelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookGenrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGenrelabel.Location = new System.Drawing.Point(473, 73);
            this.BookGenrelabel.Name = "BookGenrelabel";
            this.BookGenrelabel.Size = new System.Drawing.Size(50, 19);
            this.BookGenrelabel.TabIndex = 175;
            this.BookGenrelabel.Text = "Genre";
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Authorlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Authorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlabel.Location = new System.Drawing.Point(91, 80);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(44, 17);
            this.Authorlabel.TabIndex = 173;
            this.Authorlabel.Text = "Author";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titlelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(103, 51);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(32, 17);
            this.Titlelabel.TabIndex = 171;
            this.Titlelabel.Text = "Title";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.AllowDrop = true;
            this.listBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.HorizontalScrollbar = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 272);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(638, 154);
            this.listBoxProducts.TabIndex = 207;
            // 
            // txtBPages
            // 
            this.txtBPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPages.Location = new System.Drawing.Point(532, 105);
            this.txtBPages.Name = "txtBPages";
            this.txtBPages.Size = new System.Drawing.Size(49, 21);
            this.txtBPages.TabIndex = 208;
            // 
            // BPageslabel
            // 
            this.BPageslabel.AutoSize = true;
            this.BPageslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BPageslabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BPageslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPageslabel.Location = new System.Drawing.Point(482, 109);
            this.BPageslabel.Name = "BPageslabel";
            this.BPageslabel.Size = new System.Drawing.Size(44, 17);
            this.BPageslabel.TabIndex = 209;
            this.BPageslabel.Text = "Pages";
            // 
            // txtSCapacity
            // 
            this.txtSCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCapacity.Location = new System.Drawing.Point(532, 113);
            this.txtSCapacity.Name = "txtSCapacity";
            this.txtSCapacity.Size = new System.Drawing.Size(49, 21);
            this.txtSCapacity.TabIndex = 210;
            // 
            // SCapacitylabel
            // 
            this.SCapacitylabel.AutoSize = true;
            this.SCapacitylabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCapacitylabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SCapacitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCapacitylabel.Location = new System.Drawing.Point(420, 116);
            this.SCapacitylabel.Name = "SCapacitylabel";
            this.SCapacitylabel.Size = new System.Drawing.Size(106, 17);
            this.SCapacitylabel.TabIndex = 211;
            this.SCapacitylabel.Text = "Software Capacity";
            // 
            // cmbSoftType
            // 
            this.cmbSoftType.DisplayMember = "Undefined";
            this.cmbSoftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSoftType.FormattingEnabled = true;
            this.cmbSoftType.Location = new System.Drawing.Point(529, 68);
            this.cmbSoftType.Name = "cmbSoftType";
            this.cmbSoftType.Size = new System.Drawing.Size(108, 24);
            this.cmbSoftType.TabIndex = 212;
            this.cmbSoftType.ValueMember = "Undefined";
            // 
            // SoftTypelabel
            // 
            this.SoftTypelabel.AutoSize = true;
            this.SoftTypelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoftTypelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoftTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftTypelabel.Location = new System.Drawing.Point(427, 68);
            this.SoftTypelabel.Name = "SoftTypelabel";
            this.SoftTypelabel.Size = new System.Drawing.Size(96, 19);
            this.SoftTypelabel.TabIndex = 213;
            this.SoftTypelabel.Text = "Software type";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(151, 145);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(60, 21);
            this.txtStock.TabIndex = 214;
            // 
            // Stocklabel
            // 
            this.Stocklabel.AutoSize = true;
            this.Stocklabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stocklabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stocklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocklabel.Location = new System.Drawing.Point(99, 148);
            this.Stocklabel.Name = "Stocklabel";
            this.Stocklabel.Size = new System.Drawing.Size(39, 17);
            this.Stocklabel.TabIndex = 215;
            this.Stocklabel.Text = "Stock";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.radbtnByItem);
            this.grpSearch.Controls.Add(this.radbtnBySN);
            this.grpSearch.Location = new System.Drawing.Point(490, 185);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(161, 80);
            this.grpSearch.TabIndex = 216;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Options";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(22, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(103, 21);
            this.txtSearch.TabIndex = 129;
            // 
            // radbtnByItem
            // 
            this.radbtnByItem.AutoSize = true;
            this.radbtnByItem.Location = new System.Drawing.Point(67, 19);
            this.radbtnByItem.Name = "radbtnByItem";
            this.radbtnByItem.Size = new System.Drawing.Size(80, 17);
            this.radbtnByItem.TabIndex = 1;
            this.radbtnByItem.TabStop = true;
            this.radbtnByItem.Text = "By Item No.";
            this.radbtnByItem.UseVisualStyleBackColor = true;
            // 
            // radbtnBySN
            // 
            this.radbtnBySN.AutoSize = true;
            this.radbtnBySN.Location = new System.Drawing.Point(11, 19);
            this.radbtnBySN.Name = "radbtnBySN";
            this.radbtnBySN.Size = new System.Drawing.Size(55, 17);
            this.radbtnBySN.TabIndex = 0;
            this.radbtnBySN.TabStop = true;
            this.radbtnBySN.Text = "By SN";
            this.radbtnBySN.UseVisualStyleBackColor = true;
            this.radbtnBySN.CheckedChanged += new System.EventHandler(this.radbtnBySIN_CheckedChanged);
            // 
            // HighTechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 464);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.Stocklabel);
            this.Controls.Add(this.cmbSoftType);
            this.Controls.Add(this.SoftTypelabel);
            this.Controls.Add(this.txtSCapacity);
            this.Controls.Add(this.SCapacitylabel);
            this.Controls.Add(this.txtBPages);
            this.Controls.Add(this.BPageslabel);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.TWOlab01);
            this.Controls.Add(this.btnSearchByKey);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHYear);
            this.Controls.Add(this.txtHMonth);
            this.Controls.Add(this.txtHDay);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.cmbTypeProd);
            this.Controls.Add(this.Prodtypelabel);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.SNLabel);
            this.Controls.Add(this.cmbBGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.BookGenrelabel);
            this.Controls.Add(this.Authorlabel);
            this.Controls.Add(this.Titlelabel);
            this.Name = "HighTechForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High-Tech Products Library";
            this.Load += new System.EventHandler(this.HighTechForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TWOlab01;
        private System.Windows.Forms.Button btnSearchByKey;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHYear;
        private System.Windows.Forms.TextBox txtHMonth;
        private System.Windows.Forms.TextBox txtHDay;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.ComboBox cmbTypeProd;
        private System.Windows.Forms.Label Prodtypelabel;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.ComboBox cmbBGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label BookGenrelabel;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.Label Titlelabel;
        public System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.TextBox txtBPages;
        private System.Windows.Forms.Label BPageslabel;
        private System.Windows.Forms.TextBox txtSCapacity;
        private System.Windows.Forms.Label SCapacitylabel;
        private System.Windows.Forms.ComboBox cmbSoftType;
        private System.Windows.Forms.Label SoftTypelabel;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label Stocklabel;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radbtnByItem;
        private System.Windows.Forms.RadioButton radbtnBySN;
    }
}

