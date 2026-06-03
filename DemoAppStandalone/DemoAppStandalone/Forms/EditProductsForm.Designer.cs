namespace DemoAppStandalone.Forms
{
    partial class EditProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductsForm));
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelUnits = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxProductPhoto = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(387, 314);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 28);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(12, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(70, 17);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID товара";
            this.labelID.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(9, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 19);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Редактирование товара";
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserInfo.Location = new System.Drawing.Point(277, 4);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(188, 41);
            this.labelUserInfo.TabIndex = 7;
            this.labelUserInfo.Text = "Юрченко Иван Андреевич";
            this.labelUserInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(175, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(121, 25);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.Text = "0";
            this.textBoxID.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Наименование";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(12, 102);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 17);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Категория";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 133);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(68, 17);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Описание";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(12, 164);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(103, 17);
            this.labelManufacturer.TabIndex = 12;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplier.Location = new System.Drawing.Point(12, 196);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(79, 17);
            this.labelSupplier.TabIndex = 13;
            this.labelSupplier.Text = "Поставщик";
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnits.Location = new System.Drawing.Point(10, 258);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(129, 17);
            this.labelUnits.TabIndex = 14;
            this.labelUnits.Text = "Единица измерения";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStock.Location = new System.Drawing.Point(10, 288);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(146, 17);
            this.labelStock.TabIndex = 15;
            this.labelStock.Text = "Количество на складе";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(12, 319);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(142, 17);
            this.labelDiscount.TabIndex = 16;
            this.labelDiscount.Text = "Действующая скидка";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(175, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 25);
            this.textBoxName.TabIndex = 18;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(174, 99);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCategory.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(175, 130);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(121, 25);
            this.textBoxDescription.TabIndex = 20;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(175, 161);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(121, 25);
            this.comboBoxManufacturer.TabIndex = 21;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.BackColor = System.Drawing.Color.White;
            this.textBoxSupplier.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSupplier.Location = new System.Drawing.Point(175, 193);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(121, 25);
            this.textBoxSupplier.TabIndex = 22;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BackColor = System.Drawing.Color.White;
            this.textBoxUnit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnit.Location = new System.Drawing.Point(175, 255);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(121, 25);
            this.textBoxUnit.TabIndex = 23;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownStock.Location = new System.Drawing.Point(175, 286);
            this.numericUpDownStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(121, 25);
            this.numericUpDownStock.TabIndex = 24;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(174, 224);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(122, 25);
            this.numericUpDownPrice.TabIndex = 25;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(12, 226);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Цена";
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.DecimalPlaces = 2;
            this.numericUpDownDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDiscount.Location = new System.Drawing.Point(174, 317);
            this.numericUpDownDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(122, 25);
            this.numericUpDownDiscount.TabIndex = 27;
            // 
            // pictureBoxProductPhoto
            // 
            this.pictureBoxProductPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProductPhoto.Location = new System.Drawing.Point(318, 67);
            this.pictureBoxProductPhoto.Name = "pictureBoxProductPhoto";
            this.pictureBoxProductPhoto.Size = new System.Drawing.Size(142, 119);
            this.pictureBoxProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductPhoto.TabIndex = 28;
            this.pictureBoxProductPhoto.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(318, 193);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 28);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(318, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 28);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPicture.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(318, 224);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(142, 47);
            this.buttonAddPicture.TabIndex = 31;
            this.buttonAddPicture.Text = "Добавить изображение";
            this.buttonAddPicture.UseVisualStyleBackColor = false;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // EditProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 354);
            this.Controls.Add(this.buttonAddPicture);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxProductPhoto);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/редактирование товара";
            this.Load += new System.EventHandler(this.EditProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.PictureBox pictureBoxProductPhoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddPicture;
    }
}