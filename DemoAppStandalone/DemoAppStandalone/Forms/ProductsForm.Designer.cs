namespace DemoAppStandalone.Forms
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelFormName = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxStock = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelProdsAmount = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fLPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDummy = new System.Windows.Forms.Label();
            this.labelNotFound = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fLPanelProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonLogout);
            this.panelTop.Controls.Add(this.labelFormName);
            this.panelTop.Controls.Add(this.labelUserInfo);
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(679, 42);
            this.panelTop.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(120, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(81, 33);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Выход";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelFormName
            // 
            this.labelFormName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormName.Location = new System.Drawing.Point(3, 2);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(120, 40);
            this.labelFormName.TabIndex = 2;
            this.labelFormName.Text = "Список товаров";
            this.labelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserInfo.Location = new System.Drawing.Point(507, 1);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(171, 41);
            this.labelUserInfo.TabIndex = 1;
            this.labelUserInfo.Text = "Юрченко Иван Андреевич";
            this.labelUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.buttonAddProduct);
            this.panelMain.Controls.Add(this.buttonOrders);
            this.panelMain.Controls.Add(this.labelSupplier);
            this.panelMain.Controls.Add(this.labelProdsAmount);
            this.panelMain.Controls.Add(this.textBoxSearch);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(2, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(679, 50);
            this.panelMain.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxStock);
            this.panel2.Location = new System.Drawing.Point(226, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 25);
            this.panel2.TabIndex = 13;
            // 
            // comboBoxStock
            // 
            this.comboBoxStock.BackColor = System.Drawing.Color.White;
            this.comboBoxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStock.FormattingEnabled = true;
            this.comboBoxStock.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.comboBoxStock.Location = new System.Drawing.Point(0, 0);
            this.comboBoxStock.Name = "comboBoxStock";
            this.comboBoxStock.Size = new System.Drawing.Size(125, 23);
            this.comboBoxStock.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxSuppliers);
            this.panel1.Location = new System.Drawing.Point(431, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 25);
            this.panel1.TabIndex = 12;
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.BackColor = System.Drawing.Color.White;
            this.comboBoxSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(0, 0);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(125, 23);
            this.comboBoxSuppliers.TabIndex = 8;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProduct.Location = new System.Drawing.Point(577, 1);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(97, 23);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(577, 24);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(97, 23);
            this.buttonOrders.TabIndex = 10;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // labelSupplier
            // 
            this.labelSupplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplier.Location = new System.Drawing.Point(353, 2);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(72, 43);
            this.labelSupplier.TabIndex = 7;
            this.labelSupplier.Text = "Поставщик:";
            this.labelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProdsAmount
            // 
            this.labelProdsAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdsAmount.Location = new System.Drawing.Point(172, 2);
            this.labelProdsAmount.Name = "labelProdsAmount";
            this.labelProdsAmount.Size = new System.Drawing.Size(60, 43);
            this.labelProdsAmount.TabIndex = 5;
            this.labelProdsAmount.Text = "Кол-во товаров:";
            this.labelProdsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(48, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(119, 22);
            this.textBoxSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLPanelProducts
            // 
            this.fLPanelProducts.AutoScroll = true;
            this.fLPanelProducts.Controls.Add(this.labelDummy);
            this.fLPanelProducts.Location = new System.Drawing.Point(2, 98);
            this.fLPanelProducts.Name = "fLPanelProducts";
            this.fLPanelProducts.Size = new System.Drawing.Size(679, 283);
            this.fLPanelProducts.TabIndex = 5;
            // 
            // labelDummy
            // 
            this.labelDummy.AutoSize = true;
            this.labelDummy.Location = new System.Drawing.Point(3, 0);
            this.labelDummy.Name = "labelDummy";
            this.labelDummy.Size = new System.Drawing.Size(51, 14);
            this.labelDummy.TabIndex = 0;
            this.labelDummy.Text = "Заглушка";
            this.labelDummy.Visible = false;
            // 
            // labelNotFound
            // 
            this.labelNotFound.AutoSize = true;
            this.labelNotFound.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotFound.Location = new System.Drawing.Point(199, 213);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(278, 23);
            this.labelNotFound.TabIndex = 6;
            this.labelNotFound.Text = "По запросу ничего не найдено";
            this.labelNotFound.Visible = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.labelNotFound);
            this.Controls.Add(this.fLPanelProducts);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.fLPanelProducts.ResumeLayout(false);
            this.fLPanelProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.ComboBox comboBoxStock;
        private System.Windows.Forms.Label labelProdsAmount;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.FlowLayoutPanel fLPanelProducts;
        private System.Windows.Forms.Label labelDummy;
        private System.Windows.Forms.Label labelNotFound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}